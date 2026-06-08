using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Security;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging.Effects;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views
{
    public partial class LoginForm : Form
    {
        private UsuarioController controller = new UsuarioController();
        private ControlsUtils resizer;
        public LoginForm()
        {
            InitializeComponent();
            txtUser.ForeColor = Color.Black;
            txtPassword.ForeColor = Color.Black;
            txtUser.Text = "admin";
            txtPassword.Text = "admin123@";
            this.resizer = new ControlsUtils(this);
            this.WindowState = FormWindowState.Maximized;

            

        }
        private void RestaurarPlaceholders()
        {
            txtUser.Text = "Ingrese su usuario";
            txtUser.ForeColor = SystemColors.InactiveCaption;

            txtPassword.Text = "Ingrese su contraseña";
            txtPassword.ForeColor = SystemColors.InactiveCaption;
            txtPassword.PasswordChar = '\0';
            pbOjo.Image = Properties.Resources.ojoAbierto;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            pbOjo.Image = Properties.Resources.ojoAbierto;
            lblError.Visible = false;
            pbError.Visible = false;
            pbError2.Visible = false;
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();

            if (lblError.Visible)
            {
                ajustarPosicionError();
            }

        }

        private void TextBoxs_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            if (txt.Text == "Ingrese su usuario" || txt.Text == "Ingrese su contraseña")
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;

                if (txt.Name == "txtPassword")
                {
                    txt.PasswordChar = '*';
                    pbOjo.Image = Properties.Resources.ojoCerrado;
                }
            }
            else
            {
                txt.ForeColor = Color.Black;
            }
        }

        private void TextBoxs_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt.Name == "txtUser")
                {
                    txt.Text = "Ingrese su usuario";
                }
                else if (txt.Name == "txtPassword")
                {
                    txt.Text = "Ingrese su contraseña";
                    txt.PasswordChar = '\0';
                    pbOjo.Image = Properties.Resources.ojoAbierto;
                }

                txt.ForeColor = SystemColors.InactiveCaption;
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
            registroForm.FormClosed += (s, e) => this.Show();
            this.Hide();
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
            string password = PasswordHasher.ToSha256(txtPassword.Text.Trim());

            Usuario usuario = controller.BuscarPorUserName(userName);
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
                    lblError.Visible = false;
                    pbError.Visible = false;
                    pbError2.Visible = false;

                    MessageBox.Show("Inicio de sesión exitoso");

                    this.Hide();
                    FormDashboard formDashboard = new FormDashboard(usuario);
                    formDashboard.ShowDialog();
                    RestaurarPlaceholders();
                    this.Show();

                }
                else
                {
                    mensaje = "Contraseña incorrecta.";
                    mostrarError(mensaje);
                }
            }
            else
            {
                mensaje = "Usuario no encontrado.";
                mostrarError(mensaje);
            }
        }

        
    }

}
