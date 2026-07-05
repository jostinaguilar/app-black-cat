namespace AppBlackCat.Vistas.Servicios
{
    partial class FrmServicio
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
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            cmbCategoria = new ComboBox();
            lblTitulo = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 66);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 39;
            label5.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(22, 84);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(290, 23);
            txtDescripcion.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 186);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 37;
            label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(22, 204);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(290, 23);
            txtPrecio.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 125);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 35;
            label2.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Impresión Publicitaria", "Diseño Gráfico", "Producción Audiovisual", "Merchandising" });
            cmbCategoria.Location = new Point(22, 143);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(290, 23);
            cmbCategoria.TabIndex = 36;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(79, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 30);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Nuevo Servicio";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(22, 252);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 23);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(172, 252);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 23);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 302);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(cmbCategoria);
            Name = "FrmServicio";
            Text = "Registrar Servicio | Black Cat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtPrecio;
        private Label label2;
        private ComboBox cmbCategoria;
        private Label lblTitulo;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}