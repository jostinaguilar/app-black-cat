namespace AppBlackCat.Vistas.Clientes
{
    partial class FrmCliente
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
            label8 = new Label();
            cmbTipoDocumento = new ComboBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            cmbTipoCliente = new ComboBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            label10 = new Label();
            txtDireccion = new TextBox();
            label9 = new Label();
            txtCorreoElectronico = new TextBox();
            lblTitulo = new Label();
            btnCancelar = new Button();
            label5 = new Label();
            txtNumeroDocumento = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 63);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 7;
            label8.Text = "Tipo Documento";
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Items.AddRange(new object[] { "DNI", "RUC" });
            cmbTipoDocumento.Location = new Point(20, 81);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(100, 23);
            cmbTipoDocumento.TabIndex = 9;
            cmbTipoDocumento.SelectedIndexChanged += cmbTipoDocumento_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 115);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 12;
            label3.Text = "Nombre de Cliente";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(290, 23);
            txtNombre.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 167);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 8;
            label2.Text = "Tipo de Cliente";
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Items.AddRange(new object[] { "Persona", "Empresa" });
            cmbTipoCliente.Location = new Point(20, 185);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(100, 23);
            cmbTipoCliente.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(130, 167);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 13;
            label4.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(130, 185);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 23);
            txtTelefono.TabIndex = 17;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(170, 336);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(20, 274);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 14;
            label10.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(22, 292);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(288, 23);
            txtDireccion.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 222);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 15;
            label9.Text = "Correo Eléctronico";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(20, 240);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(290, 23);
            txtCorreoElectronico.TabIndex = 19;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(90, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(157, 30);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Nuevo Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(20, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 23);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 63);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 22;
            label5.Text = "Número de documento";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(130, 81);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(180, 23);
            txtNumeroDocumento.TabIndex = 23;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 381);
            Controls.Add(label5);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(btnCancelar);
            Controls.Add(lblTitulo);
            Controls.Add(label8);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(cmbTipoCliente);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(btnGuardar);
            Controls.Add(label10);
            Controls.Add(txtDireccion);
            Controls.Add(label9);
            Controls.Add(txtCorreoElectronico);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCliente";
            Text = "Nuevo Cliente | Black Cat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private ComboBox cmbTipoDocumento;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private ComboBox cmbTipoCliente;
        private Label label4;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Label label10;
        private TextBox txtDireccion;
        private Label label9;
        private TextBox txtCorreoElectronico;
        private Label lblTitulo;
        private Button btnCancelar;
        private Label label5;
        private TextBox txtNumeroDocumento;
    }
}