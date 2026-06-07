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

namespace Proyecto_Integrador.Views.Clientes
{
    public partial class AgregarClienteForm : Form
    {
        private ClienteController clienteController = new ClienteController();
        private ClienteValidator clienteValidator = new ClienteValidator();
        public AgregarClienteForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var errores = ClienteValidator.Validar(txtNombre.Text, txtTelefono.Text, txtIdentificacion.Text, txtCorreo.Text);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores.Values), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clienteController.ExisteCliente(txtIdentificacion.Text))
            {
                MessageBox.Show("El número de identificación ya existe. Por favor, ingrese otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = clienteController.ObtenerSiguienteId();
            Cliente nuevoCliente = new Cliente(id, txtIdentificacion.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text);

            clienteController.AgregarCliente(nuevoCliente);

            MessageBox.Show("Cliente agregado correctamente.", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
