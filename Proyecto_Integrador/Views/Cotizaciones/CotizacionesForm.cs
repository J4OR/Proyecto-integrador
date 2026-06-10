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

            tablaFacturas.Rows.Clear();

            foreach (var c in cotizaciones)
            {
                tablaFacturas.Rows.Add(
                    c.id,
                    c.fecha.ToString("dd/MM/yyyy"),
                    c.cliente.nombre,
                    c.terreno.nombre,
                    c.material.nombre,
                    c.costoTotal.ToString("F2"),
                    c.estadoTexto

                );
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAddCotizacion frm = new FormAddCotizacion();

            frm.ShowDialog();

            CargarCotizaciones();
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = FechaInicio.Value.Date;
            DateTime fechaFin = FechaFin.Value.Date.AddDays(1).AddSeconds(-1);

            var cotizacionesFiltradas = cotizaciones
                .Where(c => c.fecha >= fechaInicio && c.fecha <= fechaFin)
                .ToList();

            tablaFacturas.Rows.Clear();

            foreach (var c in cotizacionesFiltradas)
            {
                tablaFacturas.Rows.Add(
                    c.id,
                    c.cliente.nombre,
                    c.terreno.nombre,
                    c.material.nombre,
                    c.costoTotal.ToString("F2"),
                    c.fecha.ToString("dd/MM/yyyy"),
                    c.estado ? "Activa" : "Inactiva"
                );
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();

            DateTime fechaInicio = FechaInicio.Value.Date;
            DateTime fechaFin = FechaFin.Value.Date.AddDays(1).AddSeconds(-1);

            var resultado = cotizaciones.Where(c =>
                c.fecha >= fechaInicio &&
                c.fecha <= fechaFin &&
                (
                    c.id.ToLower().Contains(texto) ||
                    c.cliente.nombre.ToLower().Contains(texto) ||
                    c.terreno.nombre.ToLower().Contains(texto) ||
                    c.material.nombre.ToLower().Contains(texto)
                )
            ).ToList();

            tablaFacturas.Rows.Clear();

            foreach (var c in resultado)
            {
                tablaFacturas.Rows.Add(
                    c.id,
                    c.cliente.nombre,
                    c.terreno.nombre,
                    c.material.nombre,
                    c.costoTotal.ToString("F2"),
                    c.fecha.ToString("dd/MM/yyyy"),
                    c.estado ? "Activa" : "Inactiva"
                );
            }
        }

        private void tablaCotizaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string id = tablaFacturas.Rows[e.RowIndex].Cells[0].Value.ToString();

            // Recargar la lista desde el JSON
            cotizaciones = cotizacionController.ObtenerCotizaciones();

            Cotizacion cotizacionSeleccionada =
                cotizaciones.FirstOrDefault(c => c.id == id);

            if (cotizacionSeleccionada == null)
            {
                MessageBox.Show("No se encontró la cotización con ID: " + id);
                return;
            }

            bool nuevoEstado = !cotizacionSeleccionada.estado;

            cotizacionController.CambiarEstado(id, nuevoEstado);

            MessageBox.Show(
                nuevoEstado
                ? "Cotización activada."
                : "Cotización desactivada."
            );

            CargarCotizaciones();
        }
    }
}
