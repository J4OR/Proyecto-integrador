namespace Proyecto_Integrador.Views.Usuarios
{
    partial class AgregarUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuarioForm));
            txtIdentificacion = new TextBox();
            label9 = new Label();
            button1 = new Button();
            btnGuardar = new Button();
            txtConfirmar = new TextBox();
            label8 = new Label();
            cbRol = new ComboBox();
            txtContraseña = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label7 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtUser = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            checkBoxMostrar = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(221, 150);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(375, 27);
            txtIdentificacion.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 157);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 42;
            label9.Text = "Identificación:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(329, 422);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 5, 0, 5);
            button1.Size = new Size(121, 36);
            button1.TabIndex = 41;
            button1.Text = "Cancelar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 64);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(466, 422);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 5, 0, 5);
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = " Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(221, 316);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(375, 27);
            txtConfirmar.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 323);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 38;
            label8.Text = "ConfirmarContraseña:";
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Usuario", "Administrador" });
            cbRol.Location = new Point(221, 183);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(375, 28);
            cbRol.TabIndex = 37;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(221, 283);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(375, 27);
            txtContraseña.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 290);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 35;
            label6.Text = "Contraseña:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(221, 250);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(375, 27);
            txtTelefono.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 257);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 33;
            label7.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(221, 217);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(375, 27);
            txtCorreo.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 31;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 183);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 30;
            label5.Text = "Rol:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(221, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(375, 27);
            txtNombre.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 28;
            label3.Text = "Nombre Completo:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(221, 84);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(375, 27);
            txtUser.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 26;
            label2.Text = "Nombre de Usuario:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 64);
            panel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(88, 21);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 1;
            label1.Text = "Agregar Usuario";
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
            // checkBoxMostrar
            // 
            checkBoxMostrar.AutoSize = true;
            checkBoxMostrar.Location = new Point(221, 349);
            checkBoxMostrar.Name = "checkBoxMostrar";
            checkBoxMostrar.Size = new Size(166, 24);
            checkBoxMostrar.TabIndex = 45;
            checkBoxMostrar.Text = "Mostrar Contraseñas";
            checkBoxMostrar.UseVisualStyleBackColor = true;
            checkBoxMostrar.CheckedChanged += checkBoxMostrar_CheckedChanged;
            // 
            // AgregarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 483);
            Controls.Add(checkBoxMostrar);
            Controls.Add(txtIdentificacion);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(txtConfirmar);
            Controls.Add(label8);
            Controls.Add(cbRol);
            Controls.Add(txtContraseña);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label7);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AgregarUsuarioForm";
            Text = "AgregarUsuarioForm";
            Load += AgregarUsuarioForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdentificacion;
        private Label label9;
        private Button button1;
        private Button btnGuardar;
        private TextBox txtConfirmar;
        private Label label8;
        private ComboBox cbRol;
        private TextBox txtContraseña;
        private Label label6;
        private TextBox txtTelefono;
        private Label label7;
        private TextBox txtCorreo;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtUser;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox checkBoxMostrar;
    }
}