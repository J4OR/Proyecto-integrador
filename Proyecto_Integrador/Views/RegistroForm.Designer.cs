namespace Proyecto_Integrador.Views
{
    partial class RegistroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            txtUser = new TextBox();
            lblTitullo = new Label();
            pbUser = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.AccessibleDescription = "";
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.InactiveCaption;
            txtUser.Location = new Point(43, 68);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(366, 45);
            txtUser.TabIndex = 7;
            txtUser.Text = "Ingrese su usuario";
            // 
            // lblTitullo
            // 
            lblTitullo.AutoSize = true;
            lblTitullo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitullo.Location = new Point(540, 44);
            lblTitullo.Name = "lblTitullo";
            lblTitullo.Size = new Size(167, 50);
            lblTitullo.TabIndex = 13;
            lblTitullo.Text = "Registro";
            // 
            // pbUser
            // 
            pbUser.BackColor = Color.Transparent;
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(57, 25);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(94, 90);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 14;
            pbUser.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtUser);
            panel1.Location = new Point(57, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 406);
            panel1.TabIndex = 15;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 703);
            Controls.Add(panel1);
            Controls.Add(pbUser);
            Controls.Add(lblTitullo);
            Name = "RegistroForm";
            Text = "RegistroForm";
            Resize += RegistroForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUser;
        private Label lblTitullo;
        private PictureBox pbUser;
        private Panel panel1;
    }
}