namespace Proyecto_Integrador.Views.Factura
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
            btnBuscar = new Button();
            FechaFin = new DateTimePicker();
            FechaInicio = new DateTimePicker();
            btnAgregar = new Button();
            tablaCotizaciones = new DataGridView();
            txtBuscar = new TextBox();
            label1 = new Label();
            panelTitulo = new Panel();
            Id = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Accion = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)tablaCotizaciones).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(875, 108);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(42, 30);
            btnBuscar.TabIndex = 22;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FechaFin
            // 
            FechaFin.Location = new Point(568, 110);
            FechaFin.Name = "FechaFin";
            FechaFin.Size = new Size(301, 27);
            FechaFin.TabIndex = 21;
            // 
            // FechaInicio
            // 
            FechaInicio.Location = new Point(245, 110);
            FechaInicio.Name = "FechaInicio";
            FechaInicio.Size = new Size(292, 27);
            FechaInicio.TabIndex = 20;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 0, 64);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1012, 110);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 33);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Nueva Cotizacion";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // tablaCotizaciones
            // 
            tablaCotizaciones.AllowUserToAddRows = false;
            tablaCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaCotizaciones.Columns.AddRange(new DataGridViewColumn[] { Id, Cliente, Fecha, Estado, Total, Editar, Accion });
            tablaCotizaciones.Location = new Point(22, 185);
            tablaCotizaciones.Name = "tablaCotizaciones";
            tablaCotizaciones.RowHeadersWidth = 51;
            tablaCotizaciones.Size = new Size(1259, 497);
            tablaCotizaciones.TabIndex = 17;
            // 
            // txtBuscar
            // 
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(31, 152);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(235, 27);
            txtBuscar.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(270, 4);
            label1.Name = "label1";
            label1.Size = new Size(308, 28);
            label1.TabIndex = 15;
            label1.Text = "Administración de cotizaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Location = new Point(-157, -8);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1418, 63);
            panelTitulo.TabIndex = 18;
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
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // Editar
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 0, 64);
            Editar.DefaultCellStyle = dataGridViewCellStyle1;
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 125;
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
            ClientSize = new Size(1312, 717);
            Controls.Add(btnBuscar);
            Controls.Add(FechaFin);
            Controls.Add(FechaInicio);
            Controls.Add(btnAgregar);
            Controls.Add(tablaCotizaciones);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(panelTitulo);
            Name = "FacturasForm";
            Text = "FacturasForm";
            ((System.ComponentModel.ISupportInitialize)tablaCotizaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private DateTimePicker FechaFin;
        private DateTimePicker FechaInicio;
        private Button btnAgregar;
        private DataGridView tablaCotizaciones;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Accion;
        private TextBox txtBuscar;
        private Label label1;
        private Panel panelTitulo;
    }
}