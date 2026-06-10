namespace Proyecto_Integrador.Views.Cotizaciones
{
    partial class FormEditarCotizacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarCotizacion));
            panel1 = new Panel();
            lblTitulo = new Label();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblTerreno = new Label();
            cmbTerreno = new ComboBox();
            lblVolumen = new Label();
            txtVolumen = new TextBox();
            lblMaterial = new Label();
            cmbMaterial = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 64);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 0, 64);
            lblTitulo.Location = new Point(88, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(173, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Editar Cotización";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(44, 86);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(191, 86);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(272, 28);
            cmbCliente.TabIndex = 2;
            // 
            // lblTerreno
            // 
            lblTerreno.AutoSize = true;
            lblTerreno.Location = new Point(44, 138);
            lblTerreno.Name = "lblTerreno";
            lblTerreno.Size = new Size(59, 20);
            lblTerreno.TabIndex = 3;
            lblTerreno.Text = "Terreno";
            // 
            // cmbTerreno
            // 
            cmbTerreno.FormattingEnabled = true;
            cmbTerreno.Location = new Point(191, 135);
            cmbTerreno.Name = "cmbTerreno";
            cmbTerreno.Size = new Size(272, 28);
            cmbTerreno.TabIndex = 4;
            cmbTerreno.SelectedIndexChanged += cmbTerreno_SelectedIndexChanged;
            // 
            // lblVolumen
            // 
            lblVolumen.AutoSize = true;
            lblVolumen.Location = new Point(44, 183);
            lblVolumen.Name = "lblVolumen";
            lblVolumen.Size = new Size(67, 20);
            lblVolumen.TabIndex = 5;
            lblVolumen.Text = "Volumen";
            // 
            // txtVolumen
            // 
            txtVolumen.Location = new Point(191, 180);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.ReadOnly = true;
            txtVolumen.Size = new Size(272, 27);
            txtVolumen.TabIndex = 6;
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(44, 230);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(64, 20);
            lblMaterial.TabIndex = 7;
            lblMaterial.Text = "Material";
            // 
            // cmbMaterial
            // 
            cmbMaterial.FormattingEnabled = true;
            cmbMaterial.Location = new Point(191, 227);
            cmbMaterial.Name = "cmbMaterial";
            cmbMaterial.Size = new Size(272, 28);
            cmbMaterial.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 64);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(268, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Location = new Point(368, 275);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 29);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEditarCotizacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(519, 330);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbMaterial);
            Controls.Add(lblMaterial);
            Controls.Add(txtVolumen);
            Controls.Add(lblVolumen);
            Controls.Add(cmbTerreno);
            Controls.Add(lblTerreno);
            Controls.Add(cmbCliente);
            Controls.Add(lblCliente);
            Controls.Add(panel1);
            Name = "FormEditarCotizacion";
            Text = "Editar Cotización";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblTerreno;
        private System.Windows.Forms.ComboBox cmbTerreno;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}