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
            textBox1 = new TextBox();
            txtUser = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.BackColor = Color.Transparent;
            pictureBoxPassword.Image = (Image)resources.GetObject("pictureBoxPassword.Image");
            pictureBoxPassword.Location = new Point(478, 322);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(58, 48);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPassword.TabIndex = 9;
            pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.BackColor = Color.Transparent;
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(478, 183);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(58, 48);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUser.TabIndex = 8;
            pictureBoxUser.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.AccessibleDescription = "";
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(564, 322);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 45);
            textBox1.TabIndex = 7;
            textBox1.Text = "Ingrese su contraseña";
            // 
            // txtUser
            // 
            txtUser.AccessibleDescription = "";
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.InactiveCaption;
            txtUser.Location = new Point(564, 183);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(366, 45);
            txtUser.TabIndex = 6;
            txtUser.Text = "Ingrese su usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 625);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(889, 331);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(942, 624);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBoxPassword);
            Controls.Add(pictureBoxUser);
            Controls.Add(textBox1);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPassword;
        private PictureBox pictureBoxUser;
        private TextBox textBox1;
        private TextBox txtUser;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}