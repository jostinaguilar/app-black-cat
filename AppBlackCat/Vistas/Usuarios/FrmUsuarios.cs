using AppBlackCat.Repositorios;
using AppBlackCat.Servicios;
using AppBlackCat.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppBlackCat.Vistas.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioServicio _usuarioServicio;

        public FrmUsuarios()
        {
            InitializeComponent();

            IUsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            _usuarioServicio = new UsuarioServicio(usuarioRepositorio);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using FrmUsuario frmUsuario = new FrmUsuario();

            var resultado = frmUsuario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CargarUsuarios();
            }
        }

        public void CargarUsuarios()
        {
            var usuarios = _usuarioServicio.ObtenerTodos();
            var usuariosOrdenados = usuarios.OrderByDescending(u => u.Id).ToList();

            UI.CargarData(dgvUsuarios, usuariosOrdenados);
        }

        private void FrmUsuarios_Shown(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuarioSeleccionado = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

            using FrmUsuario frmUsuario = new FrmUsuario(idUsuarioSeleccionado);

            var resultado = frmUsuario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CargarUsuarios();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idClienteSeleccionado = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);
            string nombreCliente = dgvUsuarios.SelectedRows[0].Cells["NombreCompleto"].Value?.ToString() ?? "";

            DialogResult confirmar = MessageBox.Show($"¿Está seguro de que desea eliminar al usuario '{nombreCliente}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    _usuarioServicio.Eliminar(idClienteSeleccionado);

                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarUsuarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text.Trim()))
            {
                MessageBox.Show("Ingrese un Usuario o Nombre para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuariosFiltrados = _usuarioServicio.Buscar(txtBuscar.Text.Trim());
                UI.CargarData(dgvUsuarios, usuariosFiltrados);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
