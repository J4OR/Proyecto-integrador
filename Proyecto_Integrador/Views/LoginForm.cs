using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views
{
    public partial class LoginForm : Form
    {
        UsuarioController controller;
        private ControlResizer resizer;
        public LoginForm()
        {
            InitializeComponent();
            controller = new UsuarioController();
            pbOjo.Image = Properties.Resources.ojoAbierto;
            lblError.Visible = false;
            pbError.Visible = false;
            pbError2.Visible = false;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
             int id = controller.ObtenerSiguienteId();
            Usuario admin = new Usuario(id, "1234567890", "Admin User", "555-1234", "admin@example.com", "admin", "admin123", Rol.Administrador, true);
            MessageBox.Show("Test");
            controller.AgregarUsuario(admin);

            linkLblContraseña.AutoSize = true;
            resizer = new ControlResizer(this);
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            resizer.ejecutarEscalado();
            ajustarAlineacionEspecial();

            if (lblError.Visible)
            {
                ajustarPosicionError();
            }

        }
        private void ajustarAlineacionEspecial()
        {
            int txtPasswordRightEdge = txtPassword.Location.X + txtPassword.Width;
            int newLinkX = txtPasswordRightEdge - linkLblContraseña.Width;
            linkLblContraseña.Location = new Point(newLinkX, linkLblContraseña.Location.Y);
        }



        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ingrese su contraseña")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
                pbOjo.Image = Properties.Resources.ojoCerrado;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Ingrese su contraseña";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = SystemColors.InactiveCaption;
                pbOjo.Image = Properties.Resources.ojoAbierto;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Ingrese su usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtUser.Text = "Ingrese su usuario";
                txtUser.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void pictureBoxOjo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                pbOjo.Image = Properties.Resources.ojoAbierto;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pbOjo.Image = Properties.Resources.ojoCerrado;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            registroForm.ShowDialog();
        }
        private void ajustarPosicionError()
        {
            int separacion = 8;
            int centroLinea = this.panelLinea.Left + (panelLinea.Width / 2);
            lblError.Left = centroLinea - (lblError.Width / 2);
            pbError.Left = lblError.Left - pbError.Width - separacion;
            pbError2.Left = lblError.Right + separacion;
            pbError.Top = lblError.Top + (lblError.Height - pbError.Height) / 2;
            pbError2.Top = lblError.Top + (lblError.Height - pbError2.Height) / 2;
        }
        private void mostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Refresh();
            lblError.Visible = true;
            pbError.Visible = true;
            pbError2.Visible = true;
            ajustarPosicionError();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();
            Usuario usuario = controller.BuscarPorUser(userName);
            string mensaje = "";
            if (usuario != null)
            {
                if (!usuario.estado)
                {
                    mensaje = "El usuario está inactivo.";
                    mostrarError(mensaje);
                    return;
                }
                if (usuario.password == password)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    Form_prueba form_Prueba = new Form_prueba(usuario);
                    form_Prueba.Show();
                    this.Hide();
                }
                else
                {
                    mensaje = "Contraseña incorrecta.";
                    mostrarError(mensaje);
                    return;
                }
            }
            else
            {
                mensaje = "Usuario no encontrado.";
                mostrarError(mensaje);
                return;
            }
        }
    }
}
