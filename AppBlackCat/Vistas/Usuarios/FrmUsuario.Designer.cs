namespace AppBlackCat.Vistas.Usuarios
{
    partial class FrmUsuario
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
            label5 = new Label();
            txtNombreUsuario = new TextBox();
            lblTitulo = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            cmbRolUsuario = new ComboBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label9 = new Label();
            txtCorreoElectronico = new TextBox();
            txtContrasenia = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 61);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 33;
            label5.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(22, 79);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(290, 23);
            txtNombreUsuario.TabIndex = 34;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(86, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 30);
            lblTitulo.TabIndex = 32;
            lblTitulo.Text = "Nuevo Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 117);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 26;
            label3.Text = "Nombre de completo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(290, 23);
            txtNombre.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 171);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 24;
            label2.Text = "Rol de usuario";
            // 
            // cmbRolUsuario
            // 
            cmbRolUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolUsuario.FormattingEnabled = true;
            cmbRolUsuario.Items.AddRange(new object[] { "Administrador", "Diseñador", "Impresor", "Ventas" });
            cmbRolUsuario.Location = new Point(22, 189);
            cmbRolUsuario.Name = "cmbRolUsuario";
            cmbRolUsuario.Size = new Size(90, 23);
            cmbRolUsuario.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 225);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 27;
            label4.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(22, 243);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(290, 23);
            txtTelefono.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 280);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 28;
            label9.Text = "Correo Eléctronico";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(22, 298);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(290, 23);
            txtCorreoElectronico.TabIndex = 31;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(130, 189);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '●';
            txtContrasenia.Size = new Size(182, 23);
            txtContrasenia.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 171);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 36;
            label1.Text = "Contraseña";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(22, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 23);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(172, 337);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 23);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 381);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(txtContrasenia);
            Controls.Add(label5);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(cmbRolUsuario);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label9);
            Controls.Add(txtCorreoElectronico);
            Name = "FrmUsuario";
            Text = "Registrar Usuario | Black Cat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtNombreUsuario;
        private Label lblTitulo;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private ComboBox cmbRolUsuario;
        private Label label4;
        private TextBox txtTelefono;
        private Label label9;
        private TextBox txtCorreoElectronico;
        private TextBox txtContrasenia;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}