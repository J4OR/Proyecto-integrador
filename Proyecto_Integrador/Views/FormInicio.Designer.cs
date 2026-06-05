using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views
{
    partial class FormInicio
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

        private void AgregarBotonMenu(string texto, int y, EventHandler handler)
        {
            Button btn = new Button();
            btn.Text = texto;
            btn.Location = new Point(10, y);
            btn.Width = 200;
            btn.Height = 36;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(8, 0, 0, 0);
            btn.Font = new Font("Segoe UI", 9.5f);
            btn.BackColor = Color.FromArgb(28, 62, 110);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 100, 170);
            btn.Click += handler;
            panelMenu.Controls.Add(btn);
        }

        private void AbrirEnContenido(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(form);
            form.Show();
        }
        private void InitializeComponent()
        {
            this.Text = "MI SISTEMA 2026 – Sistema de Cálculo y Facturación";
            this.Size = new Size(1100, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(900, 600);

            // Barra lateral izquierda
            panelMenu = new Panel();
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Width = 220;
            panelMenu.BackColor = Color.FromArgb(28, 62, 110);

            Label logoLabel = new Label();
            logoLabel.Text = "🏗️ MI SISTEMA";
            logoLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            logoLabel.ForeColor = Color.White;
            logoLabel.AutoSize = false;
            logoLabel.Width = 220;
            logoLabel.Height = 40;
            logoLabel.TextAlign = ContentAlignment.MiddleCenter;
            logoLabel.Location = new Point(0, 10);
            panelMenu.Controls.Add(logoLabel);

            lblBienvenida = new Label();
            lblBienvenida.Text = "Hola, " + _usuario.nombre;
            lblBienvenida.ForeColor = Color.LightCyan;
            lblBienvenida.AutoSize = false;
            lblBienvenida.Width = 220;
            lblBienvenida.Height = 20;
            lblBienvenida.Location = new Point(0, 55);
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Font = new Font("Segoe UI", 9);
            panelMenu.Controls.Add(lblBienvenida);

            lblRol = new Label();
            lblRol.Text = "[" + _usuario.rol + "]";
            lblRol.ForeColor = Color.Gold;
            lblRol.AutoSize = false;
            lblRol.Width = 220;
            lblRol.Height = 18;
            lblRol.Location = new Point(0, 73);
            lblRol.TextAlign = ContentAlignment.MiddleCenter;
            lblRol.Font = new Font("Segoe UI", 8, FontStyle.Italic);
            panelMenu.Controls.Add(lblRol);

            Label sep = new Label();
            sep.Width = 200;
            sep.Height = 1;
            sep.BackColor = Color.FromArgb(80, 120, 180);
            sep.Location = new Point(10, 96);
            panelMenu.Controls.Add(sep);

            // Botones del menú
            int menuY = 105;
            AgregarBotonMenu("🏔️ Terreno / Volumen", menuY, new EventHandler(AbrirTerreno)); menuY += 45;
            AgregarBotonMenu("👤 Clientes", menuY, new EventHandler(AbrirClientes)); menuY += 45;
            AgregarBotonMenu("🧱 Materiales", menuY, new EventHandler(AbrirMateriales)); menuY += 45;
            AgregarBotonMenu("💲Cotizaciones", menuY, new EventHandler(AbrirCotizaciones)); menuY += 45;
            AgregarBotonMenu("🧾 Facturas", menuY, new EventHandler(AbrirFacturas)); menuY += 45;
            AgregarBotonMenu("🔄 Cambiar Contraseña", menuY, new EventHandler(AbrirCambioContrasena)); menuY += 45;
            AgregarBotonMenu("👑 Administrar Usuarios", menuY, new EventHandler(AbrirAdminUsuarios)); menuY += 45;

            //if (_usuario.rol == Rol.Administrador)
            //{
            //    AgregarBotonMenu("Administrar Usuarios", menuY, new EventHandler(AbrirAdminUsuarios));
            //    menuY += 45;
            //}

            Button btnSalir = new Button();
            btnSalir.Text = "Cerrar sesión";
            btnSalir.Location = new Point(10, 600);
            btnSalir.Width = 200;
            btnSalir.Height = 34;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.BackColor = Color.FromArgb(150, 30, 30);
            btnSalir.Font = new Font("Segoe UI", 9);
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(200, 50, 50);
            btnSalir.Click += new EventHandler(BtnSalir_Click);
            panelMenu.Controls.Add(btnSalir);

            // Panel contenido
            panelContenido = new Panel();
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.BackColor = Color.WhiteSmoke;

            Label lblBienvenidaMain = new Label();
            lblBienvenidaMain.Text = "Bienvenido al sistema MovimientaTierra\n\nSeleccione una opción del menú lateral.";
            lblBienvenidaMain.Font = new Font("Segoe UI", 13);
            lblBienvenidaMain.ForeColor = Color.Gray;
            lblBienvenidaMain.Dock = DockStyle.Fill;
            lblBienvenidaMain.TextAlign = ContentAlignment.MiddleCenter;
            panelContenido.Controls.Add(lblBienvenidaMain);

            this.Controls.Add(panelContenido);
            this.Controls.Add(panelMenu);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    SuspendLayout();
        //    // 
        //    // FormInicio
        //    // 
        //    AutoScaleDimensions = new SizeF(8F, 20F);
        //    AutoScaleMode = AutoScaleMode.Font;
        //    ClientSize = new Size(989, 603);
        //    Name = "FormInicio";
        //    Text = "FormInicio";
        //    ResumeLayout(false);
        //}

        #endregion
    }
}