using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Security;
using Proyecto_Integrador.Validator;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Usuarios
{
    public partial class RegistroForm : Form
    {
        private UsuarioController usuarioController = new UsuarioController();
        private Dictionary<string, Label> labelsError;
        private ControlsUtils resizer;
        public RegistroForm()
        {
            InitializeComponent();
            resizer = new ControlsUtils(this);
            this.WindowState = FormWindowState.Maximized;
            txtNombre.TextChanged += (s, e) => ValidarEnTiempoReal();
            txtTelefono.TextChanged += (s, e) => ValidarEnTiempoReal();
            txtDocumento.TextChanged += (s, e) => ValidarEnTiempoReal();
            txtCorreo.TextChanged += (s, e) => ValidarEnTiempoReal();
            txtUsuario.TextChanged += (s, e) => ValidarEnTiempoReal();
            txtContraseña.TextChanged += (s, e) => ValidarEnTiempoReal();
            txtConfirmar.TextChanged += (s, e) => ValidarEnTiempoReal();

            labelsError = new Dictionary<string, Label>
            {
                { "txtNombre",     lblErrorNombre     },
                { "txtTelefono",   lblErrorTelefono   },
                { "txtDocumento",  lblErrorDocumento  },
                { "txtCorreo",     lblErrorCorreo     },
                { "txtUsuario",    lblErrorUsuario    },
                { "txtContraseña", lblErrorContraseña },
                { "txtConfirmar",  lblErrorConfirmar  }
            };
        }

        private void RegistroForm_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();

        }

        private void ValidarEnTiempoReal()
        {
            var errores = UsuarioValidator.Validar(
                txtNombre.Text,
                txtTelefono.Text,
                txtDocumento.Text,
                txtCorreo.Text,
                txtUsuario.Text,
                txtContraseña.Text,
                txtConfirmar.Text
            );

            MostrarError(labelsError, errores);
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
        private void mostrarContraseña(TextBox txt, PictureBox pb)
        {
            if (txt.PasswordChar == '*')
            {
                txt.PasswordChar = '\0';
                pb.Image = Properties.Resources.ojoAbierto;
            }
            else
            {
                txt.PasswordChar = '*';
                pb.Image = Properties.Resources.ojoCerrado;
            }
        }
        private void pbOjo_Click(object sender, EventArgs e)
        {
            mostrarContraseña(txtContraseña, pbOjo);
        }

        private void pbOjo2_Click(object sender, EventArgs e)
        {
            mostrarContraseña(txtConfirmar, pbOjo2);
        }

        private void MostrarError(Dictionary<string, Label> labelsError, Dictionary<string, string> errores)
        {
            foreach (var entry in labelsError)
            {
                if (errores.ContainsKey(entry.Key))
                {
                    entry.Value.Text = "! " + errores[entry.Key];
                    entry.Value.Visible = true;
                }
                else
                {
                    entry.Value.Text = "";
                    entry.Value.Visible = false;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var errores = UsuarioValidator.Validar(
            txtNombre.Text, txtTelefono.Text, txtDocumento.Text, txtCorreo.Text,
            txtUsuario.Text, txtContraseña.Text, txtConfirmar.Text);

            MostrarError(labelsError, errores);

            if (errores.Count > 0) return;

            if (usuarioController.ExisteUsuario(txtUsuario.Text))
            {
                labelsError["txtUsuario"].Text = "! Este nombre de usuario ya está en uso.";
                labelsError["txtUsuario"].Visible = true;
                return;
            }

            if (usuarioController.ExisteDocumento(txtDocumento.Text))
            {
                labelsError["txtDocumento"].Text = "! Este documento ya está registrado.";
                labelsError["txtDocumento"].Visible = true;
                return;
            }


            Usuario nuevoUsuario = new Usuario(txtDocumento.Text, txtNombre.Text,
                txtTelefono.Text, txtCorreo.Text, txtUsuario.Text, PasswordHasher.ToSha256(txtContraseña.Text));
            usuarioController.AgregarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
