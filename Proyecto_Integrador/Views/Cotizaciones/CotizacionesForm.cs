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
    public partial class CotizacionesForm : Form
    {
        private CotizacionController cotizacionController;
        private List<Cotizacion> cotizaciones;

        public CotizacionesForm()
        {
            InitializeComponent();

            cotizacionController = new CotizacionController();

            CargarCotizaciones();
        }

        private void CargarCotizaciones()
        {
            cotizaciones = cotizacionController.ObtenerCotizaciones();

            tablaUsuarios.Rows.Clear();

            foreach (var c in cotizaciones)
            {
                tablaUsuarios.Rows.Add(
                    c.id,
                    c.cliente.nombre,
                    c.terreno.nombre,
                    c.material.nombre,
                    c.costoTotal.ToString("F2"),
                    c.estado ? "Activa" : "Inactiva"
                );
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAddCotizacion frm = new FormAddCotizacion();

            frm.ShowDialog();

            CargarCotizaciones();
        }

        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
