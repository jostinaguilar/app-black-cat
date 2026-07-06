namespace AppBlackCat.Vistas.Cotizaciones
{
    partial class FrmCotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            label5 = new Label();
            txtNumeroDocumento = new TextBox();
            label1 = new Label();
            txtNombreCliente = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            dtpFechaEmision = new DateTimePicker();
            dtpFechaVigencia = new DateTimePicker();
            label3 = new Label();
            btnAgregar = new Button();
            label4 = new Label();
            cmbServicios = new ComboBox();
            nudCantidad = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            btnGuardar = new Button();
            label8 = new Label();
            lblTotal = new Label();
            dgvDetalles = new DataGridView();
            txtIdCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(191, 30);
            lblTitulo.TabIndex = 42;
            lblTitulo.Text = "Nueva Cotización";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 60);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 43;
            label5.Text = "Número Documento";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(20, 78);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(120, 23);
            txtNumeroDocumento.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 60);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 45;
            label1.Text = "Nombre del Cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(223, 78);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.ReadOnly = true;
            txtNombreCliente.Size = new Size(300, 23);
            txtNombreCliente.TabIndex = 46;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(147, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(60, 23);
            btnBuscar.TabIndex = 47;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(539, 60);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 48;
            label2.Text = "Fecha de Emisión";
            // 
            // dtpFechaEmision
            // 
            dtpFechaEmision.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpFechaEmision.Enabled = false;
            dtpFechaEmision.Format = DateTimePickerFormat.Short;
            dtpFechaEmision.Location = new Point(539, 78);
            dtpFechaEmision.Name = "dtpFechaEmision";
            dtpFechaEmision.Size = new Size(116, 23);
            dtpFechaEmision.TabIndex = 49;
            // 
            // dtpFechaVigencia
            // 
            dtpFechaVigencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpFechaVigencia.Format = DateTimePickerFormat.Short;
            dtpFechaVigencia.Location = new Point(664, 78);
            dtpFechaVigencia.Name = "dtpFechaVigencia";
            dtpFechaVigencia.Size = new Size(116, 23);
            dtpFechaVigencia.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(664, 60);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 50;
            label3.Text = "Fecha de Vigencia";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Location = new Point(664, 133);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 23);
            btnAgregar.TabIndex = 52;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 117);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 53;
            label4.Text = "Seleccione un servicico";
            // 
            // cmbServicios
            // 
            cmbServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(20, 135);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(320, 23);
            cmbServicios.TabIndex = 54;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(355, 135);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 55;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(355, 117);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 56;
            label6.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 173);
            label7.Name = "label7";
            label7.Size = new Size(155, 20);
            label7.TabIndex = 58;
            label7.Text = "Detalle de Cotización";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.Location = new Point(660, 424);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 23);
            btnGuardar.TabIndex = 59;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 425);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 60;
            label8.Text = "Total: S/";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(84, 425);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 20);
            lblTotal.TabIndex = 61;
            lblTotal.Text = "0.00";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetalles.BackgroundColor = SystemColors.Control;
            dgvDetalles.BorderStyle = BorderStyle.None;
            dgvDetalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(20, 199);
            dgvDetalles.MultiSelect = false;
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(760, 209);
            dgvDetalles.TabIndex = 62;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(338, 52);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(23, 23);
            txtIdCliente.TabIndex = 63;
            txtIdCliente.Visible = false;
            // 
            // FrmCotizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 471);
            Controls.Add(txtIdCliente);
            Controls.Add(dgvDetalles);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(nudCantidad);
            Controls.Add(cmbServicios);
            Controls.Add(label4);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaVigencia);
            Controls.Add(label3);
            Controls.Add(dtpFechaEmision);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(txtNombreCliente);
            Controls.Add(label5);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCotizacion";
            Text = "Generar Cotización | Black Cat";
            Load += FrmCotizacion_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label5;
        private TextBox txtNumeroDocumento;
        private Label label1;
        private TextBox txtNombreCliente;
        private Button btnBuscar;
        private Label label2;
        private DateTimePicker dtpFechaEmision;
        private DateTimePicker dtpFechaVigencia;
        private Label label3;
        private Button btnAgregar;
        private Label label4;
        private ComboBox cmbServicios;
        private NumericUpDown nudCantidad;
        private Label label6;
        private Label label7;
        private Button btnGuardar;
        private Label label8;
        private Label lblTotal;
        private DataGridView dgvDetalles;
        private TextBox txtIdCliente;
    }
}