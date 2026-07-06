using AppBlackCat.Vistas.Cotizaciones;
using AppBlackCat.Vistas.Servicios;
using AppBlackCat.Vistas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppBlackCat.Vistas
{
    public partial class FrmPrincipal : Form
    {
        private Form _formActivo = null;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmCotizaciones());
        }

        public void AbrirFormularioEnPanel(Form formHijo)
        {
            if (_formActivo != null)
            {
                _formActivo.Close();
            }

            _formActivo = formHijo;

            formHijo.TopLevel = false;

            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnFrmClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmClientes());
        }

        private void btnFrmUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmUsuarios());
        }

        private void btnFrmServicios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmServicios());
        }

        private void btnFormCotizaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmCotizaciones());
        }
    }
}
