using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Cotizaciones
{
    public partial class CotizacionesForm : Form
    {
        private CotizacionController cotizacionController = new CotizacionController();
        private ClienteController clienteController = new ClienteController();
        private List<Cotizacion> cotizaciones;

        public CotizacionesForm()
        {
            InitializeComponent();
        }

        private void CargarCotizaciones()
        {

            tablaCotizaciones.Rows.Clear();

            var clientes = clienteController.ObtenerClientes();
            var cotizaciones = cotizacionController.ObtenerCotizaciones();

            foreach (var c in cotizaciones)
            {
                var cliente = clientes.FirstOrDefault(cliente => cliente.id == c.cliente.id);

                tablaCotizaciones.Rows.Add(
                    c.id,
                    cliente != null ? cliente.nombre : "Sin cliente",
                    c.terreno.nombre,
                    c.material.nombre,
                    c.fecha.ToString("dd/MM/yyyy"),
                    c.costoTotal.ToString("F2"),
                    c.estado ? "Activo" : "Inactivo"
                );
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAddCotizacion frm = new FormAddCotizacion();

            frm.ShowDialog();

            CargarCotizaciones();
        }
        private void EstilizarTabla()
        {
            tablaCotizaciones.BackgroundColor = Color.White;
            tablaCotizaciones.BorderStyle = BorderStyle.None;
            tablaCotizaciones.RowHeadersVisible = false;
            tablaCotizaciones.AllowUserToAddRows = false;
            tablaCotizaciones.EnableHeadersVisualStyles = false;

            tablaCotizaciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablaCotizaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaCotizaciones.GridColor = Color.FromArgb(220, 220, 220);

            tablaCotizaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            tablaCotizaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tablaCotizaciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            tablaCotizaciones.DefaultCellStyle.BackColor = Color.White;
            tablaCotizaciones.DefaultCellStyle.ForeColor = Color.Black;
            tablaCotizaciones.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            tablaCotizaciones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            tablaCotizaciones.DefaultCellStyle.SelectionForeColor = Color.Black;

            tablaCotizaciones.RowTemplate.Height = 36;
            tablaCotizaciones.ColumnHeadersHeight = 34;

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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = FechaInicio.Value.Date;
            DateTime fechaFin = FechaFin.Value.Date.AddDays(1).AddSeconds(-1);

            var cotizacionesFiltradas = cotizaciones
                .Where(c => c.fecha >= fechaInicio && c.fecha <= fechaFin)
                .ToList();

            tablaCotizaciones.Rows.Clear();

            foreach (var c in cotizacionesFiltradas)
            {
                tablaCotizaciones.Rows.Add(
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

            tablaCotizaciones.Rows.Clear();

            foreach (var c in resultado)
            {
                tablaCotizaciones.Rows.Add(
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

            string id = tablaCotizaciones.Rows[e.RowIndex].Cells[0].Value.ToString();

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

        private void CotizacionesForm_Load(object sender, EventArgs e)
        {
            EstilizarTabla();
            CargarCotizaciones();
        }
    }
}
