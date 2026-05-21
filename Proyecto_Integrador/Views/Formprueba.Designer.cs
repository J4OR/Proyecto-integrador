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
            txtNombre = new TextBox();
            txtIdentificacion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnAgregar = new Button();
            tablaClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(178, 167);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(236, 27);
            txtIdentificacion.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(178, 218);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(236, 27);
            txtTelefono.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(178, 267);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(236, 27);
            txtCorreo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(226, 360);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(162, 38);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tablaClientes
            // 
            tablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Identificacion, Telefono, Correo });
            tablaClientes.Location = new Point(503, 107);
            tablaClientes.Name = "tablaClientes";
            tablaClientes.RowHeadersWidth = 51;
            tablaClientes.Size = new Size(654, 291);
            tablaClientes.TabIndex = 5;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
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
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 170);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 6;
            label1.Text = "Identificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 107);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 218);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 270);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Correo";
            // 
            // Form_prueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 547);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tablaClientes);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtNombre);
            Name = "Form_prueba";
            Text = "Form_prueba";
            ((System.ComponentModel.ISupportInitialize)tablaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnAgregar;
        private DataGridView tablaClientes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}