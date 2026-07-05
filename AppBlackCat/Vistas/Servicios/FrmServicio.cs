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

namespace AppBlackCat.Vistas.Servicios
{
    public partial class FrmServicio : Form
    {
        private readonly ServicioServicio _servicioSevicio;

        private int? _idEdicion = null;

        public FrmServicio()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            IServicioRepositorio servicioRepositorio = new ServicioRepositorio();
            _servicioSevicio = new ServicioServicio(servicioRepositorio);
        }

        public FrmServicio(int idServicio)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            IServicioRepositorio servicioRepositorio = new ServicioRepositorio();
            _servicioSevicio = new ServicioServicio(servicioRepositorio);

            _idEdicion = idServicio;

            this.Text = "Editar Usuario | Black Cat";
            lblTitulo.Text = "Editar Usuario";
            btnGuardar.Text = "Actualizar";

            CargarDatosServicio(idServicio);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var servicio = new Servicio
                {
                    Descripcion = txtDescripcion.Text.Trim(),
                    Categoria = cmbCategoria.Text,
                    Precio = decimal.Parse(txtPrecio.Text.Trim())
                };

                if (_idEdicion == null)
                {
                    _servicioSevicio.Registrar(servicio);
                    MessageBox.Show("Servicio registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    servicio.Id = _idEdicion.Value;

                    _servicioSevicio.Actualizar(servicio);
                    MessageBox.Show("Servicio actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Ocurrió un error al registrar el servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarCampos()
        {
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
        }

        public void CargarDatosServicio(int idServicio)
        {
            try
            {
                var servicio = _servicioSevicio.ObtenerPorId(idServicio);
                if (servicio != null)
                {
                    txtDescripcion.Text = servicio.Descripcion;
                    cmbCategoria.Text = servicio.Categoria;
                    txtPrecio.Text = servicio.Precio.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el servicio especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos del servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
