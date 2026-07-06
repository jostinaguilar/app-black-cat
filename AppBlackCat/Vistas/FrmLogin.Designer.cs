namespace AppBlackCat.Vistas
{
    partial class FrmLogin
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
            btnIniciarSesion = new Button();
            label1 = new Label();
            txtContrasenia = new TextBox();
            label5 = new Label();
            txtNombreUsuario = new TextBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(18, 219);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(290, 23);
            btnIniciarSesion.TabIndex = 49;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 152);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 48;
            label1.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(18, 170);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '●';
            txtContrasenia.Size = new Size(290, 23);
            txtContrasenia.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 90);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 45;
            label5.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(18, 108);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(290, 23);
            txtNombreUsuario.TabIndex = 46;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(98, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(148, 30);
            lblTitulo.TabIndex = 44;
            lblTitulo.Text = "Iniciar Sesión";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 291);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label1);
            Controls.Add(txtContrasenia);
            Controls.Add(label5);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblTitulo);
            Name = "FrmLogin";
            Text = "Login | Black Cat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private Label label1;
        private TextBox txtContrasenia;
        private Label label5;
        private TextBox txtNombreUsuario;
        private Label lblTitulo;
    }
}