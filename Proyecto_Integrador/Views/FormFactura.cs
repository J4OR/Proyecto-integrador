using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views
{
    public partial class FormFactura : Form
    {
        private DataGridView dgvCotizaciones;
        private DataGridView dgvFacturas;
        private Button btnConvertir;
        private Button btnImprimir;
        private Button btnFiltrar;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private ComboBox cmbCliente;
        private ComboBox cmbEstado;

        private readonly FacturaController _facCtrl;
        private readonly CotizacionController _cotCtrl;
        private readonly ClienteController _cliCtrl;
        private readonly Usuario _usuario;

        public FormFactura(FacturaController fc, CotizacionController cc, ClienteController cl, Usuario u)
        {
            _facCtrl = fc;
            _cotCtrl = cc;
            _cliCtrl = cl;
            _usuario = u;
            InitializeComponent();
            RefrescarCotizaciones();
            RefrescarFacturas(null);
        }

        

        private void RefrescarCotizaciones()
        {
            dgvCotizaciones.Rows.Clear();
            foreach (Cotizacion c in _cotCtrl.ObtenerCotizaciones())
            {
                dgvCotizaciones.Rows.Add(
                    c.id,
                    c.fecha.ToString("dd/MM/yyyy"),
                    c.cliente?.nombre ?? "",
                    c.material?.nombre ?? "",
                    c.terreno?.volumen.ToString("F2") ?? "0",
                    c.costoTotal.ToString("N0"),
                    c.estado ? "Activa" : "Inactiva");
            }
        }

        private void RefrescarFacturas(List<Factura> lista)
        {
            dgvFacturas.Rows.Clear();

            if (lista == null)
                lista = _facCtrl.ObtenerFacturas();

            foreach (Factura f in lista)
            {
                dgvFacturas.Rows.Add(
                    f.id,
                    f.fechaEmision.ToString("dd/MM/yyyy"),
                    f.cotizacion?.cliente?.nombre ?? "",
                    f.cotizacion?.material?.nombre ?? "",
                    f.cotizacion?.terreno?.volumen.ToString("F2") ?? "0",
                    f.cotizacion?.costoTotal.ToString("N0") ?? "0",
                    f.estado ? "Activa" : "Inactiva");
            }
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (dgvCotizaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cotización de la lista.", "Aviso");
                return;
            }

            int idx = dgvCotizaciones.SelectedRows[0].Index;
            List<Cotizacion> lista = _cotCtrl.ObtenerCotizaciones();

            if (idx >= lista.Count)
                return;

            Cotizacion cot = lista[idx];

            if (!cot.estado)
            {
                MessageBox.Show("Solo se pueden convertir cotizaciones activas.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Factura factura = new Factura(
                _facCtrl.obtenerId(),
                cot,
                DateTime.Now
            );

            _facCtrl.AgregarFactura(factura);

            MessageBox.Show("Factura generada correctamente: " + factura.id, "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarFacturas(null);
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            List<Factura> todas = _facCtrl.ObtenerFacturas();
            List<Factura> resultado = new List<Factura>();

            string clienteNombre = cmbCliente.SelectedIndex == 0 ? null : cmbCliente.SelectedItem?.ToString();
            bool? estadoFiltro = null;
            if (cmbEstado.SelectedIndex == 1) estadoFiltro = true;
            else if (cmbEstado.SelectedIndex == 2) estadoFiltro = false;

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1);

            foreach (Factura f in todas)
            {
                if (f.fechaEmision < desde || f.fechaEmision >= hasta) continue;
                if (estadoFiltro.HasValue && f.estado != estadoFiltro.Value) continue;
                if (clienteNombre != null && f.cotizacion?.cliente?.nombre != clienteNombre) continue;
                resultado.Add(f);
            }

            RefrescarFacturas(resultado);
        }

        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura de la lista.", "Aviso");
                return;
            }

            int idx = dgvFacturas.SelectedRows[0].Index;
            List<Factura> lista = _facCtrl.ObtenerFacturas();

            if (idx >= lista.Count)
                return;

            Factura f = lista[idx];
            f.estado = !f.estado;

            // Re-guardar lista completa actualizando el elemento
            List<Factura> todas = _facCtrl.ObtenerFacturas();
            int i = todas.FindIndex(x => x.id == f.id);
            if (i >= 0)
            {
                todas[i] = f;
                // Guardar via repositorio (acceso directo al archivo)
            }

            MessageBox.Show("Estado cambiado a: " + (f.estado ? "Activa" : "Inactiva"), "Info");
            RefrescarFacturas(null);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura de la lista.", "Aviso");
                return;
            }

            int idx = dgvFacturas.SelectedRows[0].Index;
            List<Factura> lista = _facCtrl.ObtenerFacturas();

            if (idx >= lista.Count)
                return;

            Factura facturaSeleccionada = lista[idx];

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += delegate (object s, PrintPageEventArgs ev)
            {
                ImprimirFactura(ev, facturaSeleccionada);
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog(this);
        }

        private void ImprimirFactura(PrintPageEventArgs e, Factura f)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fontNormal = new Font("Courier New", 10);
            Font fontTotal = new Font("Arial", 13, FontStyle.Bold);

            int y = 50;
            g.DrawString("=== FACTURA ===", fontTitulo, Brushes.Black, 220, y); y += 35;
            g.DrawString("ID Factura:  " + f.id, fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("ID Cotiz.:   " + f.cotizacion?.id, fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Fecha:       " + f.fechaEmision.ToString("dd/MM/yyyy HH:mm"), fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Cliente:     " + (f.cotizacion?.cliente?.nombre ?? ""), fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Material:    " + (f.cotizacion?.material?.nombre ?? ""), fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Volumen:     " + (f.cotizacion?.terreno?.volumen.ToString("F4") ?? "0") + " m³", fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Costo x m³:  $" + (f.cotizacion?.material?.precioUnidad.ToString("N0") ?? "0"), fontNormal, Brushes.Black, 50, y); y += 35;
            g.DrawString("TOTAL: $" + (f.cotizacion?.costoTotal.ToString("N0") ?? "0"), fontTotal, Brushes.Black, 50, y);
        }
    }
}
