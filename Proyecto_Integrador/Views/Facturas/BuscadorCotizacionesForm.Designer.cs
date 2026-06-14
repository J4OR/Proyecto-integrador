namespace Proyecto_Integrador.Views.Facturas
{
    partial class BuscadorCotizacionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscadorCotizacionesForm));
            tablaCotizaciones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            CC = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            btnFiltrarFecha = new Button();
            fechaFin = new DateTimePicker();
            fechaInicio = new DateTimePicker();
            txtBuscador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tablaCotizaciones).BeginInit();
            SuspendLayout();
            // 
            // tablaCotizaciones
            // 
            tablaCotizaciones.AllowUserToAddRows = false;
            tablaCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaCotizaciones.Columns.AddRange(new DataGridViewColumn[] { Id, Cliente, CC, Total, Estado, Fecha });
            tablaCotizaciones.Location = new Point(82, 101);
            tablaCotizaciones.Name = "tablaCotizaciones";
            tablaCotizaciones.RowHeadersWidth = 51;
            tablaCotizaciones.Size = new Size(934, 497);
            tablaCotizaciones.TabIndex = 10;
            tablaCotizaciones.CellDoubleClick += tablaCotizaciones_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // CC
            // 
            CC.HeaderText = "CC";
            CC.MinimumWidth = 6;
            CC.Name = "CC";
            CC.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // btnFiltrarFecha
            // 
            btnFiltrarFecha.Image = (Image)resources.GetObject("btnFiltrarFecha.Image");
            btnFiltrarFecha.Location = new Point(824, 36);
            btnFiltrarFecha.Name = "btnFiltrarFecha";
            btnFiltrarFecha.Size = new Size(42, 30);
            btnFiltrarFecha.TabIndex = 18;
            btnFiltrarFecha.UseVisualStyleBackColor = true;
            btnFiltrarFecha.Click += btnFiltrarFecha_Click;
            // 
            // fechaFin
            // 
            fechaFin.Format = DateTimePickerFormat.Short;
            fechaFin.Location = new Point(664, 39);
            fechaFin.Name = "fechaFin";
            fechaFin.Size = new Size(141, 27);
            fechaFin.TabIndex = 17;
            fechaFin.ValueChanged += fechaFin_ValueChanged;
            // 
            // fechaInicio
            // 
            fechaInicio.Format = DateTimePickerFormat.Short;
            fechaInicio.Location = new Point(506, 40);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(125, 27);
            fechaInicio.TabIndex = 16;
            // 
            // txtBuscador
            // 
            txtBuscador.ForeColor = Color.Black;
            txtBuscador.Location = new Point(82, 42);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(235, 27);
            txtBuscador.TabIndex = 15;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // BuscadorCotizacionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 635);
            Controls.Add(btnFiltrarFecha);
            Controls.Add(fechaFin);
            Controls.Add(fechaInicio);
            Controls.Add(txtBuscador);
            Controls.Add(tablaCotizaciones);
            Name = "BuscadorCotizacionesForm";
            Text = "BuscadorCotizacionesForm";
            Load += BuscadorCotizacionesForm_Load;
            ((System.ComponentModel.ISupportInitialize)tablaCotizaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaCotizaciones;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn CC;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
        private Button btnFiltrarFecha;
        private DateTimePicker fechaFin;
        private DateTimePicker fechaInicio;
        private TextBox txtBuscador;
    }
}