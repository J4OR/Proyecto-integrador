namespace Proyecto_Integrador.Views
{
    partial class EditarForm
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
            btnEditar = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtIdentificacion = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(309, 324);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(162, 38);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(261, 231);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(236, 27);
            txtCorreo.TabIndex = 23;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(261, 182);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(236, 27);
            txtTelefono.TabIndex = 22;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(261, 131);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(236, 27);
            txtIdentificacion.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(261, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 27);
            txtNombre.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 234);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 28;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 182);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 27;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 71);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 26;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 134);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 25;
            label1.Text = "Identificacion";
            // 
            // EditarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 450);
            Controls.Add(btnEditar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditarForm";
            Text = "EditarForm";
            Load += EditarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtIdentificacion;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}