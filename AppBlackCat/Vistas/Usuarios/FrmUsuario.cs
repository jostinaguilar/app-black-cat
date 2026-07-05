using AppBlackCat.Modelos;
using AppBlackCat.Repositorios;
using AppBlackCat.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppBlackCat.Vistas.Usuarios
{
    public partial class FrmUsuario : Form
    {
        private readonly UsuarioServicio _usuarioServicio;
        private int? _idEdicion = null;

        public FrmUsuario()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            IUsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            _usuarioServicio = new UsuarioServicio(usuarioRepositorio);
        }

        public FrmUsuario(int idUsuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            IUsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            _usuarioServicio = new UsuarioServicio(usuarioRepositorio);

            _idEdicion = idUsuario;

            this.Text = "Editar Usuario | Black Cat";
            lblTitulo.Text = "Editar Usuario";
            btnGuardar.Text = "Actualizar";

            CargarDatosUsuario(idUsuario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario
                {
                    NombreCompleto = txtNombre.Text.Trim(),
                    NombreUsuario = txtNombreUsuario.Text.Trim(),
                    Contrasenia = txtContrasenia.Text.Trim(),
                    Rol = cmbRolUsuario.Text,
                    CorreoElectronico = txtCorreoElectronico.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim()
                };

                if (_idEdicion == null)
                {
                    _usuarioServicio.RegistrarUsuario(usuario);
                    MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    usuario.Id = _idEdicion.Value;
                    _usuarioServicio.Actualizar(usuario);
                    MessageBox.Show("Usuario actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCampos();

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarDatosUsuario(int idUsuario)
        {
            try
            {
                var usuario = _usuarioServicio.ObtenerPorId(idUsuario);
                if (usuario != null)
                {
                    txtNombre.Text = usuario.NombreCompleto;
                    txtNombreUsuario.Text = usuario.NombreUsuario;
                    txtContrasenia.Text = usuario.Contrasenia;
                    cmbRolUsuario.Text = usuario.Rol;
                    txtCorreoElectronico.Text = usuario.CorreoElectronico;
                    txtTelefono.Text = usuario.Telefono;
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtNombreUsuario.Clear();
            txtContrasenia.Clear();
            cmbRolUsuario.SelectedIndex = -1;
            txtCorreoElectronico.Clear();
            txtTelefono.Clear();
        }
    }
}
