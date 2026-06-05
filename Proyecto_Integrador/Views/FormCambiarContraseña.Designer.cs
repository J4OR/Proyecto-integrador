namespace Proyecto_Integrador.Views
{
    partial class FormCambiarContraseña
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
            this.Text = "Cambiar Contraseña";
            this.Size = new Size(440, 420);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.WhiteSmoke;

            // ── Encabezado ──
            Panel header = new Panel();
            header.Dock = DockStyle.Top;
            header.Height = 52;
            header.BackColor = Color.FromArgb(28, 62, 110);

            Label lblTitulo = new Label();
            lblTitulo.Text = "🔑 Cambiar Contraseña";
            lblTitulo.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            header.Controls.Add(lblTitulo);

            // ── Panel central ──
            Panel centro = new Panel();
            centro.Dock = DockStyle.Fill;
            centro.Padding = new Padding(40, 20, 40, 10);

            int y = 20;

            // Contraseña actual
            centro.Controls.Add(Etiqueta("Contraseña actual:", ref y));
            (txtActual, btnMostrarActual) = CampoPassword(centro, ref y);
            lblMsgActual = Mensaje(centro, ref y);

            // Nueva contraseña
            centro.Controls.Add(Etiqueta("Nueva contraseña:", ref y));
            (txtNueva, btnMostrarNueva) = CampoPassword(centro, ref y);
            lblMsgNueva = Mensaje(centro, ref y);

            // Confirmar
            centro.Controls.Add(Etiqueta("Confirmar nueva contraseña:", ref y));
            (txtConfirmar, btnMostrarConfirmar) = CampoPassword(centro, ref y);
            lblMsgConfirmar = Mensaje(centro, ref y);

            y += 8;

            // Mensaje general
            lblMsgGeneral = new Label();
            lblMsgGeneral.Location = new Point(0, y);
            lblMsgGeneral.Width = 360;
            lblMsgGeneral.Height = 22;
            lblMsgGeneral.Font = new Font("Segoe UI", 9);
            lblMsgGeneral.TextAlign = ContentAlignment.MiddleCenter;
            centro.Controls.Add(lblMsgGeneral);
            y += 28;

            // Botón guardar
            btnGuardar = new Button();
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.Location = new Point(0, y);
            btnGuardar.Width = 360;
            btnGuardar.Height = 38;
            btnGuardar.BackColor = Color.FromArgb(28, 62, 110);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnGuardar.Click += new EventHandler(BtnGuardar_Click);
            centro.Controls.Add(btnGuardar);

            this.Controls.Add(centro);
            this.Controls.Add(header);
        }


        #endregion
    }
}