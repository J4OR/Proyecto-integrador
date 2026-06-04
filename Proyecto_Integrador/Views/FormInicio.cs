using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.Utils;

namespace Proyecto_Integrador.Views
{
    public partial class FormInicio : Form
    {
        private readonly Usuario _usuario;
        private readonly UsuarioController _usuarioCtrl;
        private readonly ClienteController _clienteCtrl;
        private readonly MaterialController _materialCtrl;
        private readonly TerrenoController _terrenoCtrl;
        private readonly CotizacionController _cotCtrl;
        private readonly FacturaController _facCtrl;

        public FormInicio(Usuario usuario)
        {
            _usuario = usuario;

            _usuarioCtrl = new UsuarioController();
            _clienteCtrl = new ClienteController();
            _materialCtrl = new MaterialController();
            _terrenoCtrl = new TerrenoController();
            _cotCtrl = new CotizacionController();
            _facCtrl = new FacturaController();

            InitializeComponent();
        }

        private Panel panelMenu;
        private Panel panelContenido;
        private Label lblBienvenida;
        private Label lblRol;

        public FormInicio(Usuario usuario, UsuarioController uc, ClienteController cc,
            MaterialController mc, TerrenoController tc, CotizacionController coc, FacturaController fc)
        {
            _usuario = usuario;
            _usuarioCtrl = uc;
            _clienteCtrl = cc;
            _materialCtrl = mc;
            _terrenoCtrl = tc;
            _cotCtrl = coc;
            _facCtrl = fc;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "MovimientaTierra 2026 – Sistema de Cálculo y Facturación";
            this.Size = new Size(1100, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(900, 600);

            // Barra lateral izquierda
            panelMenu = new Panel();
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Width = 220;
            panelMenu.BackColor = Color.FromArgb(28, 62, 110);

            Label logoLabel = new Label();
            logoLabel.Text = "MovimientaTierra";
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
            AgregarBotonMenu("Terreno / Volumen", menuY, new EventHandler(AbrirTerreno)); menuY += 45;
            AgregarBotonMenu("Clientes", menuY, new EventHandler(AbrirClientes)); menuY += 45;
            AgregarBotonMenu("Materiales", menuY, new EventHandler(AbrirMateriales)); menuY += 45;
            AgregarBotonMenu("Cotizaciones", menuY, new EventHandler(AbrirCotizaciones)); menuY += 45;
            AgregarBotonMenu("Facturas", menuY, new EventHandler(AbrirFacturas)); menuY += 45;
            AgregarBotonMenu("Cambiar Contraseña", menuY, new EventHandler(AbrirCambioContrasena)); menuY += 45;

            if (_usuario.rol == Rol.Administrador)
            {
                AgregarBotonMenu("Administrar Usuarios", menuY, new EventHandler(AbrirAdminUsuarios));
                menuY += 45;
            }

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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirTerreno(object sender, EventArgs e)
        {
            
        }

        private void AbrirClientes(object sender, EventArgs e)
        {
            
        }

        private void AbrirMateriales(object sender, EventArgs e)
        {
            
        }

        private void AbrirCotizaciones(object sender, EventArgs e)
        {
           
        }

        private void AbrirFacturas(object sender, EventArgs e)
        {
            
        }

        private void AbrirCambioContrasena(object sender, EventArgs e)
        {
            
        }

        private void AbrirAdminUsuarios(object sender, EventArgs e)
        {
            
        }
    }
}
