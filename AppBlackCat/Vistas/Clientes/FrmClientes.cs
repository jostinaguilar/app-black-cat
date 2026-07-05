using AppBlackCat.Repositorios;
using AppBlackCat.Servicios;
using AppBlackCat.Utilidades;
using AppBlackCat.Vistas.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppBlackCat.Vistas
{
    public partial class FrmClientes : Form
    {
        private readonly ClienteServicio _clienteServicio;

        public FrmClientes()
        {
            InitializeComponent();

            IClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            _clienteServicio = new ClienteServicio(clienteRepositorio);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            using FrmCliente frmCliente = new FrmCliente();

            var resultado = frmCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CargarClientes();
            }

        }

        private void CargarClientes()
        {
            var clientes = _clienteServicio.ObtenerTodos();

            var clientesOrdenados = clientes.OrderByDescending(c => c.Id).ToList();

            UI.CargarData(dgvClientes, clientesOrdenados);
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idClienteSeleccionado = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id"].Value);

            using FrmCliente frmCliente = new FrmCliente(idClienteSeleccionado);

            var resultado = frmCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CargarClientes();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idClienteSeleccionado = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id"].Value);
            string nombreCliente = dgvClientes.SelectedRows[0].Cells["NombreCompleto"].Value?.ToString() ?? "";

            DialogResult confirmar = MessageBox.Show($"¿Está seguro de que desea eliminar al cliente '{nombreCliente}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    _clienteServicio.EliminarCliente(idClienteSeleccionado);

                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al eliminar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmClientes_Shown(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text.Trim()))
            {
                MessageBox.Show("Ingrese un DNI, RUC o Nombre para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var clientesFiltrados = _clienteServicio.BuscarClientes(txtBuscar.Text.Trim());
                UI.CargarData(dgvClientes, clientesFiltrados);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
