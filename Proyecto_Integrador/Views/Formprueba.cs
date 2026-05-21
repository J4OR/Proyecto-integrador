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

        public Form_prueba()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = clienteController.ObtenerSiguienteId();

            Cliente cliente = new Cliente(id,txtNombre.Text, txtIdentificacion.Text, txtTelefono.Text, txtCorreo.Text);

            clienteController.AgregarCliente(cliente);
            MessageBox.Show("Agregado con exito!");

        }
        
    }
}
