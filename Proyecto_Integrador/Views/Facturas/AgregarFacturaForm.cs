using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Utils;
using Proyecto_Integrador.Views.Terrenos;
using Proyecto_Integrador.Views.Utils;
using SharpDX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Facturas
{
    public partial class AgregarFacturaForm : Form
    {
        private CotizacionController cotizacionController = new CotizacionController();
        private FacturaController facturaController = new FacturaController();
        private ControlsUtils resizer;
        private string facturaDescripcion;
        private Usuario usuarioLogueado;
        private Cotizacion cotizacionSeleccionada;
        public AgregarFacturaForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
            this.resizer = new ControlsUtils(this);
            txtId.Text = facturaController.obtenerId();
            txtId.ForeColor = Color.DarkBlue;
            dtvgItems.RowTemplate.Height = 50;
            dtvgItems.ColumnHeadersHeight = 45;
            dtvgItems.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dtvgItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtvgItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            Total.DefaultCellStyle.Format = "C0";
            PrecioUnitario.DefaultCellStyle.Format = "N2";
        }
        private void AgregarFacturaForm_Load(object sender, EventArgs e)
        {
            dtvgItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigurarDGV();
            dtvgItems.Rows.Add();
            dtvgItems.Columns["Total"].ReadOnly = true;
        }

  

        private void btnCargar_Click(object sender, EventArgs e)
        {

            BuscadorCotizacionesForm form = new BuscadorCotizacionesForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                cotizacionSeleccionada = form.CotizacionSeleccionada;

                if (cotizacionSeleccionada != null)
                {
                    txtCotizacion.Text = cotizacionSeleccionada.id;

                    CargarCotizacion(cotizacionSeleccionada);
                }
            }


        }

        private void CargarCotizacion(Cotizacion cotizacion)
        {
            txtNombre.Text = cotizacion.cliente?.nombre ?? "";
            txtIdentificacion.Text = cotizacion.cliente?.identificacion ?? "";
            txtCorreo.Text = cotizacion.cliente?.correo ?? "";
            txtTelefono.Text = cotizacion.cliente?.telefono ?? "";

            dtvgItems.Rows.Clear();

            int cantidad = Math.Min(
                cotizacion.terrenos?.Count ?? 0,
                cotizacion.materiales?.Count ?? 0
            );

            if (cantidad == 0)
            {
                MessageBox.Show("La cotización no tiene materiales o terrenos.");
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                var terreno = cotizacion.terrenos[i];
                var material = cotizacion.materiales[i];

                string descripcion = terreno.operacion switch
                {
                    TipoOperacion.Excavar => "Excavación de material - " + terreno.nombre,
                    TipoOperacion.Remover => "Retiro de material - " + terreno.nombre,
                    TipoOperacion.Rellenar => "Relleno de material - " + terreno.nombre,
                    TipoOperacion.Mixto => "Movimiento de tierra - " + terreno.nombre,
                    _ => terreno.nombre
                };
                facturaDescripcion += "- " + descripcion + "\n";
                int fila = dtvgItems.Rows.Add();

                dtvgItems.Rows[fila].Cells["Descripcion"].Value = descripcion;
                dtvgItems.Rows[fila].Cells["PrecioUnitario"].Value = material.precioUnidad;
                dtvgItems.Rows[fila].Cells["Material"].Value = material.nombre;
                dtvgItems.Rows[fila].Cells["Volumen"].Value = terreno.volumen;
                dtvgItems.Rows[fila].Cells["Total"].Value = material.precioUnidad * terreno.volumen;
            }

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

            lblSubtotal.Text = $"Subtotal:     {subtotal.ToString("C0")}";
            lblIva.Text = $"Iva (19%):     {iva.ToString("C0")}";
            lblTotal.Text = $" TOTAL:    {total.ToString("C0")}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cotizacionSeleccionada == null)
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



            Factura factura = new Factura(txtId.Text, facturaDescripcion, dtpFecha.Value, cotizacionSeleccionada, Math.Round(total), Math.Round(subtotal), Math.Round(total), txtObservaciones.Text);
            facturaController.AgregarFactura(factura);

            new GeneradorFacturaPDF(factura, dtvgItems).Exportar();


            DialogResult resultado = MessageBox.Show(
                "Factura guardada y PDF generado.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            if (resultado == DialogResult.OK)
            {
                FormDashboard principal = (FormDashboard)this.ParentForm;
                principal.AbrirFormularioEnPanel(new FacturasForm(principal, usuarioLogueado));
            }

        }

        private void AgregarFacturaForm_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormDashboard principal = (FormDashboard)this.ParentForm;
            principal.AbrirFormularioEnPanel(new FacturasForm(principal,usuarioLogueado));
        }
    }
}
