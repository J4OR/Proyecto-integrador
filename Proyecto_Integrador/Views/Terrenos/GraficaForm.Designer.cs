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
            this.components      = new System.ComponentModel.Container();
            this.panelControles  = new System.Windows.Forms.Panel();
            this.btnReset        = new System.Windows.Forms.Button();
            this.chkEtiquetas    = new System.Windows.Forms.CheckBox();
            this.chkPuntos       = new System.Windows.Forms.CheckBox();
            this.lblDyVal        = new System.Windows.Forms.Label();
            this.trkDy           = new System.Windows.Forms.TrackBar();
            this.lblDy           = new System.Windows.Forms.Label();
            this.lblDxVal        = new System.Windows.Forms.Label();
            this.trkDx           = new System.Windows.Forms.TrackBar();
            this.lblDx           = new System.Windows.Forms.Label();
            this.lblHVal         = new System.Windows.Forms.Label();
            this.trkH            = new System.Windows.Forms.TrackBar();
            this.lblH            = new System.Windows.Forms.Label();
            this.host            = new System.Windows.Forms.Integration.ElementHost();
            this.panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkH)).BeginInit();
            this.SuspendLayout();
            //
            // panelControles
            //
            this.panelControles.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.panelControles.Controls.Add(this.btnReset);
            this.panelControles.Controls.Add(this.chkEtiquetas);
            this.panelControles.Controls.Add(this.chkPuntos);
            this.panelControles.Controls.Add(this.lblDyVal);
            this.panelControles.Controls.Add(this.trkDy);
            this.panelControles.Controls.Add(this.lblDy);
            this.panelControles.Controls.Add(this.lblDxVal);
            this.panelControles.Controls.Add(this.trkDx);
            this.panelControles.Controls.Add(this.lblDx);
            this.panelControles.Controls.Add(this.lblHVal);
            this.panelControles.Controls.Add(this.trkH);
            this.panelControles.Controls.Add(this.lblH);
            this.panelControles.Dock     = System.Windows.Forms.DockStyle.Right;
            this.panelControles.Name     = "panelControles";
            this.panelControles.Size     = new System.Drawing.Size(220, 700);
            this.panelControles.TabIndex = 1;
            //
            // lblH
            //
            this.lblH.AutoSize  = true;
            this.lblH.ForeColor = System.Drawing.Color.White;
            this.lblH.Location  = new System.Drawing.Point(12, 18);
            this.lblH.Name      = "lblH";
            this.lblH.TabIndex  = 0;
            this.lblH.Text      = "Altura de corte h:";
            //
            // trkH
            //
            this.trkH.Location      = new System.Drawing.Point(12, 38);
            this.trkH.Maximum       = 1000;
            this.trkH.Name          = "trkH";
            this.trkH.Size          = new System.Drawing.Size(196, 45);
            this.trkH.TabIndex      = 1;
            this.trkH.TickFrequency = 100;
            this.trkH.Scroll       += new System.EventHandler(this.trkH_Scroll);
            //
            // lblHVal
            //
            this.lblHVal.AutoSize  = true;
            this.lblHVal.ForeColor = System.Drawing.Color.Yellow;
            this.lblHVal.Location  = new System.Drawing.Point(12, 86);
            this.lblHVal.Name      = "lblHVal";
            this.lblHVal.TabIndex  = 2;
            this.lblHVal.Text      = "0.0 m";
            //
            // lblDx
            //
            this.lblDx.AutoSize  = true;
            this.lblDx.ForeColor = System.Drawing.Color.White;
            this.lblDx.Location  = new System.Drawing.Point(12, 118);
            this.lblDx.Name      = "lblDx";
            this.lblDx.TabIndex  = 3;
            this.lblDx.Text      = "Paso Δx:";
            //
            // trkDx
            //
            this.trkDx.Location      = new System.Drawing.Point(12, 138);
            this.trkDx.Maximum       = 100;
            this.trkDx.Minimum       = 1;
            this.trkDx.Name          = "trkDx";
            this.trkDx.Size          = new System.Drawing.Size(196, 45);
            this.trkDx.TabIndex      = 4;
            this.trkDx.TickFrequency = 10;
            this.trkDx.Value         = 1;
            this.trkDx.Scroll       += new System.EventHandler(this.trkDx_Scroll);
            //
            // lblDxVal
            //
            this.lblDxVal.AutoSize  = true;
            this.lblDxVal.ForeColor = System.Drawing.Color.Yellow;
            this.lblDxVal.Location  = new System.Drawing.Point(12, 186);
            this.lblDxVal.Name      = "lblDxVal";
            this.lblDxVal.TabIndex  = 5;
            this.lblDxVal.Text      = "0.0 m";
            //
            // lblDy
            //
            this.lblDy.AutoSize  = true;
            this.lblDy.ForeColor = System.Drawing.Color.White;
            this.lblDy.Location  = new System.Drawing.Point(12, 218);
            this.lblDy.Name      = "lblDy";
            this.lblDy.TabIndex  = 6;
            this.lblDy.Text      = "Paso Δy:";
            //
            // trkDy
            //
            this.trkDy.Location      = new System.Drawing.Point(12, 238);
            this.trkDy.Maximum       = 100;
            this.trkDy.Minimum       = 1;
            this.trkDy.Name          = "trkDy";
            this.trkDy.Size          = new System.Drawing.Size(196, 45);
            this.trkDy.TabIndex      = 7;
            this.trkDy.TickFrequency = 10;
            this.trkDy.Value         = 1;
            this.trkDy.Scroll       += new System.EventHandler(this.trkDy_Scroll);
            //
            // lblDyVal
            //
            this.lblDyVal.AutoSize  = true;
            this.lblDyVal.ForeColor = System.Drawing.Color.Yellow;
            this.lblDyVal.Location  = new System.Drawing.Point(12, 286);
            this.lblDyVal.Name      = "lblDyVal";
            this.lblDyVal.TabIndex  = 8;
            this.lblDyVal.Text      = "0.0 m";
            //
            // chkPuntos
            //
            this.chkPuntos.AutoSize             = true;
            this.chkPuntos.Checked              = true;
            this.chkPuntos.CheckState           = System.Windows.Forms.CheckState.Checked;
            this.chkPuntos.ForeColor            = System.Drawing.Color.White;
            this.chkPuntos.Location             = new System.Drawing.Point(12, 322);
            this.chkPuntos.Name                 = "chkPuntos";
            this.chkPuntos.TabIndex             = 9;
            this.chkPuntos.Text                 = "Mostrar puntos";
            this.chkPuntos.UseVisualStyleBackColor = true;
            this.chkPuntos.CheckedChanged       += new System.EventHandler(this.chkPuntos_CheckedChanged);
            //
            // chkEtiquetas
            //
            this.chkEtiquetas.AutoSize             = true;
            this.chkEtiquetas.Checked              = true;
            this.chkEtiquetas.CheckState           = System.Windows.Forms.CheckState.Checked;
            this.chkEtiquetas.ForeColor            = System.Drawing.Color.White;
            this.chkEtiquetas.Location             = new System.Drawing.Point(12, 352);
            this.chkEtiquetas.Name                 = "chkEtiquetas";
            this.chkEtiquetas.TabIndex             = 10;
            this.chkEtiquetas.Text                 = "Mostrar etiquetas";
            this.chkEtiquetas.UseVisualStyleBackColor = true;
            this.chkEtiquetas.CheckedChanged       += new System.EventHandler(this.chkEtiquetas_CheckedChanged);
            //
            // btnReset
            //
            this.btnReset.BackColor            = System.Drawing.Color.FromArgb(50, 70, 120);
            this.btnReset.FlatStyle            = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor            = System.Drawing.Color.White;
            this.btnReset.Location             = new System.Drawing.Point(12, 395);
            this.btnReset.Name                 = "btnReset";
            this.btnReset.Size                 = new System.Drawing.Size(196, 35);
            this.btnReset.TabIndex             = 11;
            this.btnReset.Text                 = "Reset Cámara";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click               += new System.EventHandler(this.btnReset_Click);
            //
            // host
            //
            this.host.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.host.Name     = "host";
            this.host.TabIndex = 0;
            this.host.Text     = "host";
            this.host.Child    = null;
            //
            // GraficaForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor     = System.Drawing.Color.FromArgb(20, 20, 35);
            this.ClientSize    = new System.Drawing.Size(1120, 700);
            this.Controls.Add(this.host);
            this.Controls.Add(this.panelControles);
            this.MinimumSize   = new System.Drawing.Size(800, 500);
            this.Name          = "GraficaForm";
            this.Text          = "Visualización 3D de Terreno";
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkH)).EndInit();
            this.ResumeLayout(false);
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
