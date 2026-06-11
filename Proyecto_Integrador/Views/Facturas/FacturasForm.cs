using Microsoft.VisualBasic.ApplicationServices;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Utils;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Integrador.Views.Facturas
{
    public partial class FacturasForm : Form
    {
        private FacturaController facturaController = new FacturaController();
        private ControlsUtils resizer;
        private FormDashboard formularioPrincipal;

        public FacturasForm(FormDashboard formulario)
        {
            InitializeComponent();
            this.formularioPrincipal = formulario;
            this.resizer = new ControlsUtils(this);
        }
        private void cargarFacturas()
        {
            List<Factura> facturas = facturaController.ObtenerFacturas();
            tablaFacturas.AutoGenerateColumns = false;
            Id.DataPropertyName = "Id";
            Cliente.DataPropertyName = "IdentificacionCliente";
            Descripcion.DataPropertyName = "Descripcion";
            Total.DataPropertyName = "Total";
            Estado.DataPropertyName = "EstadoNmbre";
            Fecha.DataPropertyName = "Fecha";

            tablaFacturas.DataSource = null;
            tablaFacturas.DataSource = facturas;

        }

        private void EstilizarTabla()
        {
            tablaFacturas.BackgroundColor = Color.White;
            tablaFacturas.BorderStyle = BorderStyle.None;
            tablaFacturas.RowHeadersVisible = false;
            tablaFacturas.AllowUserToAddRows = false;
            tablaFacturas.EnableHeadersVisualStyles = false;

            tablaFacturas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablaFacturas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaFacturas.GridColor = Color.FromArgb(220, 220, 220);

            tablaFacturas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            tablaFacturas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tablaFacturas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            tablaFacturas.DefaultCellStyle.BackColor = Color.White;
            tablaFacturas.DefaultCellStyle.ForeColor = Color.Black;
            tablaFacturas.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            tablaFacturas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            tablaFacturas.DefaultCellStyle.SelectionForeColor = Color.Black;

            tablaFacturas.RowTemplate.Height = 36;
            tablaFacturas.ColumnHeadersHeight = 34;

            Ver.Text = "Ver";
            Ver.UseColumnTextForButtonValue = true;
            Ver.FlatStyle = FlatStyle.Flat;
            Ver.DefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);
            Ver.DefaultCellStyle.ForeColor = Color.White;
            Ver.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 0, 64);
            Ver.DefaultCellStyle.SelectionForeColor = Color.White;
            Ver.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ver.Width = 90;
        }

        private void FacturasForm_Load(object sender, EventArgs e)
        {
            tablaFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargarFacturas();
            EstilizarTabla();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.ToLower();
            var facturasFiltradas = facturaController.buscador(filtro);

            tablaFacturas.DataSource = null;
            tablaFacturas.DataSource = facturasFiltradas;
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DateTime desde = fechaFin.Value;
            DateTime hasta = fechaInicio.Value;
            var facturaFiltradas = facturaController.filtrarPorFechas(desde, hasta);

            tablaFacturas.DataSource = null;
            tablaFacturas.DataSource = facturaFiltradas;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarFacturas();
        }

        private void FacturasForm_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();
        }

        private void fechaFin_ValueChanged(object sender, EventArgs e)
        {
            fechaFin.MinDate = fechaInicio.Value.Date;

            if (fechaFin.Value < fechaInicio.Value)
            {
                fechaFin.Value = fechaInicio.Value;
            }
        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            formularioPrincipal.AbrirFormularioEnPanel(new AgregarFacturaForm());
        }

        private void tablaFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Factura facturaSeleccionada = (Factura)tablaFacturas.Rows[e.RowIndex].DataBoundItem;

            if (tablaFacturas.Columns[e.ColumnIndex].Name == "Accion")
            {
                string mensaje = facturaSeleccionada.estado
                    ? "¿Seguro que quiere desactivar esta factura?"
                    : "¿Seguro que quiere activar esta factura?";

                DialogResult respuesta = MessageBox.Show(mensaje, "Cambiar estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                if (respuesta == DialogResult.OK)
                {
                    bool nuevoEstado = !facturaSeleccionada.estado;

                    facturaController.cambiarEstado(facturaSeleccionada.id, nuevoEstado);

                    cargarFacturas();
                }

            }
        
        }
    }
}
