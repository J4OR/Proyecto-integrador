namespace Proyecto_Integrador.Views.Clientes
{
    partial class EditarClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarClienteForm));
            txtIdentificacion = new TextBox();
            label9 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            label7 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(223, 150);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(375, 27);
            txtIdentificacion.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSteelBlue;
            label9.Location = new Point(14, 157);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 40;
            label9.Text = "Identificación:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(331, 333);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(10, 5, 0, 5);
            btnCancelar.Size = new Size(121, 36);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 64);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(468, 333);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 5, 0, 5);
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = " Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(223, 216);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(375, 27);
            txtTelefono.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSteelBlue;
            label7.Location = new Point(14, 223);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 35;
            label7.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(223, 183);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(375, 27);
            txtCorreo.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Location = new Point(14, 190);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 33;
            label4.Text = "Correo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(223, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(375, 27);
            txtNombre.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Location = new Point(14, 124);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 30;
            label3.Text = "Nombre Completo:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 64);
            panel1.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(88, 21);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 1;
            label1.Text = "Editar Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // EditarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(623, 396);
            Controls.Add(txtIdentificacion);
            Controls.Add(label9);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(label7);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "EditarClienteForm";
            Text = "EditarClienteForm";
            Load += EditarClienteForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdentificacion;
        private Label label9;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private Label label7;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}