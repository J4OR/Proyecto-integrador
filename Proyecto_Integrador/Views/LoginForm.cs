using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        
    }
}
