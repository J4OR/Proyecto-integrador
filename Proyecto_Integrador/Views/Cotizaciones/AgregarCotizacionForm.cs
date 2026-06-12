using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Cotizaciones
{
    public partial class AgregarCotizacionForm : Form
    {
        private TerrenoController terrenoController = new TerrenoController();
        private ClienteController clienteController = new ClienteController();
        private Cliente? clienteSeleccionado;
        private List<Terreno> terrenosCliente = new List<Terreno>();
        public AgregarCotizacionForm()
        {
            InitializeComponent();
        }
        private void CargarTerrenosEnGrid()
        {
            dgvItems.Rows.Clear();
            foreach (var terreno in terrenosCliente)
            {
                string descripcion = terreno.operacion switch
                {
                    TipoOperacion.Remover => "Excavación y retiro de material - " + terreno.nombre,
                    TipoOperacion.Rellenar => "Relleno de material - " + terreno.nombre,
                    TipoOperacion.Mixto => "Movimiento de tierra - " + terreno.nombre,
                    _ => terreno.nombre
                };

                int index = dgvItems.Rows.Add();
                dgvItems.Rows[index].Cells["Descripcion"].Value = descripcion;
                dgvItems.Rows[index].Cells["Material"].Value = "";
                dgvItems.Rows[index].Cells["PrecioUnitario"].Value = "0.00";
                dgvItems.Rows[index].Cells["Volumen"].Value = terreno.volumen.ToString("F4");
                dgvItems.Rows[index].Cells["Iva"].Value = "0.00";
                dgvItems.Rows[index].Cells["Total"].Value = "0.00";
                dgvItems.Rows[index].Tag = terreno; // guardar terreno en la fila
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = clienteController.Buscar(txtIdentificacion.Text.Trim());

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Llenar textbox del cliente
            txtNombre.Text = clienteSeleccionado.nombre;
            txtIdentificacion.Text = clienteSeleccionado.identificacion;
            txtCorreo.Text = clienteSeleccionado.correo;
            txtTelefono.Text = clienteSeleccionado.telefono;

            // 3. Buscar terrenos de ese cliente
            terrenosCliente = terrenoController.ObtenerTerrenos()
                .Where(t => t.cliente.identificacion == txtIdentificacion.Text)
                .ToList();

            if (terrenosCliente.Count == 0)
            {
                MessageBox.Show("El cliente no tiene terrenos registrados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CargarTerrenosEnGrid();
        }
       
    }
}
