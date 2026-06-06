namespace Proyecto_Integrador.Views.Usuarios
{
    partial class EditarUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuarioForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            lblRol = new Label();
            txtContraseña = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label7 = new Label();
            cbRol = new ComboBox();
            txtConfirmar = new TextBox();
            label8 = new Label();
            btnGuardar = new Button();
            button1 = new Button();
            txtIdentificacion = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            btnCambiarContraseña = new Button();
            checkBoxMostrar = new CheckBox();
            panelCambiarContraseña = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelCambiarContraseña.SuspendLayout();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(88, 21);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 1;
            label1.Text = "Editar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre de Usuario:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(221, 84);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(375, 27);
            txtUser.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(221, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(375, 27);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre Completo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(221, 217);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(375, 27);
            txtCorreo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 8;
            label4.Text = "Correo:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(12, 183);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 20);
            lblRol.TabIndex = 6;
            lblRol.Text = "Rol:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(221, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(375, 27);
            txtContraseña.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 8);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 12;
            label6.Text = "Contraseña:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(221, 250);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(375, 27);
            txtTelefono.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 257);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 10;
            label7.Text = "Telefono:";
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Usuario", "Administrador" });
            cbRol.Location = new Point(221, 183);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(375, 28);
            cbRol.TabIndex = 14;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(221, 39);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(375, 27);
            txtConfirmar.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 42);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 15;
            label8.Text = "ConfirmarContraseña:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 64);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(466, 444);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 5, 0, 5);
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = " Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(329, 444);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 5, 0, 5);
            button1.Size = new Size(121, 36);
            button1.TabIndex = 22;
            button1.Text = "Cancelar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(221, 150);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(375, 27);
            txtIdentificacion.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 157);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 23;
            label9.Text = "Identificación:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCambiarContraseña);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 64);
            panel1.TabIndex = 25;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.BackColor = Color.FromArgb(0, 0, 64);
            btnCambiarContraseña.FlatAppearance.BorderSize = 0;
            btnCambiarContraseña.FlatStyle = FlatStyle.Flat;
            btnCambiarContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarContraseña.ForeColor = SystemColors.ButtonHighlight;
            btnCambiarContraseña.Image = (Image)resources.GetObject("btnCambiarContraseña.Image");
            btnCambiarContraseña.Location = new Point(402, 12);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Padding = new Padding(10, 5, 0, 5);
            btnCambiarContraseña.Size = new Size(194, 45);
            btnCambiarContraseña.TabIndex = 22;
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.TextAlign = ContentAlignment.MiddleRight;
            btnCambiarContraseña.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCambiarContraseña.UseVisualStyleBackColor = false;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // checkBoxMostrar
            // 
            checkBoxMostrar.AutoSize = true;
            checkBoxMostrar.Location = new Point(221, 72);
            checkBoxMostrar.Name = "checkBoxMostrar";
            checkBoxMostrar.Size = new Size(166, 24);
            checkBoxMostrar.TabIndex = 26;
            checkBoxMostrar.Text = "Mostrar Contraseñas";
            checkBoxMostrar.UseVisualStyleBackColor = true;
            checkBoxMostrar.CheckedChanged += checkBoxMostrar_CheckedChanged;
            // 
            // panelCambiarContraseña
            // 
            panelCambiarContraseña.Controls.Add(checkBoxMostrar);
            panelCambiarContraseña.Controls.Add(txtContraseña);
            panelCambiarContraseña.Controls.Add(txtConfirmar);
            panelCambiarContraseña.Controls.Add(label8);
            panelCambiarContraseña.Controls.Add(label6);
            panelCambiarContraseña.Location = new Point(0, 282);
            panelCambiarContraseña.Name = "panelCambiarContraseña";
            panelCambiarContraseña.Size = new Size(640, 116);
            panelCambiarContraseña.TabIndex = 27;
            panelCambiarContraseña.Visible = false;
            // 
            // EditarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 503);
            Controls.Add(txtIdentificacion);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(cbRol);
            Controls.Add(txtTelefono);
            Controls.Add(label7);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(lblRol);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panelCambiarContraseña);
            Name = "EditarUsuarioForm";
            Text = "EditarUsuarioForm";
            Load += EditarUsuarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCambiarContraseña.ResumeLayout(false);
            panelCambiarContraseña.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtCorreo;
        private Label label4;
        private Label lblRol;
        private TextBox txtContraseña;
        private Label label6;
        private TextBox txtTelefono;
        private Label label7;
        private ComboBox cbRol;
        private TextBox txtConfirmar;
        private Label label8;
        private Button btnGuardar;
        private Button button1;
        private TextBox txtIdentificacion;
        private Label label9;
        private Panel panel1;
        private CheckBox checkBoxMostrar;
        private Button btnCambiarContraseña;
        private Panel panelCambiarContraseña;
    }
}