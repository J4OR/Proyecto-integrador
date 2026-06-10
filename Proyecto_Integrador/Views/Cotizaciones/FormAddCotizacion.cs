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
    public partial class FormAddCotizacion : Form
    {
        private TerrenoController terrenoController;
        private List<Terreno> terrenos;

        private ClienteController clienteController;
        private List<Cliente> clienteList;

        private MaterialController materialController;
        private List<Material> materialList;

        private CotizacionController cotizacionController;

        public FormAddCotizacion()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            terrenoController = new TerrenoController();
            terrenos = terrenoController.ObtenerTerrenos();

            clienteController = new ClienteController();
            clienteList = clienteController.ObtenerClientes();

            materialController = new MaterialController();
            materialList = materialController.ObtenerMateriales();

            cotizacionController = new CotizacionController();

            foreach (var material in materialList)
            {
                BoxMaterial.Items.Add(material.nombre);
            }

            foreach (var terreno in terrenos)
            {
                comboBox2.Items.Add(terreno.nombre);
            }

            foreach (var cliente in clienteList)
            {
                BoxCliente.Items.Add(cliente.nombre);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreSeleccionado = comboBox2.Text;

            Terreno terreno = terrenos.FirstOrDefault(t => t.nombre == nombreSeleccionado);

            if (terreno != null)
            {
                textBox1.Text = terreno.volumen.ToString("F4");
            }
        }

        private void BoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCotizacion_Click(object sender, EventArgs e)
        {
            Terreno terreno = terrenos.FirstOrDefault(t => t.nombre == comboBox2.Text);
            Cliente cliente = clienteList.FirstOrDefault(c => c.nombre == BoxCliente.Text);
            Material material = materialList.FirstOrDefault(m => m.nombre == BoxMaterial.Text);

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

            CotizacionController cotizacionController = new CotizacionController();

            string id = cotizacionController.obtenerId();

            Cotizacion nuevaCotizacion = new Cotizacion(
                id,
                cliente,
                terreno,
                material
            );

            cotizacionController.AgregarCotizacion(nuevaCotizacion);

            MessageBox.Show("Cotización agregada correctamente.");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
