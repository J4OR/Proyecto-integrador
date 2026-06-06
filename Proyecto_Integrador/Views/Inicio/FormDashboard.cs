using Proyecto_Integrador.Models;
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
        public FormDashboard(Usuario usuarioLogueado)
        {
            InitializeComponent();
            mensajesForm(usuarioLogueado);
            this.resizer = new ControlsUtils(this);

        }

        private void mensajesForm(Usuario usuario)
        {
            lblBienvenida.Text = $"Bienvenido, {usuario.nombre}!";
            lblUser.Text = usuario.userName;
            lblCorreo.Text = usuario.correo;
            lblRol.Text = $"[{usuario.rol}]";
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if (lblRol.Text.Contains("Admin"))
            {
                btnUsuarios.Visible = true;
            }
            else
            {
                btnUsuarios.Visible = false;
            }
        }

        private void FormDashboard_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();
        }
    }
}
