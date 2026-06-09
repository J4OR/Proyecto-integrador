namespace Proyecto_Integrador.Views.Terrenos
{
    partial class GraficaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelControles = new Panel();
            btnReset = new Button();
            chkEtiquetas = new CheckBox();
            chkPuntos = new CheckBox();
            lblDyVal = new Label();
            trkDy = new TrackBar();
            lblDy = new Label();
            lblDxVal = new Label();
            trkDx = new TrackBar();
            lblDx = new Label();
            lblHVal = new Label();
            trkH = new TrackBar();
            lblH = new Label();
            host = new System.Windows.Forms.Integration.ElementHost();
            panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkDy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkDx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkH).BeginInit();
            SuspendLayout();
            // 
            // panelControles
            // 
            panelControles.BackColor = Color.FromArgb(30, 30, 45);
            panelControles.Controls.Add(btnReset);
            panelControles.Controls.Add(chkEtiquetas);
            panelControles.Controls.Add(chkPuntos);
            panelControles.Controls.Add(lblDyVal);
            panelControles.Controls.Add(trkDy);
            panelControles.Controls.Add(lblDy);
            panelControles.Controls.Add(lblDxVal);
            panelControles.Controls.Add(trkDx);
            panelControles.Controls.Add(lblDx);
            panelControles.Controls.Add(lblHVal);
            panelControles.Controls.Add(trkH);
            panelControles.Controls.Add(lblH);
            panelControles.Dock = DockStyle.Right;
            panelControles.Location = new Point(900, 0);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(220, 700);
            panelControles.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(50, 70, 120);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(12, 395);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(196, 35);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset Cámara";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // chkEtiquetas
            // 
            chkEtiquetas.AutoSize = true;
            chkEtiquetas.Checked = true;
            chkEtiquetas.CheckState = CheckState.Checked;
            chkEtiquetas.ForeColor = Color.White;
            chkEtiquetas.Location = new Point(12, 352);
            chkEtiquetas.Name = "chkEtiquetas";
            chkEtiquetas.Size = new Size(147, 24);
            chkEtiquetas.TabIndex = 10;
            chkEtiquetas.Text = "Mostrar etiquetas";
            chkEtiquetas.UseVisualStyleBackColor = true;
            chkEtiquetas.CheckedChanged += chkEtiquetas_CheckedChanged;
            // 
            // chkPuntos
            // 
            chkPuntos.AutoSize = true;
            chkPuntos.Checked = true;
            chkPuntos.CheckState = CheckState.Checked;
            chkPuntos.ForeColor = Color.White;
            chkPuntos.Location = new Point(12, 322);
            chkPuntos.Name = "chkPuntos";
            chkPuntos.Size = new Size(131, 24);
            chkPuntos.TabIndex = 9;
            chkPuntos.Text = "Mostrar puntos";
            chkPuntos.UseVisualStyleBackColor = true;
            chkPuntos.CheckedChanged += chkPuntos_CheckedChanged;
            // 
            // lblDyVal
            // 
            lblDyVal.AutoSize = true;
            lblDyVal.ForeColor = Color.Yellow;
            lblDyVal.Location = new Point(12, 286);
            lblDyVal.Name = "lblDyVal";
            lblDyVal.Size = new Size(45, 20);
            lblDyVal.TabIndex = 8;
            lblDyVal.Text = "0.0 m";
            // 
            // trkDy
            // 
            trkDy.Location = new Point(12, 238);
            trkDy.Maximum = 100;
            trkDy.Minimum = 1;
            trkDy.Name = "trkDy";
            trkDy.Size = new Size(196, 56);
            trkDy.TabIndex = 7;
            trkDy.TickFrequency = 10;
            trkDy.Value = 1;
            trkDy.Scroll += trkDy_Scroll;
            // 
            // lblDy
            // 
            lblDy.AutoSize = true;
            lblDy.ForeColor = Color.White;
            lblDy.Location = new Point(12, 218);
            lblDy.Name = "lblDy";
            lblDy.Size = new Size(63, 20);
            lblDy.TabIndex = 6;
            lblDy.Text = "Paso Δy:";
            // 
            // lblDxVal
            // 
            lblDxVal.AutoSize = true;
            lblDxVal.ForeColor = Color.Yellow;
            lblDxVal.Location = new Point(12, 186);
            lblDxVal.Name = "lblDxVal";
            lblDxVal.Size = new Size(45, 20);
            lblDxVal.TabIndex = 5;
            lblDxVal.Text = "0.0 m";
            // 
            // trkDx
            // 
            trkDx.Location = new Point(12, 138);
            trkDx.Maximum = 100;
            trkDx.Minimum = 1;
            trkDx.Name = "trkDx";
            trkDx.Size = new Size(196, 56);
            trkDx.TabIndex = 4;
            trkDx.TickFrequency = 10;
            trkDx.Value = 1;
            trkDx.Scroll += trkDx_Scroll;
            // 
            // lblDx
            // 
            lblDx.AutoSize = true;
            lblDx.ForeColor = Color.White;
            lblDx.Location = new Point(12, 118);
            lblDx.Name = "lblDx";
            lblDx.Size = new Size(63, 20);
            lblDx.TabIndex = 3;
            lblDx.Text = "Paso Δx:";
            // 
            // lblHVal
            // 
            lblHVal.AutoSize = true;
            lblHVal.ForeColor = Color.Yellow;
            lblHVal.Location = new Point(12, 86);
            lblHVal.Name = "lblHVal";
            lblHVal.Size = new Size(45, 20);
            lblHVal.TabIndex = 2;
            lblHVal.Text = "0.0 m";
            // 
            // trkH
            // 
            trkH.Location = new Point(12, 38);
            trkH.Maximum = 1000;
            trkH.Name = "trkH";
            trkH.Size = new Size(196, 56);
            trkH.TabIndex = 1;
            trkH.TickFrequency = 100;
            trkH.Scroll += trkH_Scroll;
            // 
            // lblH
            // 
            lblH.AutoSize = true;
            lblH.ForeColor = Color.White;
            lblH.Location = new Point(12, 18);
            lblH.Name = "lblH";
            lblH.Size = new Size(123, 20);
            lblH.TabIndex = 0;
            lblH.Text = "Altura de corte h:";
            // 
            // host
            // 
            host.Dock = DockStyle.Fill;
            host.Location = new Point(0, 0);
            host.Name = "host";
            host.Size = new Size(900, 700);
            host.TabIndex = 0;
            host.Text = "host";
            // 
            // GraficaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 35);
            ClientSize = new Size(1120, 700);
            Controls.Add(host);
            Controls.Add(panelControles);
            MinimumSize = new Size(800, 500);
            Name = "GraficaForm";
            Text = "Visualización 3D de Terreno";
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkDy).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkDx).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkEtiquetas;
        private System.Windows.Forms.CheckBox chkPuntos;
        private System.Windows.Forms.Label lblDyVal;
        private System.Windows.Forms.TrackBar trkDy;
        private System.Windows.Forms.Label lblDy;
        private System.Windows.Forms.Label lblDxVal;
        private System.Windows.Forms.TrackBar trkDx;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.Label lblHVal;
        private System.Windows.Forms.TrackBar trkH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Integration.ElementHost host;
    }
}
