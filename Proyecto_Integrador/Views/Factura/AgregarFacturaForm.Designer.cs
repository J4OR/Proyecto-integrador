namespace Proyecto_Integrador.Views
{
    partial class AgregarFacturaForm
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
            panelTitulo = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            textBox1 = new TextBox();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtTelefono = new TextBox();
            label8 = new Label();
            txtCorreo = new TextBox();
            label9 = new Label();
            txtIdentificaion = new TextBox();
            label7 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dtvgItems = new DataGridView();
            textBox2 = new TextBox();
            label10 = new Label();
            cbCotizaciones = new ComboBox();
            label11 = new Label();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Volumen = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label12 = new Label();
            panelTitulo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvgItems).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Controls.Add(panel1);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1169, 123);
            panelTitulo.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(924, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 102);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 4;
            label4.Text = "Fecha:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(67, 65);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(142, 27);
            dtpFecha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(12, 37);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 1;
            label3.Text = "N°:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(12, 5);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 0;
            label2.Text = "Numero Factura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(601, 38);
            label1.TabIndex = 25;
            label1.Text = "Sistema de Gestion de Movimiento de Tierra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtIdentificaion);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 115);
            panel2.TabIndex = 33;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(588, 74);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 27);
            txtTelefono.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(510, 77);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 11;
            label8.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(83, 74);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(367, 27);
            txtCorreo.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(16, 77);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 9;
            label9.Text = "Correo:";
            // 
            // txtIdentificaion
            // 
            txtIdentificaion.Location = new Point(588, 41);
            txtIdentificaion.Name = "txtIdentificaion";
            txtIdentificaion.Size = new Size(200, 27);
            txtIdentificaion.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(510, 44);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 7;
            label7.Text = "NIT / CC:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(367, 27);
            txtNombre.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(16, 44);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(16, 9);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 1;
            label5.Text = "Datos del cliente";
            // 
            // dtvgItems
            // 
            dtvgItems.AllowUserToAddRows = false;
            dtvgItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgItems.Columns.AddRange(new DataGridViewColumn[] { Descripcion, PrecioUnitario, Material, Volumen, Total });
            dtvgItems.Location = new Point(12, 299);
            dtvgItems.Name = "dtvgItems";
            dtvgItems.RowHeadersWidth = 51;
            dtvgItems.RowTemplate.Height = 40;
            dtvgItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvgItems.Size = new Size(1143, 271);
            dtvgItems.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 599);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(601, 86);
            textBox2.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 0, 64);
            label10.Location = new Point(12, 573);
            label10.Name = "label10";
            label10.Size = new Size(125, 23);
            label10.TabIndex = 36;
            label10.Text = "Observaciones";
            // 
            // cbCotizaciones
            // 
            cbCotizaciones.FormattingEnabled = true;
            cbCotizaciones.Location = new Point(859, 144);
            cbCotizaciones.Name = "cbCotizaciones";
            cbCotizaciones.Size = new Size(231, 28);
            cbCotizaciones.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 0, 64);
            label11.Location = new Point(749, 147);
            label11.Name = "label11";
            label11.Size = new Size(96, 20);
            label11.TabIndex = 37;
            label11.Text = "Cotizaciones";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion del servicio";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 200;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.Width = 136;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.Width = 125;
            // 
            // Volumen
            // 
            Volumen.HeaderText = "Volumen";
            Volumen.MinimumWidth = 6;
            Volumen.Name = "Volumen";
            Volumen.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(1096, 140);
            button1.Name = "button1";
            button1.Size = new Size(59, 34);
            button1.TabIndex = 38;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(776, 629);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 39;
            label12.Text = "label12";
            // 
            // AgregarFacturaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 709);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(cbCotizaciones);
            Controls.Add(label10);
            Controls.Add(textBox2);
            Controls.Add(dtvgItems);
            Controls.Add(panel2);
            Controls.Add(panelTitulo);
            Name = "AgregarFacturaForm";
            Text = "AgregarFacturaForm";
            Load += AgregarFacturaForm_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvgItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitulo;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtpFecha;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label label8;
        private TextBox txtCorreo;
        private Label label9;
        private TextBox txtIdentificaion;
        private Label label7;
        private DataGridView dtvgItems;
        private TextBox textBox2;
        private Label label10;
        private ComboBox cbCotizaciones;
        private Label label11;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Volumen;
        private DataGridViewTextBoxColumn Total;
        private Button button1;
        private Label label12;
    }
}