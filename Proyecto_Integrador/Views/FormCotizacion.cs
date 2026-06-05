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
            InitializeComponen();
            CargarCombos();
            RefrescarHistorial();
        }

        private void InitializeComponen()
        {
            this.Text = "Gestión de Cotizaciones";
            this.Size = new Size(950, 620);
            this.StartPosition = FormStartPosition.CenterParent;

            // Panel izquierdo
            Panel pl = new Panel();
            pl.Dock = DockStyle.Left;
            pl.Width = 320;
            pl.Padding = new Padding(12);

            int y = 12;

            Label lCliente = new Label();
            lCliente.Text = "Cliente:";
            lCliente.Location = new Point(12, y);
            lCliente.AutoSize = true;
            pl.Controls.Add(lCliente);
            y += 18;

            cmbCliente = new ComboBox();
            cmbCliente.Location = new Point(12, y);
            cmbCliente.Width = 290;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            pl.Controls.Add(cmbCliente);
            y += 34;

            Label lMaterial = new Label();
            lMaterial.Text = "Material:";
            lMaterial.Location = new Point(12, y);
            lMaterial.AutoSize = true;
            pl.Controls.Add(lMaterial);
            y += 18;

            cmbMaterial = new ComboBox();
            cmbMaterial.Location = new Point(12, y);
            cmbMaterial.Width = 290;
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterial.SelectedIndexChanged += new EventHandler(CmbMaterial_SelectedIndexChanged);
            pl.Controls.Add(cmbMaterial);
            y += 34;

            Label lVolumen = new Label();
            lVolumen.Text = "Volumen (m³):";
            lVolumen.Location = new Point(12, y);
            lVolumen.AutoSize = true;
            pl.Controls.Add(lVolumen);
            y += 18;

            txtVolumen = new TextBox();
            txtVolumen.Location = new Point(12, y);
            txtVolumen.Width = 290;
            txtVolumen.TextChanged += new EventHandler(TxtVolumen_TextChanged);
            pl.Controls.Add(txtVolumen);
            y += 34;

            btnDesdeTerreno = new Button();
            btnDesdeTerreno.Text = "Usar volumen calculado del terreno";
            btnDesdeTerreno.Location = new Point(12, y);
            btnDesdeTerreno.Width = 290;
            btnDesdeTerreno.Height = 28;
            btnDesdeTerreno.FlatStyle = FlatStyle.Flat;
            btnDesdeTerreno.BackColor = Color.SteelBlue;
            btnDesdeTerreno.ForeColor = Color.White;
            btnDesdeTerreno.Click += new EventHandler(BtnDesdeTerreno_Click);
            pl.Controls.Add(btnDesdeTerreno);
            y += 38;

            Label lDesc = new Label();
            lDesc.Text = "Descripción (opcional):";
            lDesc.Location = new Point(12, y);
            lDesc.AutoSize = true;
            pl.Controls.Add(lDesc);
            y += 18;

            txtDescripcion = new TextBox();
            txtDescripcion.Location = new Point(12, y);
            txtDescripcion.Width = 290;
            txtDescripcion.Height = 50;
            txtDescripcion.Multiline = true;
            pl.Controls.Add(txtDescripcion);
            y += 60;

            lblTotal = new Label();
            lblTotal.Location = new Point(12, y);
            lblTotal.Width = 290;
            lblTotal.Height = 40;
            lblTotal.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkGreen;
            pl.Controls.Add(lblTotal);
            y += 50;

            lblMsg = new Label();
            lblMsg.Location = new Point(12, y);
            lblMsg.Width = 290;
            lblMsg.Height = 20;
            lblMsg.ForeColor = Color.Red;
            pl.Controls.Add(lblMsg);
            y += 28;

            btnGenerar = new Button();
            btnGenerar.Text = "Generar Cotización";
            btnGenerar.Location = new Point(12, y);
            btnGenerar.Width = 290;
            btnGenerar.Height = 36;
            btnGenerar.BackColor = Color.FromArgb(34, 120, 50);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Click += new EventHandler(BtnGenerar_Click);
            pl.Controls.Add(btnGenerar);
            y += 44;

            btnImprimir = new Button();
            btnImprimir.Text = "Imprimir / Vista previa";
            btnImprimir.Location = new Point(12, y);
            btnImprimir.Width = 290;
            btnImprimir.Height = 32;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Click += new EventHandler(BtnImprimir_Click);
            pl.Controls.Add(btnImprimir);

            // Historial derecho
            Panel panelDer = new Panel();
            panelDer.Dock = DockStyle.Fill;
            panelDer.Padding = new Padding(8);

            Label lHistorial = new Label();
            lHistorial.Text = "Historial de Cotizaciones";
            lHistorial.Dock = DockStyle.Top;
            lHistorial.Height = 22;
            lHistorial.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            panelDer.Controls.Add(lHistorial);

            dgvHistorial = new DataGridView();
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn cFecha = new DataGridViewTextBoxColumn();
            cFecha.Name = "Fecha"; cFecha.HeaderText = "Fecha";
            DataGridViewTextBoxColumn cCliente = new DataGridViewTextBoxColumn();
            cCliente.Name = "Cliente"; cCliente.HeaderText = "Cliente";
            DataGridViewTextBoxColumn cMaterial = new DataGridViewTextBoxColumn();
            cMaterial.Name = "Material"; cMaterial.HeaderText = "Material";
            DataGridViewTextBoxColumn cVol = new DataGridViewTextBoxColumn();
            cVol.Name = "Volumen"; cVol.HeaderText = "m³";
            DataGridViewTextBoxColumn cTotal = new DataGridViewTextBoxColumn();
            cTotal.Name = "Total"; cTotal.HeaderText = "Total ($)";
            DataGridViewTextBoxColumn cEstado = new DataGridViewTextBoxColumn();
            cEstado.Name = "Estado"; cEstado.HeaderText = "Estado";

            dgvHistorial.Columns.Add(cFecha);
            dgvHistorial.Columns.Add(cCliente);
            dgvHistorial.Columns.Add(cMaterial);
            dgvHistorial.Columns.Add(cVol);
            dgvHistorial.Columns.Add(cTotal);
            dgvHistorial.Columns.Add(cEstado);
            panelDer.Controls.Add(dgvHistorial);

            if (_usuario.rol == Rol.Administrador)
            {
                Button btnEstado = new Button();
                btnEstado.Text = "Cambiar Estado (Activa/Inactiva)";
                btnEstado.Dock = DockStyle.Bottom;
                btnEstado.Height = 30;
                btnEstado.FlatStyle = FlatStyle.Flat;
                btnEstado.Click += new EventHandler(BtnCambiarEstado_Click);
                panelDer.Controls.Add(btnEstado);
            }

            this.Controls.Add(panelDer);
            this.Controls.Add(pl);
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
