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

namespace Proyecto_Integrador.Views.Utils
{
    public partial class FormCotizacion : Form
    {
        private ComboBox cmbCliente;
        private ComboBox cmbMaterial;
        private TextBox txtVolumen;
        private TextBox txtDescripcion;
        private Label lblTotal;
        private Label lblMsg;
        private Button btnGenerar;
        private Button btnImprimir;
        private Button btnDesdeTerreno;
        private DataGridView dgvHistorial;

        private readonly CotizacionController _cotCtrl;
        private readonly ClienteController _cliCtrl;
        private readonly MaterialController _matCtrl;
        private readonly TerrenoController _terCtrl;
        private readonly Usuario _usuario;
        private Cotizacion _cotizacionActual;

        public FormCotizacion(CotizacionController cc, ClienteController cl,
            MaterialController mc, TerrenoController tc, Usuario usuario)
        {
            _cotCtrl = cc;
            _cliCtrl = cl;
            _matCtrl = mc;
            _terCtrl = tc;
            _usuario = usuario;
            InitializeComponent();
            CargarCombos();
            RefrescarHistorial();
        }

        private void CargarCombos()
        {
            List<Cliente> clientes = _cliCtrl.ObtenerClientes();
            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";

            List<Material> materiales = _matCtrl.ObtenerMateriales();
            cmbMaterial.DataSource = materiales;
            cmbMaterial.DisplayMember = "Nombre";
            cmbMaterial.ValueMember = "Id";
        }

        private void CmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void TxtVolumen_TextChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            Material m = cmbMaterial.SelectedItem as Material;
            double vol = 0;

            if (m != null && double.TryParse(txtVolumen.Text, out vol))
            {
                double total = vol * m.precioUnidad;
                lblTotal.Text = "Total: $" + total.ToString("N0");
            }
            else
            {
                lblTotal.Text = "";
            }
        }

        private void BtnDesdeTerreno_Click(object sender, EventArgs e)
        {
            double vol = _terCtrl.VolumenCalculado;
            if (vol <= 0)
            {
                MessageBox.Show("Primero calcule el volumen en la sección de Terreno.", "Aviso");
                return;
            }
            txtVolumen.Text = vol.ToString("F4");
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            Cliente cliente = cmbCliente.SelectedItem as Cliente;
            Material material = cmbMaterial.SelectedItem as Material;
            double vol = 0;

            if (cliente == null)
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Seleccione un cliente.";
                return;
            }

            if (material == null)
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Seleccione un material.";
                return;
            }

            if (!double.TryParse(txtVolumen.Text, out vol) || vol <= 0)
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Ingrese un volumen válido mayor que 0.";
                return;
            }

            var (ok, cot, msg) = _cotCtrl.GenerarCotizacion(cliente, material, vol, txtDescripcion.Text);

            if (ok)
            {
                _cotizacionActual = cot;
                lblMsg.ForeColor = Color.Green;
                lblMsg.Text = msg;
                RefrescarHistorial();
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = msg;
            }
        }

        private void RefrescarHistorial()
        {
            dgvHistorial.Rows.Clear();
            foreach (Cotizacion c in _cotCtrl.ObtenerCotizaciones())
            {
                dgvHistorial.Rows.Add(
                    c.fecha.ToString("dd/MM/yyyy"),
                    c.cliente.nombre,
                    c.material.nombre,
                    c.terreno.volumen.ToString("F2"),
                    c.costoTotal.ToString("N0"),
                    c.estado ? "Activa" : "Inactiva"
                );
            }
        }

        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cotización.");
                return;
            }

            int idx = dgvHistorial.SelectedRows[0].Index;

            List<Cotizacion> lista = _cotCtrl.ObtenerCotizaciones();

            if (idx >= lista.Count)
                return;

            Cotizacion cot = lista[idx];

            _cotCtrl.CambiarEstado(cot.id);

            RefrescarHistorial();
        }

        // RF24 - Impresión
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (_cotizacionActual == null)
            {
                MessageBox.Show("Primero genere una cotización.", "Aviso");
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirCotizacion);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog(this);
        }

        private void ImprimirCotizacion(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fontNormal = new Font("Courier New", 10);
            Font fontTotal = new Font("Arial", 13, FontStyle.Bold);

            int y = 50;
            g.DrawString("=== COTIZACIÓN ===", fontTitulo, Brushes.Black, 200, y); y += 35;
            g.DrawString("ID:          " + _cotizacionActual.id, fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Fecha:       " + _cotizacionActual.fecha.ToString("dd/MM/yyyy HH:mm"), fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Cliente:     " + _cotizacionActual.cliente.nombre, fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Material:    " + _cotizacionActual.material.nombre, fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Volumen:     " + _cotizacionActual.terreno.volumen.ToString("F4") + " m³", fontNormal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Costo x m³:  $" + _cotizacionActual.material.precioUnidad.ToString("N0"), fontNormal, Brushes.Black, 50, y); y += 35;
            g.DrawString("TOTAL: $" + _cotizacionActual.costoTotal.ToString("N0"), fontTotal, Brushes.Black, 50, y);
        }
    }
}
