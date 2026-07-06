namespace AppBlackCat.Vistas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panelMenu = new Panel();
            btnSalir = new Button();
            btnFrmUsuarios = new Button();
            btnFrmClientes = new Button();
            btnFrmServicios = new Button();
            btnFormCotizaciones = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(btnFrmUsuarios);
            panelMenu.Controls.Add(btnFrmClientes);
            panelMenu.Controls.Add(btnFrmServicios);
            panelMenu.Controls.Add(btnFormCotizaciones);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 461);
            panelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 39, 42);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 39, 42);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.FromArgb(220, 30, 38);
            btnSalir.Image = Properties.Resources.logout;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 421);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(20, 0, 20, 0);
            btnSalir.Size = new Size(200, 40);
            btnSalir.TabIndex = 6;
            btnSalir.Text = " Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnFrmUsuarios
            // 
            btnFrmUsuarios.Dock = DockStyle.Top;
            btnFrmUsuarios.FlatAppearance.BorderSize = 0;
            btnFrmUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 39, 42);
            btnFrmUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 39, 42);
            btnFrmUsuarios.FlatStyle = FlatStyle.Flat;
            btnFrmUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFrmUsuarios.ForeColor = Color.White;
            btnFrmUsuarios.Image = Properties.Resources.users;
            btnFrmUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnFrmUsuarios.Location = new Point(0, 220);
            btnFrmUsuarios.Name = "btnFrmUsuarios";
            btnFrmUsuarios.Padding = new Padding(20, 0, 20, 0);
            btnFrmUsuarios.Size = new Size(200, 40);
            btnFrmUsuarios.TabIndex = 3;
            btnFrmUsuarios.Text = " Usuarios";
            btnFrmUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFrmUsuarios.UseVisualStyleBackColor = true;
            btnFrmUsuarios.Click += btnFrmUsuarios_Click;
            // 
            // btnFrmClientes
            // 
            btnFrmClientes.BackColor = Color.Black;
            btnFrmClientes.Dock = DockStyle.Top;
            btnFrmClientes.FlatAppearance.BorderSize = 0;
            btnFrmClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 39, 42);
            btnFrmClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 39, 42);
            btnFrmClientes.FlatStyle = FlatStyle.Flat;
            btnFrmClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFrmClientes.ForeColor = Color.White;
            btnFrmClientes.Image = Properties.Resources.handshake;
            btnFrmClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnFrmClientes.Location = new Point(0, 180);
            btnFrmClientes.Name = "btnFrmClientes";
            btnFrmClientes.Padding = new Padding(20, 0, 20, 0);
            btnFrmClientes.RightToLeft = RightToLeft.No;
            btnFrmClientes.Size = new Size(200, 40);
            btnFrmClientes.TabIndex = 4;
            btnFrmClientes.Text = " Clientes";
            btnFrmClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnFrmClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFrmClientes.UseMnemonic = false;
            btnFrmClientes.UseVisualStyleBackColor = false;
            btnFrmClientes.Click += btnFrmClientes_Click;
            // 
            // btnFrmServicios
            // 
            btnFrmServicios.Dock = DockStyle.Top;
            btnFrmServicios.FlatAppearance.BorderSize = 0;
            btnFrmServicios.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 39, 42);
            btnFrmServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 39, 42);
            btnFrmServicios.FlatStyle = FlatStyle.Flat;
            btnFrmServicios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFrmServicios.ForeColor = Color.White;
            btnFrmServicios.Image = Properties.Resources.tags;
            btnFrmServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnFrmServicios.Location = new Point(0, 140);
            btnFrmServicios.Name = "btnFrmServicios";
            btnFrmServicios.Padding = new Padding(20, 0, 20, 0);
            btnFrmServicios.Size = new Size(200, 40);
            btnFrmServicios.TabIndex = 7;
            btnFrmServicios.Text = " Servicios";
            btnFrmServicios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFrmServicios.UseVisualStyleBackColor = true;
            btnFrmServicios.Click += btnFrmServicios_Click;
            // 
            // btnFormCotizaciones
            // 
            btnFormCotizaciones.Dock = DockStyle.Top;
            btnFormCotizaciones.FlatAppearance.BorderSize = 0;
            btnFormCotizaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 39, 42);
            btnFormCotizaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 39, 42);
            btnFormCotizaciones.FlatStyle = FlatStyle.Flat;
            btnFormCotizaciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormCotizaciones.ForeColor = Color.White;
            btnFormCotizaciones.Image = Properties.Resources.clipboard_list;
            btnFormCotizaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnFormCotizaciones.Location = new Point(0, 100);
            btnFormCotizaciones.Name = "btnFormCotizaciones";
            btnFormCotizaciones.Padding = new Padding(20, 0, 20, 0);
            btnFormCotizaciones.Size = new Size(200, 40);
            btnFormCotizaciones.TabIndex = 1;
            btnFormCotizaciones.Text = " Cotizaciones";
            btnFormCotizaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFormCotizaciones.UseVisualStyleBackColor = true;
            btnFormCotizaciones.Click += btnFormCotizaciones_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(20);
            panelLogo.Size = new Size(200, 100);
            panelLogo.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(200, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(784, 461);
            panelContenedor.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            Text = "Black Cat";
            Load += FrmPrincipal_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContenedor;
        private Button btnFormCotizaciones;
        private Button btnFrmClientes;
        private Button btnFrmUsuarios;
        private Button btnSalir;
        private Button btnFrmServicios;
        private Panel panelLogo;
        private PictureBox pictureBox1;
    }
}