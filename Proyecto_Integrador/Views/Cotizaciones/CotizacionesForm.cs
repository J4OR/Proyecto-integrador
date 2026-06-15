using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;
using Proyecto_Integrador.Views.Utils;
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
        private Usuario usuarioLogueado;
        private ControlsUtils resize;

        public CotizacionesForm(Usuario usuario)
        {
            InitializeComponent();
            this.resize = new ControlsUtils(this);
            this.usuarioLogueado = usuario;
            tablaCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cargarEnTabla(List<Cotizacion> cotizaciones)
        {
            tablaCotizaciones.Rows.Clear();

            var clientes = clienteController.ObtenerClientes();


            foreach (var c in cotizaciones)
            {
                var cliente = clientes.FirstOrDefault(cliente => cliente.id == c.cliente.id);

                tablaCotizaciones.Rows.Add(
                    c.id,
                    cliente != null ? cliente.nombre : "Sin cliente",
                    cliente != null ? cliente.identificacion : null,
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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCotizacionForm agregar = new AgregarCotizacionForm();

            agregar.ShowDialog();

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
        }


        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            var cotizacionesFiltradas = cotizacionController.filtrarPorFechas(fechaInicio.Value, fechaFin.Value);
            cargarEnTabla(cotizacionesFiltradas);
        }



        private void tablaCotizaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Cotizacion cotizacionSeleccionada = (Cotizacion)tablaCotizaciones.Rows[e.RowIndex].Tag;

            if (tablaCotizaciones.Columns[e.ColumnIndex].Name == "Accion")
            {
                string mensaje = cotizacionSeleccionada.estado
                    ? "¿Seguro que quiere desactivar esta factura?"
                    : "¿Seguro que quiere activar esta factura?";

                DialogResult respuesta = MessageBox.Show(mensaje, "Cambiar estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                if (respuesta == DialogResult.OK)
                {
                    bool nuevoEstado = !cotizacionSeleccionada.estado;

                    cotizacionController.CambiarEstado(cotizacionSeleccionada.id, nuevoEstado);

                    CargarCotizaciones();
                }
            }
        }

        private void CotizacionesForm_Load(object sender, EventArgs e)
        {
            EstilizarTabla();
            CargarCotizaciones();
            if (usuarioLogueado.rol == Rol.Administrador)
            {
                tablaCotizaciones.Columns["Accion"].Visible = true;
            }
            else
            {
                tablaCotizaciones.Columns["Accion"].Visible = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.ToLower();
            var cotizacionesFiltradas = cotizacionController.buscador(filtro);
            cargarEnTabla(cotizacionesFiltradas);
        }

        private void FechaFin_ValueChanged(object sender, EventArgs e)
        {
            fechaFin.MinDate = fechaInicio.Value.Date;

            if (fechaFin.Value < fechaInicio.Value)
            {
                fechaFin.Value = fechaInicio.Value;
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

        private void CotizacionesForm_Resize(object sender, EventArgs e)
        {
            resize?.ejecutarEscalado();
        }
    }
}
