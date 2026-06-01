namespace Proyecto_Integrador.Views
{
    partial class Form_prueba
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tablaClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewButtonColumn();
            btnAgregar = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtIdentificacion = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBuscador = new TextBox();
            tablaClientes2 = new DataGridView();
            Id2 = new DataGridViewTextBoxColumn();
            Nombre2 = new DataGridViewTextBoxColumn();
            Identificacion2 = new DataGridViewTextBoxColumn();
            Telefono2 = new DataGridViewTextBoxColumn();
            Correo2 = new DataGridViewTextBoxColumn();
            Accion2 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaClientes2).BeginInit();
            SuspendLayout();
            // 
            // tablaClientes
            // 
            tablaClientes.AllowUserToDeleteRows = false;
            tablaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaClientes.BackgroundColor = SystemColors.ButtonHighlight;
            tablaClientes.BorderStyle = BorderStyle.None;
            tablaClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Identificacion, Telefono, Correo, Accion });
            tablaClientes.EnableHeadersVisualStyles = false;
            tablaClientes.GridColor = SystemColors.HighlightText;
            tablaClientes.Location = new Point(542, 128);
            tablaClientes.MultiSelect = false;
            tablaClientes.Name = "tablaClientes";
            tablaClientes.ReadOnly = true;
            tablaClientes.RowHeadersVisible = false;
            tablaClientes.RowHeadersWidth = 51;
            tablaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaClientes.Size = new Size(797, 262);
            tablaClientes.TabIndex = 15;
            tablaClientes.CellContentClick += tablaClientes_CellContentClick;
            // 
            // Id
            // 
            //dataGridViewCellStyle2.BackColor = Color.White;
            //Id.DefaultCellStyle = dataGridViewCellStyle2;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Identificacion
            // 
            Identificacion.HeaderText = "Identificacion";
            Identificacion.MinimumWidth = 6;
            Identificacion.Name = "Identificacion";
            Identificacion.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Accion
            // 
            //dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewCellStyle3.BackColor = Color.DarkBlue;
            //dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            //Accion.DefaultCellStyle = dataGridViewCellStyle3;
            Accion.FlatStyle = FlatStyle.Flat;
            Accion.HeaderText = "Accion";
            Accion.MinimumWidth = 6;
            Accion.Name = "Accion";
            Accion.ReadOnly = true;
            Accion.Text = "Editar";
            Accion.UseColumnTextForButtonValue = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(254, 381);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(162, 38);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(206, 288);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(236, 27);
            txtCorreo.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(206, 239);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(236, 27);
            txtTelefono.TabIndex = 12;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(206, 188);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(236, 27);
            txtIdentificacion.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(206, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 27);
            txtNombre.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 291);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 19;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 239);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 18;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 128);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 17;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 191);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 16;
            label1.Text = "Identificacion";
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(476, 66);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(225, 27);
            txtBuscador.TabIndex = 20;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // tablaClientes2
            // 
            tablaClientes2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaClientes2.Columns.AddRange(new DataGridViewColumn[] { Id2, Nombre2, Identificacion2, Telefono2, Correo2, Accion2 });
            tablaClientes2.Location = new Point(542, 415);
            tablaClientes2.Name = "tablaClientes2";
            tablaClientes2.RowHeadersWidth = 51;
            tablaClientes2.Size = new Size(784, 188);
            tablaClientes2.TabIndex = 21;
            // 
            // Id2
            // 
            Id2.HeaderText = "Id2";
            Id2.MinimumWidth = 6;
            Id2.Name = "Id2";
            Id2.Width = 125;
            // 
            // Nombre2
            // 
            Nombre2.HeaderText = "Nombre2";
            Nombre2.MinimumWidth = 6;
            Nombre2.Name = "Nombre2";
            Nombre2.Width = 125;
            // 
            // Identificacion2
            // 
            Identificacion2.HeaderText = "Identificacion2";
            Identificacion2.MinimumWidth = 6;
            Identificacion2.Name = "Identificacion2";
            Identificacion2.Width = 125;
            // 
            // Telefono2
            // 
            Telefono2.HeaderText = "Telefono2";
            Telefono2.MinimumWidth = 6;
            Telefono2.Name = "Telefono2";
            Telefono2.Width = 125;
            // 
            // Correo2
            // 
            Correo2.HeaderText = "Correo2";
            Correo2.MinimumWidth = 6;
            Correo2.Name = "Correo2";
            Correo2.Width = 125;
            // 
            // Accion2
            // 
            Accion2.HeaderText = "Accion2";
            Accion2.MinimumWidth = 6;
            Accion2.Name = "Accion2";
            Accion2.Width = 125;
            // 
            // Form_prueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 547);
            Controls.Add(tablaClientes2);
            Controls.Add(txtBuscador);
            Controls.Add(tablaClientes);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_prueba";
            Text = "Form_prueba";
            Load += Form_prueba_Load;
            ((System.ComponentModel.ISupportInitialize)tablaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaClientes2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaClientes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewButtonColumn Accion;
        private Button btnAgregar;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtIdentificacion;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBuscador;
        private DataGridView tablaClientes2;
        private DataGridViewTextBoxColumn Id2;
        private DataGridViewTextBoxColumn Nombre2;
        private DataGridViewTextBoxColumn Identificacion2;
        private DataGridViewTextBoxColumn Telefono2;
        private DataGridViewTextBoxColumn Correo2;
        private DataGridViewButtonColumn Accion2;
    }
}