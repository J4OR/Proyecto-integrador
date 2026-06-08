namespace Proyecto_Integrador.Views.Terrenos
{
    partial class TerrenoForm
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
            btnCalculadora = new Button();
            SuspendLayout();
            // 
            // btnCalculadora
            // 
            btnCalculadora.BackColor = Color.FromArgb(0, 0, 64);
            btnCalculadora.FlatStyle = FlatStyle.Flat;
            btnCalculadora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculadora.ForeColor = Color.White;
            btnCalculadora.Location = new Point(597, 50);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(119, 33);
            btnCalculadora.TabIndex = 23;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalculadora.UseVisualStyleBackColor = false;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // TerrenoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculadora);
            Name = "TerrenoForm";
            Text = "TerrenoForm";
            Load += TerrenoForm_Load;
            Resize += TerrenoForm_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculadora;
    }
}