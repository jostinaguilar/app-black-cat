using AppBlackCat.Repositorios;
using AppBlackCat.Servicios;
using AppBlackCat.Utilidades;
using AppBlackCat.Vistas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppBlackCat.Vistas.Servicios
{
    public partial class FrmServicios : Form
    {
        private readonly ServicioServicio _servicioServicio;

        public FrmServicios()
        {
            InitializeComponent();

            IServicioRepositorio servicioRepositorio = new ServicioRepositorio();
            _servicioServicio = new ServicioServicio(servicioRepositorio);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using FrmServicio frmServicio = new FrmServicio();

            var resultado = frmServicio.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CargarServicios();
            }
        }

        public void CargarServicios(string filtro = "")
        {
            var servicios = _servicioServicio.ObtenerTodos();
            var serviciosOrdenados = servicios.OrderByDescending(s => s.Id).ToList();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                serviciosOrdenados = serviciosOrdenados
                    .Where(s => s.Descripcion.ToLower().Contains(filtro.ToLower()))
                    .ToList();
            }

            UI.CargarData(dgvServicios, serviciosOrdenados);
        }

        private void FrmServicios_Shown(object sender, EventArgs e)
        {
            CargarServicios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un servicio para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idServicioSeleccionado = Convert.ToInt32(dgvServicios.SelectedRows[0].Cells["Id"].Value);

            using FrmServicio frmUsuario = new FrmServicio(idServicioSeleccionado);

            var resultado = frmUsuario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CargarServicios();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            CargarServicios(filtro);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            CargarServicios();
        }
    }
}
