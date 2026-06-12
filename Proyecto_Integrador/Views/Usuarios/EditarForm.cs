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
    public partial class EditarForm : Form
    {
        private UsuarioController usuarioController = new UsuarioController();
        private Dictionary<string, Label> labelsError;
        private Usuario usuario;
        private Usuario usuarioLogueado;
        bool cambiarPassword => panelCambiarContraseña.Visible;

        public EditarForm(Usuario usuario, Usuario usuarioLogueado)
        {
            InitializeComponent();
            cbRol.DataSource = Enum.GetValues(typeof(Rol));
            this.usuario = usuario;
            this.usuarioLogueado = usuarioLogueado;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            cbRol.SelectedIndex = 0;
        }

        private void EditarForm_Load(object sender, EventArgs e)
        {
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
            if (usuarioLogueado.id == usuario.id)
            {
                lblRol.Visible = false;
                cbRol.Visible = false;
            }
            if (usuarioLogueado.userName == "admin" && usuarioLogueado.id == usuario.id)
            {
                lblErrorUsuario.Visible = false;
                txtUsuario.Visible = false;
                lblUsuario.Visible = false;
                pbUsuario.Visible = false;
                pbRol.Visible = false;
                cbRol.Visible = false;
                lblRol.Visible = false;
            }
            cargarDatos();
        }

        private void cargarDatos()
        {
            txtNombre.Text = usuario.nombre;
            txtTelefono.Text = usuario.telefono;
            txtDocumento.Text = usuario.identificacion;
            txtCorreo.Text = usuario.correo;
            txtUsuario.Text = usuario.userName;
            cbRol.SelectedItem = usuario.rol;


            txtNombre.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtDocumento.ForeColor = Color.Black;
            txtCorreo.ForeColor = Color.Black;
            txtUsuario.ForeColor = Color.Black;

        }

        private void TextBoxs_TextChanged(object sender, EventArgs e)
        {
            var errores = UsuarioValidator.Validar(txtNombre.Text, txtTelefono.Text, txtDocumento.Text, txtCorreo.Text,
                txtUsuario.Text, txtContraseña.Text, txtConfirmar.Text, true);
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
        private void rellenarTxt(TextBox txt)
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
        }

        private void TextBoxs_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                rellenarTxt(txt);

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
                    entry.Value.Text = errores[entry.Key];
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
            txtUsuario.Text, cambiarPassword ? txtContraseña.Text : "", cambiarPassword ? txtConfirmar.Text : "", false);

            if (!panelCambiarContraseña.Visible)
            {
                errores.Remove("txtContraseña");
                errores.Remove("txtConfirmar");
            }

            if (panelCambiarContraseña.Visible &&
                !string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                usuario.password = PasswordHasher.ToSha256(txtContraseña.Text);
            }


            MostrarError(labelsError, errores);

            if (errores.Count > 0) return;


            if (usuario.userName != "admin" &&
                usuarioController.ExisteUsuario(txtUsuario.Text) && txtUsuario.Text != usuario.userName)
            {
                labelsError["txtUsuario"].Text = "Este nombre de usuario ya está en uso.";
                labelsError["txtUsuario"].Visible = true;
                return;
            }

            if (usuarioController.ExisteDocumento(txtDocumento.Text) &&
                txtDocumento.Text != usuarioLogueado.identificacion && txtDocumento.Text != usuario.identificacion)
            {
                labelsError["txtDocumento"].Text = "Este documento ya está registrado.";
                labelsError["txtDocumento"].Visible = true;
                return;
            }
            usuario.nombre = txtNombre.Text;
            usuario.telefono = txtTelefono.Text;
            usuario.identificacion = txtDocumento.Text;
            usuario.correo = txtCorreo.Text;
            usuario.userName = txtUsuario.Text;
            usuario.rol = (Rol)cbRol.SelectedItem;

            usuarioController.EditarUsuario(usuario, usuario.id);
            MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            panelCambiarContraseña.Visible = !panelCambiarContraseña.Visible;

            if (!panelCambiarContraseña.Visible)
            {
                txtContraseña.Text = "Ingrese la contraseña";
                txtConfirmar.Text = "Confirma la contraseña";
            }

        }

        
    }
}
