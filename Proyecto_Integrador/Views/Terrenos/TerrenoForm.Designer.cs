namespace Proyecto_Integrador.Views.Terrenos
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
            btnCalculadora = new Button();
            tablaTerrenos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Operacion = new DataGridViewTextBoxColumn();
            Volumen = new DataGridViewTextBoxColumn();
            Ver = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            label1 = new Label();
            panelTitulo = new Panel();
            txtBuscador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tablaTerrenos).BeginInit();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculadora
            // 
            btnCalculadora.BackColor = Color.FromArgb(0, 0, 64);
            btnCalculadora.FlatStyle = FlatStyle.Flat;
            btnCalculadora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculadora.ForeColor = Color.White;
            btnCalculadora.Location = new Point(927, 86);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(119, 33);
            btnCalculadora.TabIndex = 23;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalculadora.UseVisualStyleBackColor = false;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // tablaTerrenos
            // 
            tablaTerrenos.AllowUserToAddRows = false;
            tablaTerrenos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaTerrenos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Cliente, Operacion, Volumen, Ver, Eliminar });
            tablaTerrenos.Location = new Point(115, 139);
            tablaTerrenos.Name = "tablaTerrenos";
            tablaTerrenos.RowHeadersWidth = 51;
            tablaTerrenos.Size = new Size(931, 497);
            tablaTerrenos.TabIndex = 24;
            tablaTerrenos.CellClick += tablaTerrenos_CellClick;
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
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Operacion
            // 
            Operacion.HeaderText = "Operacion";
            Operacion.MinimumWidth = 6;
            Operacion.Name = "Operacion";
            Operacion.Width = 125;
            // 
            // Volumen
            // 
            Volumen.HeaderText = "Volumen";
            Volumen.MinimumWidth = 6;
            Volumen.Name = "Volumen";
            Volumen.Width = 125;
            // 
            // Ver
            // 
            Ver.HeaderText = "Ver";
            Ver.MinimumWidth = 6;
            Ver.Name = "Ver";
            Ver.Text = "Ver";
            Ver.UseColumnTextForButtonValue = true;
            Ver.Width = 125;
            // 
            // Eliminar
            // 
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(447, 19);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 25;
            label1.Text = "Administración de terrenos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1141, 63);
            panelTitulo.TabIndex = 27;
            // 
            // txtBuscador
            // 
            txtBuscador.ForeColor = Color.Black;
            txtBuscador.Location = new Point(68, 86);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(235, 27);
            txtBuscador.TabIndex = 26;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // TerrenoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 704);
            Controls.Add(txtBuscador);
            Controls.Add(panelTitulo);
            Controls.Add(tablaTerrenos);
            Controls.Add(btnCalculadora);
            Name = "TerrenoForm";
            Text = "TerrenoForm";
            Load += TerrenoForm_Load;
            Resize += TerrenoForm_Resize;
            ((System.ComponentModel.ISupportInitialize)tablaTerrenos).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculadora;
        private DataGridView tablaTerrenos;
        private Label label1;
        private Panel panelTitulo;
        private TextBox txtBuscador;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Operacion;
        private DataGridViewTextBoxColumn Volumen;
        private DataGridViewButtonColumn Ver;
        private DataGridViewButtonColumn Eliminar;
    }
}