using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Utils;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views
{
    public partial class AgregarFacturaForm : Form
    {
        private CotizacionController cotizacionController = new CotizacionController();
        private FacturaController facturaController = new FacturaController();
        private ControlsUtils resizer;
        public AgregarFacturaForm()
        {
            InitializeComponent();
            this.resizer = new ControlsUtils(this);
            txtId.Text = facturaController.obtenerId();
            txtId.ForeColor = Color.DarkBlue;
        }

        private void ConfigurarDGV()
        {
            dtvgItems.EnableHeadersVisualStyles = false;
            dtvgItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 70, 130);
            dtvgItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtvgItems.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            dtvgItems.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 70, 130);
            dtvgItems.DefaultCellStyle.Font = new Font("Arial", 9F);
            dtvgItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 255);
            dtvgItems.GridColor = Color.FromArgb(200, 210, 230);
            Total.DefaultCellStyle.Format = "C2";
            PrecioUnitario.DefaultCellStyle.Format = "N2";
        }
        private void AgregarFacturaForm_Load(object sender, EventArgs e)
        {
            dtvgItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigurarDGV();
            dtvgItems.Rows.Add();
            dtvgItems.Columns["Total"].ReadOnly = true;
            cargarCombox();
        }

        private void cargarCombox()
        {
            List<Cotizacion> cotizaciones = cotizacionController.ObtenerCotizaciones();
            cbCotizaciones.DataSource = null;
            cbCotizaciones.DataSource = cotizaciones;
            cbCotizaciones.DisplayMember = "Id";
            cbCotizaciones.ValueMember = "id";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cbCotizaciones.SelectedItem is not Cotizacion cotizacion)
            {
                MessageBox.Show("Selecciona una cotización primero.");
                return;
            }


            txtNombre.Text = cotizacion.cliente?.nombre ?? "";
            txtIdentificacion.Text = cotizacion.cliente?.identificacion ?? "";
            txtCorreo.Text = cotizacion.cliente?.correo ?? "";
            txtTelefono.Text = cotizacion.cliente?.telefono ?? "";


            dtvgItems.Rows.Clear();

            string descripcion = cotizacion.terreno.operacion switch
            {
                TipoOperacion.Remover => "Excavación y retiro de material - " + cotizacion.terreno.nombre,
                TipoOperacion.Rellenar => "Relleno de material - " + cotizacion.terreno.nombre,
                TipoOperacion.Ambos => "Movimiento de tierra - " + cotizacion.terreno.nombre,
                _ => cotizacion.terreno.nombre
            };

            int i = dtvgItems.Rows.Add();
            dtvgItems.Rows[i].Cells["Descripcion"].Value = descripcion;
            dtvgItems.Rows[i].Cells["PrecioUnitario"].Value = cotizacion.material.precioUnidad;
            dtvgItems.Rows[i].Cells["Material"].Value = cotizacion.material.nombre;
            dtvgItems.Rows[i].Cells["Volumen"].Value = cotizacion.terreno.volumen;
            dtvgItems.Rows[i].Cells["Total"].Value = cotizacion.material.precioUnidad * cotizacion.terreno.volumen;

            ActualizarTotales();

        }

        private void ActualizarTotales()
        {
            double subtotal = 0;
            foreach (DataGridViewRow row in dtvgItems.Rows)
            {
                if (row.IsNewRow) continue;
                if (double.TryParse(row.Cells["Total"].Value?.ToString(), out double t))
                    subtotal += t;
            }

            double iva = subtotal * 0.19;
            double total = subtotal + iva;

            lblSubtotal.Text = $"Subtotal:     {subtotal.ToString("C2")}";
            lblIva.Text = $"Iva (19%):     {iva.ToString("C2")}";
            lblTotal.Text = $" TOTAL:    {total.ToString("C2")}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbCotizaciones.SelectedItem is not Cotizacion cotizacion)
            {
                MessageBox.Show("Selecciona una cotización primero.");
                return;
            }

            double subtotal = 0;
            foreach (DataGridViewRow row in dtvgItems.Rows)
            {
                if (row.IsNewRow) continue;
                if (double.TryParse(row.Cells["Total"].Value?.ToString(), out double t))
                    subtotal += t;
            }
            double iva = subtotal * 0.19;
            double total = subtotal + iva;

            Factura factura = new Factura(txtId.Text, dtpFecha.Value, cotizacion, iva, subtotal, total, txtObservaciones.Text);
            facturaController.AgregarFactura(factura);

            using var sfd = new SaveFileDialog
            {
                Filter = "PDF|*.pdf",
                FileName = $"Factura_{factura.id}.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                new GeneradorFacturaPDF(factura, dtvgItems).Exportar(sfd.FileName);
                MessageBox.Show("Factura guardada y PDF generado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Factura guardada sin PDF.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgregarFacturaForm_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
