namespace AppBlackCat.Vistas.Cotizaciones
{
    partial class FrmCotizaciones
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
            panelContenedor = new Panel();
            dgvCotizaciones = new DataGridView();
            panel1 = new Panel();
            cmbEstado = new ComboBox();
            btnRechazar = new Button();
            btnLimpiar = new Button();
            btnAprobar = new Button();
            btnNueva = new Button();
            label3 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            label1 = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCotizaciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(dgvCotizaciones);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(20);
            panelContenedor.Size = new Size(800, 450);
            panelContenedor.TabIndex = 22;
            // 
            // dgvCotizaciones
            // 
            dgvCotizaciones.AllowUserToAddRows = false;
            dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCotizaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCotizaciones.BackgroundColor = SystemColors.Control;
            dgvCotizaciones.BorderStyle = BorderStyle.None;
            dgvCotizaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCotizaciones.Dock = DockStyle.Fill;
            dgvCotizaciones.Location = new Point(20, 123);
            dgvCotizaciones.MultiSelect = false;
            dgvCotizaciones.Name = "dgvCotizaciones";
            dgvCotizaciones.ReadOnly = true;
            dgvCotizaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCotizaciones.Size = new Size(760, 307);
            dgvCotizaciones.TabIndex = 4;
            dgvCotizaciones.CellDoubleClick += dgvCotizaciones_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(btnRechazar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnAprobar);
            panel1.Controls.Add(btnNueva);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(btnBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(20, 50);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 10);
            panel1.Size = new Size(760, 73);
            panel1.TabIndex = 3;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "Aprobada", "Rechazada" });
            cmbEstado.Location = new Point(338, 32);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(80, 23);
            cmbEstado.TabIndex = 31;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // btnRechazar
            // 
            btnRechazar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRechazar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechazar.Location = new Point(687, 30);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(70, 23);
            btnRechazar.TabIndex = 30;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(425, 32);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(60, 23);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAprobar
            // 
            btnAprobar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAprobar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAprobar.Location = new Point(623, 30);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(60, 23);
            btnAprobar.TabIndex = 28;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Click += btnAprobar_Click;
            // 
            // btnNueva
            // 
            btnNueva.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNueva.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNueva.Location = new Point(557, 31);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(60, 23);
            btnNueva.TabIndex = 26;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 23;
            label3.Text = "Buscar por cliente";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(3, 31);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(260, 23);
            txtBuscar.TabIndex = 24;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(272, 31);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(60, 23);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(256, 30);
            label1.TabIndex = 2;
            label1.Text = "Gestión de Cotizaciones";
            // 
            // FrmCotizaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenedor);
            Name = "FrmCotizaciones";
            Text = "Cotizaciones | Black Cat";
            Shown += FrmCotizaciones_Shown;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCotizaciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private DataGridView dgvCotizaciones;
        private Panel panel1;
        private Button btnLimpiar;
        private Button btnAprobar;
        private Button btnNueva;
        private Label label3;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label1;
        private Button btnRechazar;
        private ComboBox cmbEstado;
    }
}