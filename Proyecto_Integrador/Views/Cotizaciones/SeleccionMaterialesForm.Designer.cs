namespace Proyecto_Integrador.Views.Cotizaciones
{
    partial class SeleccionMaterialesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionMaterialesForm));
            tablaMateriales = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnidad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtBuscador = new TextBox();
            Agregar = new DataGridViewCheckBoxColumn();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaMateriales).BeginInit();
            SuspendLayout();
            // 
            // tablaMateriales
            // 
            tablaMateriales.AllowUserToAddRows = false;
            tablaMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaMateriales.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, PrecioUnidad, Estado, Agregar });
            tablaMateriales.Location = new Point(118, 82);
            tablaMateriales.Name = "tablaMateriales";
            tablaMateriales.RowHeadersWidth = 51;
            tablaMateriales.Size = new Size(627, 375);
            tablaMateriales.TabIndex = 30;
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
            // txtBuscador
            // 
            txtBuscador.ForeColor = Color.Black;
            txtBuscador.Location = new Point(118, 49);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(235, 27);
            txtBuscador.TabIndex = 31;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // Agregar
            // 
            Agregar.HeaderText = "Agregar";
            Agregar.MinimumWidth = 6;
            Agregar.Name = "Agregar";
            Agregar.Width = 125;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 64);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(615, 504);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 5, 0, 5);
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 65;
            btnGuardar.Text = " Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // SeleccionMaterialesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(845, 599);
            Controls.Add(btnGuardar);
            Controls.Add(txtBuscador);
            Controls.Add(tablaMateriales);
            Name = "SeleccionMaterialesForm";
            Text = "SeleccionMaterialesForm";
            Load += SeleccionMaterialesForm_Load;
            ((System.ComponentModel.ISupportInitialize)tablaMateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaMateriales;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnidad;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txtBuscador;
        private DataGridViewCheckBoxColumn Agregar;
        private Button btnGuardar;
    }
}