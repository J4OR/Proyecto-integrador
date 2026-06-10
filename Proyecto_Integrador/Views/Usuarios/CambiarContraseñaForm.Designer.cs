namespace Proyecto_Integrador.Views.Usuarios
{
    partial class CambiarContraseñaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContraseñaForm));
            button1 = new Button();
            btnGuardar = new Button();
            txtConfirmar = new TextBox();
            label8 = new Label();
            txtContraseña = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtContraseñaActual = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(329, 275);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 5, 0, 5);
            button1.Size = new Size(121, 36);
            button1.TabIndex = 51;
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
            btnGuardar.Location = new Point(466, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 5, 0, 5);
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 50;
            btnGuardar.Text = " Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(221, 168);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(375, 27);
            txtConfirmar.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 175);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 48;
            label8.Text = "ConfirmarContraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(221, 135);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(375, 27);
            txtContraseña.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 142);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 46;
            label6.Text = "Contraseña:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 64);
            panel1.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(88, 21);
            label1.Name = "label1";
            label1.Size = new Size(200, 28);
            label1.TabIndex = 1;
            label1.Text = "Cambiar contraseña";
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
            // txtContraseñaActual
            // 
            txtContraseñaActual.Location = new Point(221, 102);
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Size = new Size(375, 27);
            txtContraseñaActual.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 54;
            label2.Text = "Contraseña Actual:";
            // 
            // CambiarContraseñaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 339);
            Controls.Add(txtContraseñaActual);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(txtConfirmar);
            Controls.Add(label8);
            Controls.Add(txtContraseña);
            Controls.Add(label6);
            Name = "CambiarContraseñaForm";
            Text = "CambiarContraseñaForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnGuardar;
        private TextBox txtConfirmar;
        private Label label8;
        private TextBox txtContraseña;
        private Label label6;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtContraseñaActual;
        private Label label2;
    }
}