using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views
{
    public partial class EditarForm : Form
    {
        private int idCliente;
        ClienteController clienteController = new ClienteController();

        public EditarForm(int id)
        {
            InitializeComponent();
            this.idCliente = id;
        }

        private void cargarCliente()
        {
            List<Cliente> clientes = clienteController.ObtenerClientes();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.id == idCliente)
                {
                    txtNombre.Text = cliente.nombre;
                    txtIdentificacion.Text = cliente.identificacion;
                    txtTelefono.Text = cliente.telefono;
                    txtCorreo.Text = cliente.correo;
                    break;
                }
            }
        }
        private void EditarForm_Load(object sender, EventArgs e)
        {
            cargarCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(idCliente, txtIdentificacion.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text);
            clienteController.EditarCliente(cliente, idCliente);
            MessageBox.Show("Cliente editado con éxito!");
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
