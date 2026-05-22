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
            cargarClientes();
            tablaClientes.AutoGenerateColumns = false;


        }

        private void cargarClientes()
        {
            clienteLista = clienteController.ObtenerClientes();

            tablaClientes.Columns["ID"].DataPropertyName = "id";
            tablaClientes.Columns["Nombre"].DataPropertyName = "nombre";
            tablaClientes.Columns["Identificacion"].DataPropertyName = "identificacion";
            tablaClientes.Columns["Telefono"].DataPropertyName = "telefono";
            tablaClientes.Columns["Correo"].DataPropertyName = "correo";
            tablaClientes.Columns["Accion"].DataPropertyName = "id"; // Usamos el ID para identificar la fila a editar

            tablaClientes.DataSource = null;
            tablaClientes.DataSource = clienteLista;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = clienteController.ObtenerSiguienteId();

            Cliente cliente = new Cliente(id, txtNombre.Text, txtIdentificacion.Text, txtTelefono.Text, txtCorreo.Text);

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
                     c.identificacion.ToLower().Contains(busqueda) ||
                     c.telefono.ToLower().Contains(busqueda) ||
                     c.correo.ToLower().Contains(busqueda)
            ).ToList();
            tablaClientes.DataSource = null;
            tablaClientes.DataSource = filtradros;



        }

        private void Form_prueba_Load(object sender, EventArgs e)
        {

        }

        private void Form_prueba_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
