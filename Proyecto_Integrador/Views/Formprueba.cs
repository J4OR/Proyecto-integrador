using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views
{
    public partial class Form_prueba : Form
    {
        ClienteController clienteController = new ClienteController();
        private List<Cliente> clienteLista = new List<Cliente>();

        public Form_prueba()
        {
            InitializeComponent();
            cargarClientes();
        }

        private void cargarClientes()
        {
            clienteLista = clienteController.ObtenerClientes();
            tablaClientes.Columns["ID"].DataPropertyName = "ID";
            tablaClientes.Columns["Nombre"].DataPropertyName = "Nombre";
            tablaClientes.Columns["Identificacion"].DataPropertyName = "Identificacion";
            tablaClientes.Columns["Telefono"].DataPropertyName = "Telefono";
            tablaClientes.Columns["Correo"].DataPropertyName = "Correo";    
            tablaClientes.DataSource = null;
            tablaClientes.DataSource = clienteLista;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = clienteController.ObtenerSiguienteId();

            Cliente cliente = new Cliente(id,txtNombre.Text, txtIdentificacion.Text, txtTelefono.Text, txtCorreo.Text);

            clienteController.AgregarCliente(cliente);
            MessageBox.Show("Agregado con exito!");
            cargarClientes();

        }
        private void BotonEditar()
        {
        

        }

    }
}
