namespace Proyecto_Integrador.Views.Inicio.Terreno
{
    partial class TerrenoForm
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
            tablaPuntos = new DataGridView();
            nupCota = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)tablaPuntos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupDx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupDy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupFilas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupColumnas).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(987, 63);
            panelTitulo.TabIndex = 6;
            // 
            // tablaPuntos
            // 
            tablaPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaPuntos.Location = new Point(64, 133);
            tablaPuntos.Name = "tablaPuntos";
            tablaPuntos.RowHeadersWidth = 51;
            tablaPuntos.Size = new Size(700, 295);
            tablaPuntos.TabIndex = 7;
            // 
            // nupCota
            // 
            nupCota.DecimalPlaces = 2;
            nupCota.Location = new Point(203, 495);
            nupCota.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupCota.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            nupCota.Name = "nupCota";
            nupCota.Size = new Size(67, 27);
            nupCota.TabIndex = 11;
            // 
            // nupDx
            // 
            nupDx.DecimalPlaces = 2;
            nupDx.Location = new Point(432, 495);
            nupDx.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupDx.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupDx.Name = "nupDx";
            nupDx.Size = new Size(77, 27);
            nupDx.TabIndex = 12;
            nupDx.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nupDy
            // 
            nupDy.DecimalPlaces = 2;
            nupDy.Location = new Point(667, 495);
            nupDy.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupDy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupDy.Name = "nupDy";
            nupDy.Size = new Size(78, 27);
            nupDy.TabIndex = 13;
            nupDy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(64, 540);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(110, 31);
            lblResultado.TabIndex = 14;
            lblResultado.Text = "Volumen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 495);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 15;
            label1.Text = "Cota de corte h:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 495);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 16;
            label2.Text = "Δx (m):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(588, 495);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 17;
            label3.Text = "Δx (m):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 85);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 18;
            label4.Text = "Filas:";
            // 
            // nupFilas
            // 
            nupFilas.Location = new Point(110, 85);
            nupFilas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nupFilas.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nupFilas.Name = "nupFilas";
            nupFilas.Size = new Size(50, 27);
            nupFilas.TabIndex = 19;
            nupFilas.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // nupColumnas
            // 
            nupColumnas.Location = new Point(293, 85);
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
            label5.Location = new Point(201, 85);
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
            // 
            // TerrenoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 626);
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
            Controls.Add(nupCota);
            Controls.Add(tablaPuntos);
            Controls.Add(panelTitulo);
            Name = "TerrenoForm";
            Text = "TerrenoForm";
            Load += this.TerrenoForm_Load;
            ((System.ComponentModel.ISupportInitialize)tablaPuntos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupCota).EndInit();
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
        private NumericUpDown nupCota;
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
    }
}