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
    public partial class EditarClienteForm : Form
    {
        private ClienteController clienteController = new ClienteController();
        private Cliente cliente;

        public EditarClienteForm(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void cargarDatos()
        {
            txtNombre.Text = cliente.nombre;
            txtTelefono.Text = cliente.telefono;
            txtIdentificacion.Text = cliente.identificacion;
            txtCorreo.Text = cliente.correo;
        }
        private void EditarClienteForm_Load(object sender, EventArgs e)
        {
            cargarDatos();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var errores = ClienteValidator.Validar(txtNombre.Text, txtTelefono.Text, txtIdentificacion.Text, txtCorreo.Text);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores.Values), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cliente.nombre = txtNombre.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.identificacion = txtIdentificacion.Text;
            cliente.correo = txtCorreo.Text;

            clienteController.EditarCliente(cliente, cliente.id);
            MessageBox.Show("Cliente actualizado correctamente.", "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
