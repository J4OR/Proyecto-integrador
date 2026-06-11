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
            panelLinea = new Panel();
            lblError = new Label();
            pbError = new PictureBox();
            pbError2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbOjo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbError2).BeginInit();
            SuspendLayout();
            // 
            // pbOjo
            // 
            pbOjo.BackColor = Color.Transparent;
            pbOjo.Image = (Image)resources.GetObject("pbOjo.Image");
            pbOjo.Location = new Point(989, 380);
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
            pbPassword.Location = new Point(579, 371);
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
            lblUsuario.Location = new Point(579, 187);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 23);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(579, 330);
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
            btnIniciarSesion.Location = new Point(579, 597);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(470, 44);
            btnIniciarSesion.TabIndex = 11;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // pbUser
            // 
            pbUser.BackColor = Color.Transparent;
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(579, 230);
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
            txtUser.Location = new Point(648, 230);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(366, 45);
            txtUser.TabIndex = 6;
            txtUser.Text = "Ingrese su usuario";
            txtUser.Enter += TextBoxs_Enter;
            txtUser.Leave += TextBoxs_Leave;
            // 
            // pbBanner
            // 
            pbBanner.Dock = DockStyle.Left;
            pbBanner.Image = (Image)resources.GetObject("pbBanner.Image");
            pbBanner.Location = new Point(0, 0);
            pbBanner.Name = "pbBanner";
            pbBanner.Size = new Size(445, 739);
            pbBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBanner.TabIndex = 5;
            pbBanner.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(679, 96);
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
            txtPassword.Location = new Point(648, 371);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(366, 45);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "Ingrese su contraseña";
            txtPassword.Enter += TextBoxs_Enter;
            txtPassword.Leave += TextBoxs_Leave;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(692, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(254, 50);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Iniciar Sesión";
            // 
            // panelLinea
            // 
            panelLinea.BackColor = Color.Gray;
            panelLinea.BorderStyle = BorderStyle.Fixed3D;
            panelLinea.Location = new Point(589, 513);
            panelLinea.Name = "panelLinea";
            panelLinea.Size = new Size(460, 2);
            panelLinea.TabIndex = 16;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.FromArgb(192, 0, 0);
            lblError.Location = new Point(805, 549);
            lblError.Name = "lblError";
            lblError.Size = new Size(20, 23);
            lblError.TabIndex = 19;
            lblError.Text = "T";
            // 
            // pbError
            // 
            pbError.BackColor = Color.Transparent;
            pbError.Image = (Image)resources.GetObject("pbError.Image");
            pbError.Location = new Point(769, 549);
            pbError.Name = "pbError";
            pbError.Size = new Size(29, 23);
            pbError.SizeMode = PictureBoxSizeMode.StretchImage;
            pbError.TabIndex = 20;
            pbError.TabStop = false;
            // 
            // pbError2
            // 
            pbError2.BackColor = Color.Transparent;
            pbError2.Image = (Image)resources.GetObject("pbError2.Image");
            pbError2.Location = new Point(831, 549);
            pbError2.Name = "pbError2";
            pbError2.Size = new Size(29, 23);
            pbError2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbError2.TabIndex = 21;
            pbError2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 21, 52);
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(165, 263);
            label1.Name = "label1";
            label1.Size = new Size(126, 50);
            label1.TabIndex = 22;
            label1.Text = "SGMT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 21, 52);
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(69, 313);
            label2.Name = "label2";
            label2.Size = new Size(344, 62);
            label2.TabIndex = 23;
            label2.Text = "Sistema de Gestión Movimiento\r\nde tierras\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 21, 52);
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(93, 393);
            label3.Name = "label3";
            label3.Size = new Size(293, 23);
            label3.TabIndex = 24;
            label3.Text = "Bienvenido al sistema administrativo.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 21, 52);
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(129, 430);
            label4.Name = "label4";
            label4.Size = new Size(222, 23);
            label4.TabIndex = 25;
            label4.Text = "Inicia sesión para continuar.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1175, 739);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbError2);
            Controls.Add(pbError);
            Controls.Add(lblError);
            Controls.Add(pbOjo);
            Controls.Add(txtPassword);
            Controls.Add(pbBanner);
            Controls.Add(lblTitulo);
            Controls.Add(panelLinea);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lblUsuario);
            Controls.Add(txtUser);
            Controls.Add(lblContraseña);
            Controls.Add(pbUser);
            Controls.Add(pbPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            Resize += LoginForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pbOjo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbError2).EndInit();
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
        private Panel panelLinea;
        private Label lblError;
        private PictureBox pbError;
        private PictureBox pbError2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}