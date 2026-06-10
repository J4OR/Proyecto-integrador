namespace Proyecto_Integrador.Views.Cotizaciones
{
    partial class FormAddCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCotizacion));
            BoxCliente = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblCliente = new Label();
            lblUnidad = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            BoxMaterial = new ComboBox();
            AddCotizacion = new Button();
            label2 = new Label();
            btnCancelar = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BoxCliente
            // 
            BoxCliente.FormattingEnabled = true;
            BoxCliente.Location = new Point(191, 83);
            BoxCliente.Name = "BoxCliente";
            BoxCliente.Size = new Size(272, 28);
            BoxCliente.TabIndex = 0;
            BoxCliente.SelectedIndexChanged += BoxCliente_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 64);
            panel1.TabIndex = 54;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(88, 21);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 1;
            label1.Text = "Agregar Factura";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(44, 86);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 55;
            lblCliente.Text = "Cliente";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Location = new Point(44, 138);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(59, 20);
            lblUnidad.TabIndex = 56;
            lblUnidad.Text = "Terreno";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(191, 135);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(272, 28);
            comboBox2.TabIndex = 57;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 27);
            textBox1.TabIndex = 58;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BoxMaterial
            // 
            BoxMaterial.FormattingEnabled = true;
            BoxMaterial.Location = new Point(191, 222);
            BoxMaterial.Name = "BoxMaterial";
            BoxMaterial.Size = new Size(272, 28);
            BoxMaterial.TabIndex = 59;
            BoxMaterial.SelectedIndexChanged += BoxMaterial_SelectedIndexChanged;
            // 
            // AddCotizacion
            // 
            AddCotizacion.BackColor = Color.FromArgb(0, 0, 64);
            AddCotizacion.ForeColor = SystemColors.ButtonHighlight;
            AddCotizacion.Location = new Point(243, 256);
            AddCotizacion.Name = "AddCotizacion";
            AddCotizacion.Size = new Size(94, 29);
            AddCotizacion.TabIndex = 60;
            AddCotizacion.Text = "Agregar";
            AddCotizacion.UseVisualStyleBackColor = false;
            AddCotizacion.Click += AddCotizacion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 225);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 61;
            label2.Text = "Material";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(369, 256);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 61;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 183);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 62;
            label3.Text = "Volumen";
            // 
            // FormAddCotizacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(519, 297);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AddCotizacion);
            Controls.Add(BoxMaterial);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(lblUnidad);
            Controls.Add(lblCliente);
            Controls.Add(panel1);
            Controls.Add(BoxCliente);
            Controls.Add(btnCancelar);
            Name = "FormAddCotizacion";
            Text = "FormAddCotizacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox BoxCliente;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblCliente;
        private Label lblUnidad;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private ComboBox BoxMaterial;
        private Button AddCotizacion;
        private Label label2;
        private Button btnCancelar;
        private Label label3;
    }
}