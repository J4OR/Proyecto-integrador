using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Usuarios
{
    public partial class CambiarContraseñaForm : Form
    {
        private UsuarioController usuarioController = new UsuarioController();
        private Usuario usuarioLogueado;
        public CambiarContraseñaForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (usuarioLogueado.password != PasswordHasher.ToSha256(txtContraseñaActual.Text.Trim()))
            {
                MessageBox.Show("La contraseña actual no es correcta");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("La nueva contraseña no puede estar vacía");
                return;
            }

            if (txtContraseña.Text.Trim() != txtConfirmar.Text.Trim())
            {
                MessageBox.Show("La confirmación de contraseña no coincide");
                return;
            }

            if (PasswordHasher.ToSha256(txtContraseña.Text.Trim()) == usuarioLogueado.password) 
            {
                MessageBox.Show("La nueva contraseña no puede ser igual a la anterior");
                return;
            }


            usuarioLogueado.password = PasswordHasher.ToSha256(txtContraseña.Text.Trim());

            usuarioController.EditarUsuario(usuarioLogueado, usuarioLogueado.id);

            MessageBox.Show("Contraseña actualizada correctamente");

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
