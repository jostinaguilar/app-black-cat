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

namespace AppBlackCat.Vistas
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioServicio _usuarioServicio;

        public FrmLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            IUsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            _usuarioServicio = new UsuarioServicio(usuarioRepositorio);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtNombreUsuario.Text.Trim();
                string password = txtContrasenia.Text.Trim();

                if (Validador.EsVacio(username) || Validador.EsVacio(password))
                    throw new ArgumentException("Debe ingresar el usuario y la contraseña.");

                var usuarioLogueado = _usuarioServicio.Autenticar(username, password);
                Session.UsuarioActivo = usuarioLogueado;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
