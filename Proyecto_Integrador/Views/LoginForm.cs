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
        //private Size originalFormSize;
        //private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();
        //private Dictionary<Control, float> controlFontSizes = new Dictionary<Control, float>();
        private ControlResizer resizer;
        public LoginForm()
        {
            InitializeComponent();
            pbOjo.Image = Properties.Resources.ojoAbierto;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            linkLblContraseña.AutoSize = true;
            resizer = new ControlResizer(this);
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            resizer.ejecutarEscalado();
            ajustarAlineacionEspecial();

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
