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
    public partial class RegistroForm : Form
    {
        ControlResizer resizer;
        public RegistroForm()
        {
            InitializeComponent();
            resizer = new ControlResizer(this);
            this.WindowState = FormWindowState.Maximized;
        }

        private void RegistroForm_Resize(object sender, EventArgs e)
        {
            resizer.ejecutarEscalado();

        }

        private void TextBoxs_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            if (txt.Text == "Ingrese el nombre completo" || txt.Text == "Ingrese el número de telefono" 
                || txt.Text == "Ingrese el documento de identidad" || txt.Text == "Ingrese el correo electrónico" 
                || txt.Text == "Ingrese el nombre de usuario" || txt.Text == "Ingrese la contraseña" || txt.Text == "Confirma la contraseña")
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;

                if (txt.Name == "txtContraseña")
                {
                    txt.PasswordChar = '*';
                    pbOjo.Image = Properties.Resources.ojoCerrado;
                }
                if (txt.Name == "txtConfirmar")
                {
                    txt.PasswordChar = '*';
                    pbOjo2.Image = Properties.Resources.ojoCerrado;
                }
            }
        }
        private void TextBoxs_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                switch (txt.Name)
                {
                    case "txtNombre":
                        txt.Text = "Ingrese el nombre completo";
                        break;
                    case "txtTelefono":
                        txt.Text = "Ingrese el número de telefono";
                        break;
                    case "txtDocumento":
                        txt.Text = "Ingrese el documento de identidad";
                        break;
                    case "txtCorreo":
                        txt.Text = "Ingrese el correo electrónico";
                        break;
                    case "txtUsuario":
                        txt.Text = "Ingrese el nombre de usuario";
                        break;
                    case "txtContraseña":
                        txt.Text = "Ingrese la contraseña";
                        break;
                    case "txtConfirmar":
                        txt.Text = "Confirma la contraseña";
                        break;
                }
                if (txt.Name == "txtContraseña")
                {
                    txt.PasswordChar = '\0';
                    pbOjo.Image = Properties.Resources.ojoAbierto;
                }
                if (txt.Name == "txtConfirmar")
                {
                    txt.PasswordChar = '\0';
                    pbOjo2.Image = Properties.Resources.ojoAbierto;
                }
                txt.ForeColor = SystemColors.InactiveCaption;
            }
        }
    }
}
