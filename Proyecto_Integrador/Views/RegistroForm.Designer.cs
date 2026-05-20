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
            txtUser = new TextBox();
            lblTitullo = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.AccessibleDescription = "";
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.InactiveCaption;
            txtUser.Location = new Point(540, 195);
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
            lblTitullo.Location = new Point(620, 53);
            lblTitullo.Name = "lblTitullo";
            lblTitullo.Size = new Size(167, 50);
            lblTitullo.TabIndex = 13;
            lblTitullo.Text = "Registro";
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 627);
            Controls.Add(lblTitullo);
            Controls.Add(txtUser);
            Name = "RegistroForm";
            Text = "RegistroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUser;
        private Label lblTitullo;
    }
}