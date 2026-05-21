using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();


            pictureBoxOjo.Image = Properties.Resources.ojoAbierto;

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ingrese su contraseña")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
                pictureBoxOjo.Image = Properties.Resources.ojoCerrado;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Ingrese su contraseña";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = SystemColors.InactiveCaption;
                pictureBoxOjo.Image = Properties.Resources.ojoAbierto;
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
                pictureBoxOjo.Image = Properties.Resources.ojoAbierto;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pictureBoxOjo.Image = Properties.Resources.ojoCerrado;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            registroForm.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;
            UsuarioController controller = new UsuarioController();
            Usuario usuario = controller.BuscarPorUser(user);

            if (usuario != null)
            {
                if (usuario.password == password)
                {
                    MessageBox.Show("Inicio de sesión exitoso");

                    // Abrir otro formulario
                    LoginForm home = new LoginForm();
                    home.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }
        }
    }
}
