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
    public partial class ClientesForm : Form
    {
        private ClienteController clienteController = new ClienteController();

        public ClientesForm()
        {
            InitializeComponent();
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
        }
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            cargarClientes();
            EstilizarTabla();

        }
    }
}
