using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.Cotizaciones;
using Proyecto_Integrador.Views.Facturas;
using Proyecto_Integrador.Views.Inicio;
using Proyecto_Integrador.Views.Materiales;
using Proyecto_Integrador.Views.Terrenos;
using Proyecto_Integrador.Views.Usuarios;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views
{
    public partial class FormDashboard : Form
    {
        ControlsUtils resizer;
        public Usuario usuarioLogueado;
        public FormDashboard(Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
            mensajesForm(usuarioLogueado);
            this.resizer = new ControlsUtils(this);
            this.WindowState = FormWindowState.Maximized;

        }
        public void AbrirFormularioEnPanel(Form formulario)
        {
            PanelContenido.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            PanelContenido.Controls.Add(formulario);
            formulario.Show();
            formulario.PerformLayout();


        }
        private void mensajesForm(Usuario usuario)
        {
            lblBienvenida.Text = $"Bienvenido, {usuario.nombre}! \n" +
                $"Seleccione una opción del menú lateral";
            lblUser.Text = usuario.userName;
            lblCorreo.Text = usuario.correo;
            lblRol.Text = $"[{usuario.rol}]";
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if (lblRol.Text.Contains("Admin"))
            {
                btnCambiarContraseña.Visible = false;
                btnUsuarios.Visible = true;
            }
            else
            {
                btnUsuarios.Visible = false;
                btnCambiarContraseña.Visible = true;
            }
            
        }

        private void FormDashboard_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new UsuariosForm(usuarioLogueado));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quiere cerrar sesión?", "Cerrar sesión",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ClientesForm());
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new MaterialesForm());
        }

        private void btnTerrenos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new TerrenoForm(this));
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new CotizacionesForm(usuarioLogueado));
        }
        private void btnFactura_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FacturasForm(this, usuarioLogueado));
        }

    
        private void btnCambiarContraseña_Click_1(object sender, EventArgs e)
        {
            CambiarContraseñaForm cambiarContraseñaForm = new CambiarContraseñaForm(usuarioLogueado);
            cambiarContraseñaForm.ShowDialog();
        }
    }
}
