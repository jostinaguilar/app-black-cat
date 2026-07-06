using AppBlackCat.Modelos;
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

namespace AppBlackCat.Vistas.Cotizaciones
{
    public partial class FrmCotizaciones : Form
    {
        private readonly CotizacionServicio _cotizacionServicio;
        private readonly ClienteServicio _clienteServicio;

        public FrmCotizaciones()
        {
            InitializeComponent();

            ICotizacionRepositorio cotizacionRepositorio = new CotizacionRepositorio();
            IClienteRepositorio clienteRepositorio = new ClienteRepositorio();

            _cotizacionServicio = new CotizacionServicio(cotizacionRepositorio);
            _clienteServicio = new ClienteServicio(clienteRepositorio);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            using FrmCotizacion frmCotizacion = new FrmCotizacion();

            var result = frmCotizacion.ShowDialog();

            if (result == DialogResult.OK)
            {
                CargarCotizaciones();
            }
        }

        public void CargarCotizaciones(string filtro = "")
        {
            var cotizaciones = _cotizacionServicio.ObtenerTodos();
            var cotizacionesOrdenados = cotizaciones.OrderByDescending(u => u.Id).ToList();

            var lista = cotizacionesOrdenados.Select(c => new
            {
                c.Id,
                Cliente = _clienteServicio.ObtenerPorId(c.ClienteId).NombreCompleto,
                c.FechaEmision,
                c.FechaVigencia,
                c.Total,
                c.Estado
            }).ToList();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                lista = lista
                    .Where(x => x.Cliente.ToLower().Contains(filtro.ToLower()) || x.Estado.ToString().Equals(filtro))
                    .ToList();
            }

            UI.CargarData(dgvCotizaciones, lista);

            dgvCotizaciones.Columns["Id"]?.Visible = false;
            dgvCotizaciones.Columns["UsuarioId"]?.Visible = false;
            dgvCotizaciones.Columns["FechaEmision"]?.HeaderText = "Fecha de Emisión";
            dgvCotizaciones.Columns["FechaVigencia"]?.HeaderText = "Fecha de Vigencia";
        }

        private void FrmCotizaciones_Shown(object sender, EventArgs e)
        {
            CargarCotizaciones();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (dgvCotizaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una cotización para aprobar.");
                return;
            }

            int idCotizacion = Convert.ToInt32(dgvCotizaciones.SelectedRows[0].Cells["Id"].Value);

            _cotizacionServicio.CambiarEstado(idCotizacion, Cotizacion.EstadoEnum.Aprobada);

            MessageBox.Show("Cotización aprobada. Lista para procesar el pedido.");
            CargarCotizaciones();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (dgvCotizaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una cotización para rechazar.");
                return;
            }

            int idCotizacion = Convert.ToInt32(dgvCotizaciones.SelectedRows[0].Cells["Id"].Value);

            _cotizacionServicio.CambiarEstado(idCotizacion, Cotizacion.EstadoEnum.Rechazada);

            MessageBox.Show("Cotización rechazada.");
            CargarCotizaciones();
        }

        private void dgvCotizaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idSeleccionado = Convert.ToInt32(dgvCotizaciones.SelectedRows[0].Cells["Id"].Value);

                using FrmCotizacion frmVer = new FrmCotizacion(idSeleccionado);

                frmVer.ShowDialog();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();
            cmbEstado.SelectedIndex = -1;

            CargarCotizaciones(textoBusqueda);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            cmbEstado.SelectedIndex = -1;
            CargarCotizaciones("");
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroEstado = cmbEstado.SelectedItem?.ToString() ?? "";

            CargarCotizaciones(filtroEstado);
        }
    }
}
