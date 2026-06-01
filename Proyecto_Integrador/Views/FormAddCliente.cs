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

        public Form_prueba(Usuario usuario)
        {
            InitializeComponent();
            //tablaClientes.AutoGenerateColumns = false;
            tablaClientes.Columns["Id"].DataPropertyName = "id";
            tablaClientes.Columns["Nombre"].DataPropertyName = "nombre";
            tablaClientes.Columns["Identificacion"].DataPropertyName = "identificacion";
            tablaClientes.Columns["Telefono"].DataPropertyName = "telefono";
            tablaClientes.Columns["Correo"].DataPropertyName = "correo";
            tablaClientes.Columns["Accion"].DataPropertyName = "accion";
            cargarClientes();

        }

        private void cargarClientes()
        {
            clienteLista = clienteController.ObtenerClientes();


            //tablaClientes.Columns["ID"].DataPropertyName = "id";
            //tablaClientes.Columns["Nombre"].DataPropertyName = "nombre";
            //tablaClientes.Columns["Identificacion"].DataPropertyName = "identificacion";
            //tablaClientes.Columns["Telefono"].DataPropertyName = "telefono";
            //tablaClientes.Columns["Correo"].DataPropertyName = "correo";
            //tablaClientes.Columns["Accion"].DataPropertyName = "accion"; // Usamos el ID para identificar la fila a editar

            // Usamos el ID para identificar la fila a editar


            //tablaClientes.DataSource = null;
            tablaClientes.DataSource = null;
            tablaClientes.DataSource = clienteLista;
            //tablaClientes.DataSource = clienteLista;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = clienteController.ObtenerSiguienteId();

            Cliente cliente = new Cliente(id, txtIdentificacion.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text);

            clienteController.AgregarCliente(cliente);
            MessageBox.Show("Agregado con exito!");
            cargarClientes();
        }


        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tablaClientes.Columns[e.ColumnIndex].Name == "Accion")
            {
                var idCliente = int.Parse(tablaClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                EditarForm editarForm = new EditarForm(idCliente);
                if (editarForm.ShowDialog() == DialogResult.OK)
                {
                    cargarClientes();
                }
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscador.Text.ToLower();

            var filtradros = clienteLista.Where(
                c => c.nombre.ToLower().Contains(busqueda) ||
                     c.identificacion.ToLower().Contains(busqueda)
            ).ToList();
            tablaClientes.DataSource = null;
            tablaClientes.DataSource = filtradros;

            Id.DisplayIndex = 0;
            Nombre.DisplayIndex = 1;
            Identificacion.DisplayIndex = 2;
            Telefono.DisplayIndex = 3;
            Correo.DisplayIndex = 4;
            Accion.DisplayIndex = 5;
        }

        private void Form_prueba_Load(object sender, EventArgs e)
        {
           

        }

        private void Form_prueba_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
