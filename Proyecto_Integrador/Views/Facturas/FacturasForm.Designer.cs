namespace Proyecto_Integrador.Views.Facturas
{
    partial class FacturasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnFecha = new Button();
            fechaFin = new DateTimePicker();
            fechaInicio = new DateTimePicker();
            btnCrearFactura = new Button();
            tablaFacturas = new DataGridView();
            txtBuscador = new TextBox();
            label1 = new Label();
            panelTitulo = new Panel();
            btnBuscar = new Button();
            Id = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Ver = new DataGridViewButtonColumn();
            Accion = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)tablaFacturas).BeginInit();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // btnFecha
            // 
            btnFecha.Image = (Image)resources.GetObject("btnFecha.Image");
            btnFecha.Location = new Point(812, 108);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(42, 30);
            btnFecha.TabIndex = 22;
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFecha_Click;
            // 
            // fechaFin
            // 
            fechaFin.Format = DateTimePickerFormat.Short;
            fechaFin.Location = new Point(661, 110);
            fechaFin.Name = "fechaFin";
            fechaFin.Size = new Size(145, 27);
            fechaFin.TabIndex = 21;
            fechaFin.ValueChanged += fechaFin_ValueChanged;
            // 
            // fechaInicio
            // 
            fechaInicio.Format = DateTimePickerFormat.Short;
            fechaInicio.Location = new Point(501, 110);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(132, 27);
            fechaInicio.TabIndex = 20;
            // 
            // btnCrearFactura
            // 
            btnCrearFactura.BackColor = Color.FromArgb(0, 0, 64);
            btnCrearFactura.FlatStyle = FlatStyle.Flat;
            btnCrearFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearFactura.ForeColor = Color.White;
            btnCrearFactura.Location = new Point(954, 104);
            btnCrearFactura.Name = "btnCrearFactura";
            btnCrearFactura.Size = new Size(140, 33);
            btnCrearFactura.TabIndex = 19;
            btnCrearFactura.Text = "Crear Factura";
            btnCrearFactura.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearFactura.UseVisualStyleBackColor = false;
            btnCrearFactura.Click += btnCrearFactura_Click;
            // 
            // tablaFacturas
            // 
            tablaFacturas.AllowUserToAddRows = false;
            tablaFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaFacturas.Columns.AddRange(new DataGridViewColumn[] { Id, Cliente, Identificacion, Descripcion, Total, Estado, Fecha, Ver, Accion });
            tablaFacturas.Location = new Point(98, 186);
            tablaFacturas.Name = "tablaFacturas";
            tablaFacturas.RowHeadersWidth = 51;
            tablaFacturas.Size = new Size(996, 497);
            tablaFacturas.TabIndex = 17;
            tablaFacturas.CellClick += tablaFacturas_CellClick;
            tablaFacturas.CellFormatting += tablaFacturas_CellFormatting;
            // 
            // txtBuscador
            // 
            txtBuscador.ForeColor = Color.Black;
            txtBuscador.Location = new Point(98, 111);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(235, 27);
            txtBuscador.TabIndex = 16;
            txtBuscador.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(624, 17);
            label1.Name = "label1";
            label1.Size = new Size(268, 28);
            label1.TabIndex = 15;
            label1.Text = "Administración de facturas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Location = new Point(-157, -8);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1325, 63);
            panelTitulo.TabIndex = 18;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(339, 111);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(42, 30);
            btnBuscar.TabIndex = 23;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
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
            // Ver
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 0, 64);
            Ver.DefaultCellStyle = dataGridViewCellStyle1;
            Ver.FlatStyle = FlatStyle.Flat;
            Ver.HeaderText = "Ver";
            Ver.MinimumWidth = 6;
            Ver.Name = "Ver";
            Ver.Text = "Ver";
            Ver.UseColumnTextForButtonValue = true;
            Ver.Width = 125;
            // 
            // Accion
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Accion.DefaultCellStyle = dataGridViewCellStyle2;
            Accion.FlatStyle = FlatStyle.Flat;
            Accion.HeaderText = "Activar/Desactivar";
            Accion.MinimumWidth = 6;
            Accion.Name = "Accion";
            Accion.Text = "Activar/Desactivar";
            Accion.UseColumnTextForButtonValue = true;
            Accion.Width = 140;
            // 
            // FacturasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 717);
            Controls.Add(btnBuscar);
            Controls.Add(btnFecha);
            Controls.Add(fechaFin);
            Controls.Add(fechaInicio);
            Controls.Add(btnCrearFactura);
            Controls.Add(tablaFacturas);
            Controls.Add(txtBuscador);
            Controls.Add(panelTitulo);
            Name = "FacturasForm";
            Text = "FacturasForm";
            Load += FacturasForm_Load;
            Resize += FacturasForm_Resize;
            ((System.ComponentModel.ISupportInitialize)tablaFacturas).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFecha;
        private DateTimePicker fechaFin;
        private DateTimePicker fechaInicio;
        private Button btnCrearFactura;
        private DataGridView tablaFacturas;
        private TextBox txtBuscador;
        private Label label1;
        private Panel panelTitulo;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewButtonColumn Ver;
        private DataGridViewButtonColumn Accion;
    }
}