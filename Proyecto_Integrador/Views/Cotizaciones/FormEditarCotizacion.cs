using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views.Cotizaciones
{
    public partial class FormEditarCotizacion : Form
    {
        private TerrenoController terrenoController;
        private List<Terreno> terrenos;

        private ClienteController clienteController;
        private List<Cliente> clienteList;

        private MaterialController materialController;
        private List<Material> materialList;

        private CotizacionController cotizacionController;
        private Cotizacion cotizacionActual;

        public FormEditarCotizacion(Cotizacion cotizacion)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            cotizacionActual = cotizacion;

            terrenoController = new TerrenoController();
            terrenos = terrenoController.ObtenerTerrenos();

            clienteController = new ClienteController();
            clienteList = clienteController.ObtenerClientes();

            materialController = new MaterialController();
            materialList = materialController.ObtenerMateriales();

            cotizacionController = new CotizacionController();

            foreach (var material in materialList)
                cmbMaterial.Items.Add(material.nombre);

            foreach (var terreno in terrenos)
                cmbTerreno.Items.Add(terreno.nombre);

            foreach (var cliente in clienteList)
                cmbCliente.Items.Add(cliente.nombre);

            // Pre-seleccionar valores actuales
            cmbCliente.SelectedItem = cotizacion.cliente.nombre;
            cmbTerreno.SelectedItem = cotizacion.terreno.nombre;
            cmbMaterial.SelectedItem = cotizacion.material.nombre;
            txtVolumen.Text = cotizacion.terreno.volumen.ToString("F4");
        }

        private void cmbTerreno_SelectedIndexChanged(object sender, EventArgs e)
        {
            Terreno terreno = terrenos.FirstOrDefault(t => t.nombre == cmbTerreno.Text);
            if (terreno != null)
                txtVolumen.Text = terreno.volumen.ToString("F4");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Terreno terreno = terrenos.FirstOrDefault(t => t.nombre == cmbTerreno.Text);
            Cliente cliente = clienteList.FirstOrDefault(c => c.nombre == cmbCliente.Text);
            Material material = materialList.FirstOrDefault(m => m.nombre == cmbMaterial.Text);

            if (terreno == null)
            {
                MessageBox.Show("Seleccione un terreno.");
                return;
            }
            if (cliente == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            if (material == null)
            {
                MessageBox.Show("Seleccione un material.");
                return;
            }

            cotizacionActual.cliente = cliente;
            cotizacionActual.terreno = terreno;
            cotizacionActual.material = material;
            cotizacionActual.costoTotal = material.precioUnidad * terreno.volumen;

            cotizacionController.ActualizarCotizacion(cotizacionActual);

            MessageBox.Show("Cotización actualizada correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
