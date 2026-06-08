namespace Proyecto_Integrador.Views.Terrenos
{
    partial class CalculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculoForm));
            panelTitulo = new Panel();
            label6 = new Label();
            tablaPuntos = new DataGridView();
            nupAltura = new NumericUpDown();
            nupDx = new NumericUpDown();
            nupDy = new NumericUpDown();
            lblResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nupFilas = new NumericUpDown();
            nupColumnas = new NumericUpDown();
            label5 = new Label();
            btnCalcular = new Button();
            txtNombre = new TextBox();
            label7 = new Label();
            btnCrear = new Button();
            btnDatos = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnGraficar = new Button();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaPuntos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupDx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupDy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupFilas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupColumnas).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Controls.Add(label6);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(987, 63);
            panelTitulo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 64);
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(361, 17);
            label6.Name = "label6";
            label6.Size = new Size(195, 28);
            label6.TabIndex = 8;
            label6.Text = "Calculo de terrenos";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tablaPuntos
            // 
            tablaPuntos.AllowUserToAddRows = false;
            tablaPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaPuntos.Location = new Point(64, 133);
            tablaPuntos.Name = "tablaPuntos";
            tablaPuntos.RowHeadersWidth = 80;
            tablaPuntos.Size = new Size(812, 295);
            tablaPuntos.TabIndex = 7;
            // 
            // nupAltura
            // 
            nupAltura.DecimalPlaces = 2;
            nupAltura.Location = new Point(203, 498);
            nupAltura.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupAltura.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            nupAltura.Name = "nupAltura";
            nupAltura.Size = new Size(80, 27);
            nupAltura.TabIndex = 11;
            // 
            // nupDx
            // 
            nupDx.DecimalPlaces = 2;
            nupDx.Location = new Point(432, 499);
            nupDx.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupDx.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupDx.Name = "nupDx";
            nupDx.Size = new Size(80, 27);
            nupDx.TabIndex = 12;
            nupDx.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nupDy
            // 
            nupDy.DecimalPlaces = 2;
            nupDy.Location = new Point(667, 499);
            nupDy.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupDy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupDy.Name = "nupDy";
            nupDy.Size = new Size(80, 27);
            nupDy.TabIndex = 13;
            nupDy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.FromArgb(0, 0, 64);
            lblResultado.Location = new Point(64, 540);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(116, 31);
            lblResultado.TabIndex = 14;
            lblResultado.Text = "Volumen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 499);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 15;
            label1.Text = "Cota de corte h:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 499);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 16;
            label2.Text = "Δx (m):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(598, 499);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 17;
            label3.Text = "Δx (m):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(477, 95);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 18;
            label4.Text = "Filas:";
            // 
            // nupFilas
            // 
            nupFilas.Location = new Point(523, 94);
            nupFilas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nupFilas.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nupFilas.Name = "nupFilas";
            nupFilas.Size = new Size(50, 27);
            nupFilas.TabIndex = 19;
            nupFilas.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // nupColumnas
            // 
            nupColumnas.Location = new Point(706, 95);
            nupColumnas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nupColumnas.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nupColumnas.Name = "nupColumnas";
            nupColumnas.Size = new Size(50, 27);
            nupColumnas.TabIndex = 21;
            nupColumnas.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(610, 95);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 20;
            label5.Text = "Columnas:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 0, 64);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(64, 446);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 33);
            btnCalcular.TabIndex = 22;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 27);
            txtNombre.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 95);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 24;
            label7.Text = "Nombre:";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(0, 0, 64);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(788, 88);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(88, 30);
            btnCrear.TabIndex = 25;
            btnCrear.Text = "Crear";
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnDatos
            // 
            btnDatos.BackColor = Color.White;
            btnDatos.FlatStyle = FlatStyle.Flat;
            btnDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatos.ForeColor = Color.Black;
            btnDatos.Location = new Point(787, 446);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(89, 33);
            btnDatos.TabIndex = 26;
            btnDatos.Text = "Datos";
            btnDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDatos.UseVisualStyleBackColor = false;
            btnDatos.Click += btnDatos_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(609, 558);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(10, 5, 0, 5);
            btnCancelar.Size = new Size(121, 36);
            btnCancelar.TabIndex = 52;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 64);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(746, 558);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 5, 0, 5);
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 51;
            btnGuardar.Text = " Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnGraficar
            // 
            btnGraficar.BackColor = Color.FromArgb(0, 0, 64);
            btnGraficar.FlatStyle = FlatStyle.Flat;
            btnGraficar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGraficar.ForeColor = Color.White;
            btnGraficar.Location = new Point(437, 446);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(119, 33);
            btnGraficar.TabIndex = 53;
            btnGraficar.Text = "Graficar";
            btnGraficar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGraficar.UseVisualStyleBackColor = false;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // CalculoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 626);
            Controls.Add(btnGraficar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnDatos);
            Controls.Add(btnCrear);
            Controls.Add(label7);
            Controls.Add(txtNombre);
            Controls.Add(btnCalcular);
            Controls.Add(nupColumnas);
            Controls.Add(label5);
            Controls.Add(nupFilas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(nupDy);
            Controls.Add(nupDx);
            Controls.Add(nupAltura);
            Controls.Add(tablaPuntos);
            Controls.Add(panelTitulo);
            Name = "CalculoForm";
            Text = "CalculoForm";
            Load += TerrenoForm_Load;
            Resize += CalculoForm_Resize;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaPuntos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupDx).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupDy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupFilas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupColumnas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitulo;
        private DataGridView tablaPuntos;
        private NumericUpDown nupAltura;
        private NumericUpDown nupDx;
        private NumericUpDown nupDy;
        private Label lblResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown nupFilas;
        private NumericUpDown nupColumnas;
        private Label label5;
        private Button btnCalcular;
        private Label label6;
        private TextBox txtNombre;
        private Label label7;
        private Button btnCrear;
        private Button btnDatos;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnGraficar;
    }
}