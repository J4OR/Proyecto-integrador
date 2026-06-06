namespace Proyecto_Integrador.Views.Inicio
{
    partial class UsuariosForm
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
            label1 = new Label();
            txtBuscador = new TextBox();
            tablaUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Accion = new DataGridViewButtonColumn();
            panelTitulo = new Panel();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(378, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 2;
            label1.Text = "Administración de usuarios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscador
            // 
            txtBuscador.ForeColor = Color.Black;
            txtBuscador.Location = new Point(34, 85);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(235, 27);
            txtBuscador.TabIndex = 3;
            txtBuscador.TextChanged += txtBuscador_TextChanged_1;
            // 
            // tablaUsuarios
            // 
            tablaUsuarios.AllowUserToAddRows = false;
            tablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Identificacion, Rol, Estado, Editar, Accion });
            tablaUsuarios.Location = new Point(34, 156);
            tablaUsuarios.Name = "tablaUsuarios";
            tablaUsuarios.RowHeadersWidth = 51;
            tablaUsuarios.Size = new Size(927, 497);
            tablaUsuarios.TabIndex = 4;
            tablaUsuarios.CellClick += tablaUsuarios_CellClick;
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
            // Identificacion
            // 
            Identificacion.HeaderText = "Identificacion";
            Identificacion.MinimumWidth = 6;
            Identificacion.Name = "Identificacion";
            Identificacion.Width = 125;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.Width = 125;
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
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Location = new Point(-27, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1042, 63);
            panelTitulo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 0, 64);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(821, 85);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 33);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(btnAgregar);
            Controls.Add(tablaUsuarios);
            Controls.Add(txtBuscador);
            Controls.Add(label1);
            Controls.Add(panelTitulo);
            Name = "UsuariosForm";
            Text = "UsuariosForm";
            Load += UsuariosForm_Load;
            Resize += UsuariosForm_Resize;
            ((System.ComponentModel.ISupportInitialize)tablaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtBuscador;
        private DataGridView tablaUsuarios;
        private Panel panelTitulo;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Accion;
    }
}