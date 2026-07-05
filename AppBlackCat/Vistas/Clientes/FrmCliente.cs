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

namespace AppBlackCat.Vistas.Clientes
{
    public partial class FrmCliente : Form
    {
        private readonly ClienteServicio _clienteServicio;
        private int? _idEdicion = null;

        public FrmCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            IClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            _clienteServicio = new ClienteServicio(clienteRepositorio);
        }

        public FrmCliente(int idCliente)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            IClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            _clienteServicio = new ClienteServicio(clienteRepositorio);

            _idEdicion = idCliente;

            this.Text = "Editar Cliente";
            lblTitulo.Text = "Editar Cliente";
            btnGuardar.Text = "Actualizar";

            CargarDatosCliente(idCliente);
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
                var cliente = new Cliente
                {
                    NombreCompleto = txtNombre.Text.Trim(),
                    TipoDocumento = cmbTipoDocumento.Text,
                    NumeroDocumento = txtNumeroDocumento.Text.Trim(),
                    TipoCliente = cmbTipoCliente.Text,
                    Direccion = txtDireccion.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    CorreoElectronico = txtCorreoElectronico.Text.Trim()
                };

                if (_idEdicion == null)
                {
                    _clienteServicio.RegistrarCliente(cliente);
                    MessageBox.Show("Cliente registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.Id = _idEdicion.Value;

                    _clienteServicio.ActualizarCliente(cliente);
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Ocurrió un error al registrar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosCliente(int idCliente)
        {
            try
            {
                var cliente = _clienteServicio.ObtenerPorId(idCliente);

                txtNombre.Text = cliente.NombreCompleto;
                txtNumeroDocumento.Text = cliente.NumeroDocumento;
                cmbTipoDocumento.Text = cliente.TipoDocumento;
                txtTelefono.Text = cliente.Telefono;
                txtCorreoElectronico.Text = cliente.CorreoElectronico;
                txtDireccion.Text = cliente.Direccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cmbTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            cmbTipoCliente.SelectedIndex = -1;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreoElectronico.Clear();
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.Text == "DNI")
            {
                cmbTipoCliente.Text = "Persona";
            }
            else
            {
                cmbTipoCliente.Text = "Empresa";
            }
        }
    }
}
