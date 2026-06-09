namespace Proyecto_Integrador.Views.Materiales
{
    partial class MaterialesForm
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
            txtBuscador = new TextBox();
            panelTitulo = new Panel();
            label1 = new Label();
            tablaMateriales = new DataGridView();
            btnAgregar = new Button();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnidad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Accion = new DataGridViewButtonColumn();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaMateriales).BeginInit();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.ForeColor = Color.Black;
            txtBuscador.Location = new Point(89, 114);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(235, 27);
            txtBuscador.TabIndex = 30;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1141, 63);
            panelTitulo.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(343, 19);
            label1.Name = "label1";
            label1.Size = new Size(290, 28);
            label1.TabIndex = 25;
            label1.Text = "Administración de materiales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tablaMateriales
            // 
            tablaMateriales.AllowUserToAddRows = false;
            tablaMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaMateriales.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, PrecioUnidad, Estado, Editar, Accion });
            tablaMateriales.Location = new Point(89, 168);
            tablaMateriales.Name = "tablaMateriales";
            tablaMateriales.RowHeadersWidth = 51;
            tablaMateriales.Size = new Size(802, 497);
            tablaMateriales.TabIndex = 29;
            tablaMateriales.CellClick += tablaMateriales_CellClick;
            tablaMateriales.CellFormatting += tablaMateriales_CellFormatting;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 0, 64);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(772, 111);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 33);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // PrecioUnidad
            // 
            PrecioUnidad.HeaderText = "Precio";
            PrecioUnidad.MinimumWidth = 6;
            PrecioUnidad.Name = "PrecioUnidad";
            PrecioUnidad.Width = 125;
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
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Width = 125;
            // 
            // Accion
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Accion.DefaultCellStyle = dataGridViewCellStyle1;
            Accion.FlatStyle = FlatStyle.Flat;
            Accion.HeaderText = "Activar/Desactivar";
            Accion.MinimumWidth = 6;
            Accion.Name = "Accion";
            Accion.Text = "Activar/Desactivar";
            Accion.UseColumnTextForButtonValue = true;
            Accion.Width = 125;
            // 
            // MaterialesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 706);
            Controls.Add(txtBuscador);
            Controls.Add(panelTitulo);
            Controls.Add(tablaMateriales);
            Controls.Add(btnAgregar);
            Name = "MaterialesForm";
            Text = "MaterialesForm";
            Load += MaterialesForm_Load;
            Resize += MaterialesForm_Resize;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaMateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscador;
        private Panel panelTitulo;
        private Label label1;
        private DataGridView tablaMateriales;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnidad;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Accion;
    }
}