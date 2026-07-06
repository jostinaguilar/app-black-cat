using AppBlackCat.Modelos;
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

namespace AppBlackCat.Vistas.Cotizaciones
{
    public partial class FrmCotizacion : Form
    {
        private readonly ClienteServicio _clienteServicio;
        private readonly ServicioServicio _servicioServicio;
        private readonly CotizacionServicio _cotizacionServicio;

        private List<CotizacionDetalle> _detallesTemporales = new List<CotizacionDetalle>();

        public FrmCotizacion()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            IClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            IServicioRepositorio servicioRepositorio = new ServicioRepositorio();
            ICotizacionRepositorio cotizacionRepositorio = new CotizacionRepositorio();

            _clienteServicio = new ClienteServicio(clienteRepositorio);
            _servicioServicio = new ServicioServicio(servicioRepositorio);
            _cotizacionServicio = new CotizacionServicio(cotizacionRepositorio);
        }

        public FrmCotizacion(int idCotizacion)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            IClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            IServicioRepositorio servicioRepositorio = new ServicioRepositorio();
            ICotizacionRepositorio cotizacionRepositorio = new CotizacionRepositorio();

            _clienteServicio = new ClienteServicio(clienteRepositorio);
            _servicioServicio = new ServicioServicio(servicioRepositorio);
            _cotizacionServicio = new CotizacionServicio(cotizacionRepositorio);
            
            this.Text = $"Detalle de Cotización #{idCotizacion}";
            lblTitulo.Text = $"Detalle de Cotización #{idCotizacion}";

            CargarDatosDeCotizacion(idCotizacion);

            BloquearControlesParaSoloLectura();
        }

        private void CargarDatosDeCotizacion(int idCotizacion)
        {
            try
            {
                var cotizacion = _cotizacionServicio.ObtenerPorId(idCotizacion);
                var cliente = _clienteServicio.ObtenerPorId(cotizacion.ClienteId);

                txtIdCliente.Text = cliente.Id.ToString();
                txtNombreCliente.Text = cliente.NombreCompleto;
                txtNumeroDocumento.Text = cliente.NumeroDocumento;

                dtpFechaEmision.Value = cotizacion.FechaEmision.ToDateTime(TimeOnly.MinValue);
                dtpFechaVigencia.Value = cotizacion.FechaVigencia.ToDateTime(TimeOnly.MinValue);

                var listaVisual = cotizacion.Detalles.Select(detalle => new
                {
                    IdServicio = detalle.ServicioId,
                    Servicio = _servicioServicio.ObtenerPorId(detalle.ServicioId).Descripcion,
                    Cantidad = detalle.Cantidad,
                    Precio = detalle.PrecioUnitario,
                    SubTotal = detalle.Subtotal
                }).ToList();

                UI.CargarData(dgvDetalles, listaVisual);

                if (dgvDetalles.Columns["IdServicio"] != null)
                {
                    dgvDetalles.Columns["IdServicio"]?.Visible = false;
                }


                lblTotal.Text = cotizacion.Total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BloquearControlesParaSoloLectura()
        {
            txtNumeroDocumento.ReadOnly = true;
            btnBuscar.Enabled = false;
            dtpFechaEmision.Enabled = false;
            dtpFechaVigencia.Enabled = false;

            cmbServicios.Enabled = false;
            nudCantidad.Enabled = false;
            btnAgregar.Visible = false;

            btnGuardar.Visible = false;
        }

        private void FrmCotizacion_Load(object sender, EventArgs e)
        {
            var servicios = _servicioServicio.ObtenerTodos();
            var serviciosOrdenados = servicios.OrderBy(s => s.Descripcion).ToList();
            cmbServicios.DataSource = serviciosOrdenados;
            cmbServicios.DisplayMember = "Descripcion";
            cmbServicios.ValueMember = "Id";
            cmbServicios.SelectedIndex = -1;

            dtpFechaEmision.Value = DateTime.Now;

            dtpFechaVigencia.Value = DateTime.Now.AddDays(5);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbServicios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un servicio.");
                return;
            }

            var servicioSeleccionado = (Servicio)cmbServicios.SelectedItem;
            int cantidad = (int)nudCantidad.Value;

            var nuevoDetalle = new CotizacionDetalle
            {
                ServicioId = servicioSeleccionado.Id,
                Cantidad = cantidad,
                PrecioUnitario = servicioSeleccionado.Precio
            };

            _detallesTemporales.Add(nuevoDetalle);

            Refrescar();
            cmbServicios.SelectedIndex = -1;
            nudCantidad.Value = 1;
        }

        private void Refrescar()
        {
            var lista = _detallesTemporales.Select(detalle => new
            {
                IdServicio = detalle.ServicioId,
                Servicio = _servicioServicio.ObtenerPorId(detalle.ServicioId).Descripcion,
                detalle.Cantidad,
                Precio = detalle.PrecioUnitario,
                detalle.Subtotal
            }).ToList();

            UI.CargarData(dgvDetalles, lista);

            if (dgvDetalles.Columns["IdServicio"] != null)
            {
                dgvDetalles.Columns["IdServicio"]?.Visible = false;
            }

            decimal total = _detallesTemporales.Sum(d => d.Subtotal);
            lblTotal.Text = total.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_detallesTemporales.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un servicio a la cotización.");
                return;
            }

            try
            {
                var nuevaCotizacion = new Cotizacion
                {
                    ClienteId = int.Parse(txtIdCliente.Text),
                    UsuarioId = Session.UsuarioActivo.Id,
                    FechaEmision = DateOnly.FromDateTime(dtpFechaEmision.Value),
                    FechaVigencia = DateOnly.FromDateTime(dtpFechaVigencia.Value),
                    Detalles = _detallesTemporales,
                    Estado = Cotizacion.EstadoEnum.Pendiente
                };

                _cotizacionServicio.Registrar(nuevaCotizacion);

                MessageBox.Show("¡Cotización generada con éxito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (Validador.EsVacio(txtNumeroDocumento.Text.Trim()))
                    throw new ArgumentException("Debe ingresar un número de documento.");

                if (!Validador.TieneLongitudExacta(txtNumeroDocumento.Text.Trim(), 8) && !Validador.TieneLongitudExacta(txtNumeroDocumento.Text.Trim(), 11))
                    throw new ArgumentException("El número de documento debe tener 8 o 11 dígitos.");

                var cliente = _clienteServicio.ObtenerPorDocumento(txtNumeroDocumento.Text.Trim());

                if (cliente == null)
                {
                    using FrmCliente frmCliente = new FrmCliente(txtNumeroDocumento.Text.Trim());

                    var resultado = frmCliente.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        cliente = _clienteServicio.ObtenerPorDocumento(txtNumeroDocumento.Text.Trim());
                    }
                    else
                    {
                        return;
                    }
                }

                txtIdCliente.Text = cliente?.Id.ToString();
                txtNombreCliente.Text = cliente?.NombreCompleto;


            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
