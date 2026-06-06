using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Integrador.Views.Usuarios
{
    public partial class EditarUsuarioForm : Form
    {
        private Usuario usuario;
        private UsuarioController usuarioController = new UsuarioController();
        private Usuario usuarioLogueado;
        public EditarUsuarioForm(Usuario usuario, Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.usuario = usuario;
            this.usuarioLogueado = usuarioLogueado;
        }

        private void cargarDatos()
        {
            txtNombre.Text = usuario.nombre;
            txtTelefono.Text = usuario.telefono;
            txtIdentificacion.Text = usuario.identificacion;
            txtCorreo.Text = usuario.correo;
            txtUser.Text = usuario.userName;
            cbRol.SelectedItem = usuario.rol;
        }

        private void EditarUsuarioForm_Load(object sender, EventArgs e)
        {
            cbRol.DataSource = Enum.GetValues(typeof(Rol));

            panelCambiarContraseña.Visible = false;
            txtContraseña.PasswordChar = '*';
            txtConfirmar.PasswordChar = '*';

            if (usuarioLogueado.id == usuario.id)
            {
                lblRol.Visible = false;
                cbRol.Visible = false;
            }

            cargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var errores = UsuarioValidator.validarEdicion(txtNombre.Text, txtTelefono.Text, txtIdentificacion.Text,
            txtCorreo.Text, txtUser.Text);

            if (panelCambiarContraseña.Visible)
            {
                var erroresContraseña = UsuarioValidator.ValidarContraseña(txtContraseña.Text, txtConfirmar.Text);

                foreach (var error in erroresContraseña)
                {
                    errores[error.Key] = error.Value;
                }
            }

            if (errores.Count > 0)
            {
                string mensajeErrores = string.Join("\n", errores.Values);

                MessageBox.Show(mensajeErrores, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            usuario.nombre = txtNombre.Text;
            usuario.telefono = txtTelefono.Text;
            usuario.identificacion = txtIdentificacion.Text;
            usuario.correo = txtCorreo.Text;
            usuario.userName = txtUser.Text;
            usuario.rol = (Rol)cbRol.SelectedItem;

            if (panelCambiarContraseña.Visible)
            {
                usuario.password = txtContraseña.Text;
            }

            usuarioController.EditarUsuario(usuario, usuario.id);

            MessageBox.Show("Usuario actualizado correctamente.", "Editar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            char caracter = checkBoxMostrar.Checked ? '\0' : '*';
            txtContraseña.PasswordChar = caracter;
            txtConfirmar.PasswordChar = caracter;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            panelCambiarContraseña.Visible = !panelCambiarContraseña.Visible;
            if (!panelCambiarContraseña.Visible)
            {
                txtContraseña.Clear();
                txtConfirmar.Clear();
                checkBoxMostrar.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
