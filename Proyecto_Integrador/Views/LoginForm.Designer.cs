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
            pbOjo = new PictureBox();
            pbPassword = new PictureBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnIniciarSesion = new Button();
            pbUser = new PictureBox();
            txtUser = new TextBox();
            pbBanner = new PictureBox();
            lblSubtitulo = new Label();
            txtPassword = new TextBox();
            lblTitulo = new Label();
            btnRegistrar = new Button();
            panelLinea = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbOjo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBanner).BeginInit();
            SuspendLayout();
            // 
            // pbOjo
            // 
            pbOjo.BackColor = Color.Transparent;
            pbOjo.Image = (Image)resources.GetObject("pbOjo.Image");
            pbOjo.Location = new Point(961, 326);
            pbOjo.Name = "pbOjo";
            pbOjo.Size = new Size(25, 27);
            pbOjo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOjo.TabIndex = 10;
            pbOjo.TabStop = false;
            pbOjo.MouseClick += pictureBoxOjo_MouseClick;
            // 
            // pbPassword
            // 
            pbPassword.BackColor = Color.Transparent;
            pbPassword.Image = (Image)resources.GetObject("pbPassword.Image");
            pbPassword.Location = new Point(551, 317);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(44, 45);
            pbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPassword.TabIndex = 9;
            pbPassword.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(551, 170);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 23);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(551, 291);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(99, 23);
            lblContraseña.TabIndex = 15;
            lblContraseña.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Blue;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnIniciarSesion.Location = new Point(567, 549);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(155, 44);
            btnIniciarSesion.TabIndex = 11;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // pbUser
            // 
            pbUser.BackColor = Color.Transparent;
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(551, 196);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(44, 45);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 8;
            pbUser.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.AccessibleDescription = "";
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.InactiveCaption;
            txtUser.Location = new Point(620, 196);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(366, 45);
            txtUser.TabIndex = 6;
            txtUser.Text = "Ingrese su usuario";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // pbBanner
            // 
            pbBanner.Image = (Image)resources.GetObject("pbBanner.Image");
            pbBanner.Location = new Point(0, 0);
            pbBanner.Name = "pbBanner";
            pbBanner.Size = new Size(466, 687);
            pbBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBanner.TabIndex = 5;
            pbBanner.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(636, 86);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(280, 25);
            lblSubtitulo.TabIndex = 13;
            lblSubtitulo.Text = "Accede a tu cuenta para continuar";
            // 
            // txtPassword
            // 
            txtPassword.AccessibleDescription = "";
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(620, 317);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(366, 45);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "Ingrese su contraseña";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(648, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(254, 50);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Iniciar Sesión";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Blue;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(778, 549);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(155, 44);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panelLinea
            // 
            panelLinea.BackColor = Color.Gray;
            panelLinea.Location = new Point(526, 473);
            panelLinea.Name = "panelLinea";
            panelLinea.Size = new Size(460, 2);
            panelLinea.TabIndex = 16;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1013, 683);
            Controls.Add(pbOjo);
            Controls.Add(txtPassword);
            Controls.Add(pbBanner);
            Controls.Add(lblTitulo);
            Controls.Add(panelLinea);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnIniciarSesion);
            Controls.Add(btnRegistrar);
            Controls.Add(lblUsuario);
            Controls.Add(txtUser);
            Controls.Add(lblContraseña);
            Controls.Add(pbUser);
            Controls.Add(pbPassword);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            Resize += LoginForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pbOjo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbOjo;
        private PictureBox pbPassword;
        private Label lblUsuario;
        private Label lblContraseña;
        private Button btnIniciarSesion;
        private PictureBox pbUser;
        private TextBox txtUser;
        private PictureBox pbBanner;
        private Label lblSubtitulo;
        private TextBox txtPassword;
        private Label lblTitulo;
        private Button btnRegistrar;
        private Panel panelLinea;
    }
}