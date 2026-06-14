using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Facturas
{
    public partial class BuscadorCotizacionesForm : Form
    {
        private CotizacionController cotizacionController = new CotizacionController();
        public Cotizacion CotizacionSeleccionada;


        public BuscadorCotizacionesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        private void cargarEnTabla(List<Cotizacion> cotizaciones)
        {
            tablaCotizaciones.Rows.Clear();
            var cotizacionesActivas = cotizaciones.Where(c => c.estado == true).ToList();

            foreach (var c in cotizacionesActivas)
            {

                tablaCotizaciones.Rows.Add(
                    c.id,
                    c.cliente.nombre,
                    c.cliente.identificacion,
                    c.total.ToString("F2"),
                    c.estado ? "Activo" : "Inactivo",
                    c.fecha.ToString("dd/MM/yyyy")
                );
            }
        }
        private void CargarCotizaciones()
        {
            var cotizaciones = cotizacionController.ObtenerCotizaciones();
            cargarEnTabla(cotizaciones);

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
        }

        private void BuscadorCotizacionesForm_Load(object sender, EventArgs e)
        {
            tablaCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CargarCotizaciones();
            EstilizarTabla();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.ToLower();
            var cotizacionesFiltradas = cotizacionController.buscador(filtro);
            cargarEnTabla(cotizacionesFiltradas);
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            var cotizacionesFiltradas = cotizacionController.filtrarPorFechas(fechaInicio.Value, fechaFin.Value);
            cargarEnTabla(cotizacionesFiltradas);
        }

        private void fechaFin_ValueChanged(object sender, EventArgs e)
        {
            fechaFin.MinDate = fechaInicio.Value.Date;

            if (fechaFin.Value < fechaInicio.Value)
            {
                fechaFin.Value = fechaInicio.Value;
            }
        }

        private void tablaCotizaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            var id = tablaCotizaciones.Rows[e.RowIndex].Cells[0].Value.ToString();

            CotizacionSeleccionada = cotizacionController.ObtenerCotizaciones()
                .FirstOrDefault(c => c.id == id);

            if (CotizacionSeleccionada != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tablaCotizaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaCotizaciones.Columns[e.ColumnIndex].Name == "Estado")
            {
                string estado = e.Value?.ToString();

                if (estado == "Activo")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (estado == "Inactivo")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }
    }
}
