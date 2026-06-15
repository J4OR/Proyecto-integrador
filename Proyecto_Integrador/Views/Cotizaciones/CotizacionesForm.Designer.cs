namespace Proyecto_Integrador.Views.Cotizaciones
{
    partial class CotizacionesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CotizacionesForm));
            btnAgregar = new Button();
            tablaCotizaciones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewButtonColumn();
            txtBuscador = new TextBox();
            label1 = new Label();
            panelTitulo = new Panel();
            fechaInicio = new DateTimePicker();
            fechaFin = new DateTimePicker();
            btnFiltrarFecha = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaCotizaciones).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 0, 64);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(902, 115);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 33);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Nueva Cotizacion";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tablaCotizaciones
            // 
            tablaCotizaciones.AllowUserToAddRows = false;
            tablaCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaCotizaciones.Columns.AddRange(new DataGridViewColumn[] { Id, Cliente, Identificacion, Total, Estado, Fecha, Accion });
            tablaCotizaciones.Location = new Point(74, 170);
            tablaCotizaciones.Name = "tablaCotizaciones";
            tablaCotizaciones.RowHeadersWidth = 51;
            tablaCotizaciones.Size = new Size(968, 502);
            tablaCotizaciones.TabIndex = 9;
            tablaCotizaciones.CellClick += tablaCotizaciones_CellClick;
            tablaCotizaciones.CellFormatting += tablaCotizaciones_CellFormatting;
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
            // Identificacion
            // 
            Identificacion.HeaderText = "Identificacion";
            Identificacion.MinimumWidth = 6;
            Identificacion.Name = "Identificacion";
            Identificacion.Width = 125;
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
            // Accion
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Accion.DefaultCellStyle = dataGridViewCellStyle1;
            Accion.FlatStyle = FlatStyle.Flat;
            Accion.HeaderText = "Activar/Desactivar";
            Accion.MinimumWidth = 6;
            Accion.Name = "Accion";
            Accion.Text = "Activar/Desactivar";
            Accion.UseColumnTextForButtonValue = true;
            Accion.Width = 140;
            // 
            // txtBuscador
            // 
            txtBuscador.ForeColor = Color.Black;
            txtBuscador.Location = new Point(74, 118);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(235, 27);
            txtBuscador.TabIndex = 8;
            txtBuscador.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(404, 12);
            label1.Name = "label1";
            label1.Size = new Size(308, 28);
            label1.TabIndex = 7;
            label1.Text = "Administración de cotizaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1097, 63);
            panelTitulo.TabIndex = 10;
            // 
            // fechaInicio
            // 
            fechaInicio.Format = DateTimePickerFormat.Short;
            fechaInicio.Location = new Point(474, 119);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(125, 27);
            fechaInicio.TabIndex = 12;
            // 
            // fechaFin
            // 
            fechaFin.Format = DateTimePickerFormat.Short;
            fechaFin.Location = new Point(632, 118);
            fechaFin.Name = "fechaFin";
            fechaFin.Size = new Size(141, 27);
            fechaFin.TabIndex = 13;
            fechaFin.ValueChanged += FechaFin_ValueChanged;
            // 
            // btnFiltrarFecha
            // 
            btnFiltrarFecha.Image = (Image)resources.GetObject("btnFiltrarFecha.Image");
            btnFiltrarFecha.Location = new Point(792, 115);
            btnFiltrarFecha.Name = "btnFiltrarFecha";
            btnFiltrarFecha.Size = new Size(42, 30);
            btnFiltrarFecha.TabIndex = 14;
            btnFiltrarFecha.UseVisualStyleBackColor = true;
            btnFiltrarFecha.Click += btnFiltrarFecha_Click;
            // 
            // CotizacionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 708);
            Controls.Add(btnFiltrarFecha);
            Controls.Add(fechaFin);
            Controls.Add(fechaInicio);
            Controls.Add(btnAgregar);
            Controls.Add(tablaCotizaciones);
            Controls.Add(txtBuscador);
            Controls.Add(label1);
            Controls.Add(panelTitulo);
            Name = "CotizacionesForm";
            Text = "CotizacionesForm";
            Load += CotizacionesForm_Load;
            Resize += CotizacionesForm_Resize;
            ((System.ComponentModel.ISupportInitialize)tablaCotizaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView tablaCotizaciones;
        private TextBox txtBuscador;
        private Label label1;
        private Panel panelTitulo;
        private DateTimePicker fechaInicio;
        private DateTimePicker fechaFin;
        private Button btnFiltrarFecha;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewButtonColumn Accion;
    }
}