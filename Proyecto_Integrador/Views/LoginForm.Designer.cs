namespace Proyecto_Integrador.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBoxPassword = new PictureBox();
            pictureBoxUser = new PictureBox();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            pictureBoxBanner = new PictureBox();
            pictureBoxOjo = new PictureBox();
            btnIniciarSesion = new Button();
            lblTitullo = new Label();
            label1 = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            panelLinea = new Panel();
            btnRegistrar = new Button();
            linkLblOlvidarContraseña = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOjo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.BackColor = Color.Transparent;
            pictureBoxPassword.Image = (Image)resources.GetObject("pictureBoxPassword.Image");
            pictureBoxPassword.Location = new Point(492, 341);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(44, 45);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPassword.TabIndex = 9;
            pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.BackColor = Color.Transparent;
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(492, 220);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(44, 45);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUser.TabIndex = 8;
            pictureBoxUser.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.AccessibleDescription = "";
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(564, 341);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(366, 45);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "Ingrese su contraseña";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtUser
            // 
            txtUser.AccessibleDescription = "";
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.InactiveCaption;
            txtUser.Location = new Point(564, 220);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(366, 45);
            txtUser.TabIndex = 6;
            txtUser.Text = "Ingrese su usuario";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // pictureBoxBanner
            // 
            pictureBoxBanner.Image = (Image)resources.GetObject("pictureBoxBanner.Image");
            pictureBoxBanner.Location = new Point(0, 0);
            pictureBoxBanner.Name = "pictureBoxBanner";
            pictureBoxBanner.Size = new Size(429, 625);
            pictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBanner.TabIndex = 5;
            pictureBoxBanner.TabStop = false;
            // 
            // pictureBoxOjo
            // 
            pictureBoxOjo.BackColor = Color.Transparent;
            pictureBoxOjo.Image = (Image)resources.GetObject("pictureBoxOjo.Image");
            pictureBoxOjo.Location = new Point(891, 350);
            pictureBoxOjo.Name = "pictureBoxOjo";
            pictureBoxOjo.Size = new Size(25, 27);
            pictureBoxOjo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOjo.TabIndex = 10;
            pictureBoxOjo.TabStop = false;
            pictureBoxOjo.MouseClick += pictureBoxOjo_MouseClick;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Blue;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnIniciarSesion.Location = new Point(564, 481);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(155, 44);
            btnIniciarSesion.TabIndex = 11;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblTitullo
            // 
            lblTitullo.AutoSize = true;
            lblTitullo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitullo.Location = new Point(605, 46);
            lblTitullo.Name = "lblTitullo";
            lblTitullo.Size = new Size(254, 50);
            lblTitullo.TabIndex = 12;
            lblTitullo.Text = "Iniciar Sesión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(593, 106);
            label1.Name = "label1";
            label1.Size = new Size(280, 25);
            label1.TabIndex = 13;
            label1.Text = "Accede a tu cuenta para continuar";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(492, 184);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 23);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(492, 304);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(99, 23);
            lblContraseña.TabIndex = 15;
            lblContraseña.Text = "Contraseña";
            // 
            // panelLinea
            // 
            panelLinea.BackColor = Color.Gray;
            panelLinea.Location = new Point(495, 461);
            panelLinea.Name = "panelLinea";
            panelLinea.Size = new Size(435, 2);
            panelLinea.TabIndex = 16;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Blue;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(775, 481);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(155, 44);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // linkLblOlvidarContraseña
            // 
            linkLblOlvidarContraseña.AutoSize = true;
            linkLblOlvidarContraseña.Location = new Point(752, 405);
            linkLblOlvidarContraseña.Name = "linkLblOlvidarContraseña";
            linkLblOlvidarContraseña.Size = new Size(178, 20);
            linkLblOlvidarContraseña.TabIndex = 18;
            linkLblOlvidarContraseña.TabStop = true;
            linkLblOlvidarContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(971, 624);
            Controls.Add(linkLblOlvidarContraseña);
            Controls.Add(btnRegistrar);
            Controls.Add(panelLinea);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(lblTitullo);
            Controls.Add(btnIniciarSesion);
            Controls.Add(pictureBoxOjo);
            Controls.Add(pictureBoxPassword);
            Controls.Add(pictureBoxUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBoxBanner);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOjo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPassword;
        private PictureBox pictureBoxUser;
        private TextBox txtPassword;
        private TextBox txtUser;
        private PictureBox pictureBoxBanner;
        private PictureBox pictureBoxOjo;
        private Button btnIniciarSesion;
        private Label lblTitullo;
        private Label label1;
        private Label lblUsuario;
        private Label lblContraseña;
        private Panel panelLinea;
        private Button btnRegistrar;
        private LinkLabel linkLblOlvidarContraseña;
    }
}