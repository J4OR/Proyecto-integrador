using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.Clientes;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views
{
    public partial class ClientesForm : Form
    {
        private ClienteController clienteController = new ClienteController();
        private ControlsUtils resize;

        public ClientesForm()
        {
            InitializeComponent();
            this.resize = new ControlsUtils(this);
        }

        private void cargarClientes()
        {
            List<Cliente> clientes = clienteController.ObtenerClientes();
            tablaClientes.AutoGenerateColumns = false;
            Id.DataPropertyName = "Id";
            Nombre.DataPropertyName = "Nombre";
            Identificacion.DataPropertyName = "Identificacion";
            Telefono.DataPropertyName = "Telefono";
            Correo.DataPropertyName = "Correo";

            tablaClientes.DataSource = null;
            tablaClientes.DataSource = clientes;

        }

        private void EstilizarTabla()
        {
            tablaClientes.BackgroundColor = Color.White;
            tablaClientes.BorderStyle = BorderStyle.None;
            tablaClientes.RowHeadersVisible = false;
            tablaClientes.AllowUserToAddRows = false;
            tablaClientes.EnableHeadersVisualStyles = false;

            tablaClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablaClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaClientes.GridColor = Color.FromArgb(220, 220, 220);

            tablaClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            tablaClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tablaClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            tablaClientes.DefaultCellStyle.BackColor = Color.White;
            tablaClientes.DefaultCellStyle.ForeColor = Color.Black;
            tablaClientes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            tablaClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            tablaClientes.DefaultCellStyle.SelectionForeColor = Color.Black;

            tablaClientes.RowTemplate.Height = 36;
            tablaClientes.ColumnHeadersHeight = 34;

            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.DefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);
            Editar.DefaultCellStyle.ForeColor = Color.White;
            Editar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 0, 64);
            Editar.DefaultCellStyle.SelectionForeColor = Color.White;
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Editar.Width = 90;

            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.DefaultCellStyle.BackColor = Color.FromArgb(80, 0, 0);
            Eliminar.DefaultCellStyle.ForeColor = Color.White;
            Eliminar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 0, 0);
            Eliminar.DefaultCellStyle.SelectionForeColor = Color.White;
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Eliminar.Width = 90;


        }
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            tablaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargarClientes();
            EstilizarTabla();

        }

        private void ClientesForm_Resize(object sender, EventArgs e)
        {
            resize?.ejecutarEscalado();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.ToLower();
             var clientesFiltrados = clienteController.Buscador(filtro);
            //List<Cliente> clientes = clienteController.ObtenerClientes();
            //var clientesFiltrados = clientes.FindAll(c => c.nombre.ToLower().Contains(filtro) ||
            //    c.identificacion.ToLower().Contains(filtro));

            tablaClientes.DataSource = null;
            tablaClientes.DataSource = clientesFiltrados;
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Cliente clienteSeleccionado = (Cliente)tablaClientes.Rows[e.RowIndex].DataBoundItem;

            if (tablaClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                EditarClienteForm editarForm = new EditarClienteForm(clienteSeleccionado);
                editarForm.ShowDialog();
                cargarClientes();
            }
            else if (tablaClientes.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    clienteController.EliminarCliente(clienteSeleccionado.id);
                    cargarClientes();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarClienteForm agregarForm = new AgregarClienteForm();
            agregarForm.ShowDialog();
            cargarClientes();
        }
    }
}
