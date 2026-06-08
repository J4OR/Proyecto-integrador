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
    public partial class AgregarUsuarioForm : Form
    {
        private UsuarioController usuarioController = new UsuarioController();
        public AgregarUsuarioForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        private void AgregarUsuarioForm_Load(object sender, EventArgs e)
        {
            cbRol.SelectedIndex = 1;
            txtContraseña.PasswordChar = '*';
            txtConfirmar.PasswordChar = '*';
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var errores = UsuarioValidator.Validar(txtNombre.Text, txtTelefono.Text, txtIdentificacion.Text, txtCorreo.Text,
                txtUser.Text, txtContraseña.Text, txtConfirmar.Text);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores.Values), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usuarioController.ExisteUsuario(txtUser.Text))
            {
                MessageBox.Show("Este nombre de usuario ya está en uso.", "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usuarioController.ExisteDocumento(txtIdentificacion.Text))
            {
                MessageBox.Show(
                    "Este documento ya tiene un usuario registrado.", "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = usuarioController.ObtenerSiguienteId();

            Usuario nuevoUsuario = new Usuario(id, txtIdentificacion.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text,
            txtUser.Text, PasswordHasher.ToSha256(txtContraseña.Text));

            nuevoUsuario.rol = (Rol)cbRol.SelectedItem;
            nuevoUsuario.estado = true;

            usuarioController.AgregarUsuario(nuevoUsuario);

            MessageBox.Show("Usuario agregado correctamente.", "Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            char caracter = checkBoxMostrar.Checked ? '\0' : '*';

            txtContraseña.PasswordChar = caracter;
            txtConfirmar.PasswordChar = caracter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
