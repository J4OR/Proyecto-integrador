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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CotizacionesForm));
            btnAgregar = new Button();
            tablaUsuarios = new DataGridView();
            txtBuscador = new TextBox();
            label1 = new Label();
            panelTitulo = new Panel();
            filtradorFecha = new DateTimePicker();
            Id = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Terreno = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Accion = new DataGridViewButtonColumn();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaUsuarios).BeginInit();
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
            // 
            // tablaUsuarios
            // 
            tablaUsuarios.AllowUserToAddRows = false;
            tablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Cliente, Terreno, Material, Total, Estado, Editar, Accion });
            tablaUsuarios.Location = new Point(50, 172);
            tablaUsuarios.Name = "tablaUsuarios";
            tablaUsuarios.RowHeadersWidth = 51;
            tablaUsuarios.Size = new Size(1259, 497);
            tablaUsuarios.TabIndex = 9;
            // 
            // txtBuscador
            // 
            txtBuscador.ForeColor = Color.Black;
            txtBuscador.Location = new Point(50, 118);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(235, 27);
            txtBuscador.TabIndex = 8;
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
            // filtradorFecha
            // 
            filtradorFecha.Location = new Point(402, 118);
            filtradorFecha.Name = "filtradorFecha";
            filtradorFecha.Size = new Size(292, 27);
            filtradorFecha.TabIndex = 12;
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
            Accion.Width = 125;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(725, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1032, 116);
            button1.Name = "button1";
            button1.Size = new Size(42, 30);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            // 
            // CotizacionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 708);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(filtradorFecha);
            Controls.Add(btnAgregar);
            Controls.Add(tablaUsuarios);
            Controls.Add(txtBuscador);
            Controls.Add(label1);
            Controls.Add(panelTitulo);
            Name = "CotizacionesForm";
            Text = "CotizacionesForm";
            ((System.ComponentModel.ISupportInitialize)tablaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView tablaUsuarios;
        private TextBox txtBuscador;
        private Label label1;
        private Panel panelTitulo;
        private DateTimePicker filtradorFecha;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Terreno;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Accion;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}