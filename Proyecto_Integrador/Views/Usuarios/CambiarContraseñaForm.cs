using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Security;
using Proyecto_Integrador.Validator;
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

        private void ValidarEnTiempoReal()
        {
            var errores = UsuarioValidator.ValidarContraseña(
                txtContraseña.Text,
                txtConfirmar.Text
            );

            if (errores.ContainsKey("txtContraseña"))
            {
                lblValidacionContraseña.Text = errores["txtContraseña"];
                lblValidacionContraseña.Visible = true;
            }
            else
            {
                lblValidacionContraseña.Visible = false;
            }

            if (errores.ContainsKey("txtConfirmar"))
            {
                lblValidacion.Text = errores["txtConfirmar"];
                lblValidacion.Visible = true;
            }
            else
            {
                lblValidacion.Visible = false;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            lblValidacionContraseña.Visible = false;
            lblValidacion.Visible = false;


            if (usuarioLogueado.password != PasswordHasher.ToSha256(txtContraseñaActual.Text.Trim()))
            {
                lblValidacionContraseña.Text = "La contraseña actual no es correcta";
                lblValidacionContraseña.Visible = true;
                return;
            }

            var errores = UsuarioValidator.ValidarContraseña(
                txtContraseña.Text,
                txtConfirmar.Text
            );

            if (errores.ContainsKey("txtContraseña"))
            {
                lblValidacionContraseña.Text = errores["txtContraseña"];
                lblValidacionContraseña.ForeColor = Color.Red;
                lblValidacionContraseña.Visible = true;
                return;
            }

            if (errores.ContainsKey("txtConfirmar"))
            {
                lblValidacion.Text = errores["txtConfirmar"];
                lblValidacion.Visible = true;
                return;
            }

            if (PasswordHasher.ToSha256(txtContraseña.Text.Trim()) == usuarioLogueado.password)
            {
                lblValidacionContraseña.Text = "La nueva contraseña no puede ser igual a la anterior";
                lblValidacionContraseña.ForeColor = Color.Red;
                lblValidacionContraseña.Visible = true;
                return;
            }

            usuarioLogueado.password = PasswordHasher.ToSha256(txtContraseña.Text.Trim());

            usuarioController.EditarUsuario(usuarioLogueado, usuarioLogueado.id);


            MessageBox.Show("Contraseña actualizada correctamente ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarEnTiempoReal();
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            ValidarEnTiempoReal();
        }
    }
}
