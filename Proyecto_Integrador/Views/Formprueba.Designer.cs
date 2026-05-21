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
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(374, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(374, 164);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(236, 27);
            txtIdentificacion.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(374, 215);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(236, 27);
            txtTelefono.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(374, 287);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(236, 27);
            txtCorreo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(420, 357);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(162, 38);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form_prueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 547);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtNombre);
            Name = "Form_prueba";
            Text = "Form_prueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnAgregar;
    }
}