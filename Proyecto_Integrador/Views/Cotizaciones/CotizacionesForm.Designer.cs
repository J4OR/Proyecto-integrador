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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CotizacionesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAgregar = new Button();
            tablaCotizaciones = new DataGridView();
            txtBuscar = new TextBox();
            label1 = new Label();
            panelTitulo = new Panel();
            FechaInicio = new DateTimePicker();
            FechaFin = new DateTimePicker();
            btnBuscar = new Button();
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Terreno = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Accion = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)tablaCotizaciones).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 0, 64);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1169, 118);
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
            tablaCotizaciones.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, Cliente, Terreno, Material, Total, Estado, Editar, Accion });
            tablaCotizaciones.Location = new Point(50, 172);
            tablaCotizaciones.Name = "tablaCotizaciones";
            tablaCotizaciones.RowHeadersWidth = 51;
            tablaCotizaciones.Size = new Size(1259, 497);
            tablaCotizaciones.TabIndex = 9;
            tablaCotizaciones.CellClick += tablaCotizaciones_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(50, 118);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(235, 27);
            txtBuscar.TabIndex = 8;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(427, 12);
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
            panelTitulo.Size = new Size(1418, 63);
            panelTitulo.TabIndex = 10;
            // 
            // FechaInicio
            // 
            FechaInicio.Format = DateTimePickerFormat.Short;
            FechaInicio.Location = new Point(474, 119);
            FechaInicio.Name = "FechaInicio";
            FechaInicio.Size = new Size(125, 27);
            FechaInicio.TabIndex = 12;
            // 
            // FechaFin
            // 
            FechaFin.Format = DateTimePickerFormat.Short;
            FechaFin.Location = new Point(632, 118);
            FechaFin.Name = "FechaFin";
            FechaFin.Size = new Size(141, 27);
            FechaFin.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(792, 115);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(42, 30);
            btnBuscar.TabIndex = 14;
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
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Terreno
            // 
            Terreno.HeaderText = "Terreno";
            Terreno.MinimumWidth = 6;
            Terreno.Name = "Terreno";
            Terreno.Width = 125;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.Width = 125;
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
            // CotizacionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 708);
            Controls.Add(btnBuscar);
            Controls.Add(FechaFin);
            Controls.Add(FechaInicio);
            Controls.Add(btnAgregar);
            Controls.Add(tablaCotizaciones);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(panelTitulo);
            Name = "CotizacionesForm";
            Text = "CotizacionesForm";
            ((System.ComponentModel.ISupportInitialize)tablaCotizaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView tablaCotizaciones;
        private TextBox txtBuscar;
        private Label label1;
        private Panel panelTitulo;
        private DateTimePicker FechaInicio;
        private DateTimePicker FechaFin;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Terreno;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Accion;
    }
}