using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Cotizaciones
{
    public partial class AgregarCotizacionForm : Form
    {
        private CotizacionController cotizacionController = new CotizacionController();
        private TerrenoController terrenoController = new TerrenoController();
        private ClienteController clienteController = new ClienteController();
        private Cliente? clienteSeleccionado;
        private List<Terreno> terrenosCliente = new List<Terreno>();
        private List<Material> materialesSeleccionados = new List<Material>();
        public AgregarCotizacionForm()
        {
            InitializeComponent();
            txtId.Text = cotizacionController.obtenerId();
            txtId.ForeColor = Color.DarkBlue;

            dgvItems.RowTemplate.Height = 50;
            dgvItems.ColumnHeadersHeight = 45;
            dgvItems.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void CargarTerrenosEnGrid()
        {
            dgvItems.Rows.Clear();
            foreach (var terreno in terrenosCliente)
            {
                string descripcion = terreno.operacion switch
                {
                    TipoOperacion.Remover => "Excavación y retiro de material - " + terreno.nombre,
                    TipoOperacion.Rellenar => "Relleno de material - " + terreno.nombre,
                    TipoOperacion.Mixto => "Movimiento de tierra - " + terreno.nombre,
                    _ => terreno.nombre
                };

                int index = dgvItems.Rows.Add();
                dgvItems.Rows[index].Cells["Descripcion"].Value = descripcion;
                dgvItems.Rows[index].Cells["Material"].Value = null;
                dgvItems.Rows[index].Cells["PrecioUnitario"].Value = "0.00";
                dgvItems.Rows[index].Cells["Volumen"].Value = terreno.volumen;
                dgvItems.Rows[index].Cells["Iva"].Value = "0.00";
                dgvItems.Rows[index].Cells["Total"].Value = "0.00";
                dgvItems.Rows[index].Tag = terreno;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = clienteController.Buscar(txtIdentificacion.Text.Trim());

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtNombre.Text = clienteSeleccionado.nombre;
            txtIdentificacion.Text = clienteSeleccionado.identificacion;
            txtCorreo.Text = clienteSeleccionado.correo;
            txtTelefono.Text = clienteSeleccionado.telefono;

            terrenosCliente = terrenoController.ObtenerTerrenos()
                .Where(t => t.cliente.identificacion == txtIdentificacion.Text)
                .ToList();

            if (terrenosCliente.Count == 0)
            {
                MessageBox.Show("El cliente no tiene terrenos registrados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CargarTerrenosEnGrid();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {

            if (dgvItems.Rows.Count == 0)
            {
                MessageBox.Show("Primero busca un cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SeleccionMaterialesForm formMateriales = new SeleccionMaterialesForm();

            if (formMateriales.ShowDialog() == DialogResult.OK)
            {
                materialesSeleccionados = formMateriales.MaterialesSeleccionados;

                var comboCol = dgvItems.Columns["Material"] as DataGridViewComboBoxColumn;


                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    row.Cells["Material"].Value = null;
                }


                comboCol.DataSource = null;
                comboCol.DataSource = materialesSeleccionados;
                comboCol.DisplayMember = "nombre";
            }


        }

        private void dgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvItems.Columns["Material"].Index)
            {
                var fila = dgvItems.Rows[e.RowIndex];

                string nombreMaterial = fila.Cells["Material"].Value?.ToString();

                Material material = materialesSeleccionados.FirstOrDefault(m => m.nombre == nombreMaterial);

                if (material != null)
                {
                    fila.Cells["PrecioUnitario"].Value = material.precioUnidad;
                }
            }

        }

        private void dgvItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvItems.IsCurrentCellDirty)
            {
                dgvItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            decimal sumaSubtotal = 0;
            decimal sumaIva = 0;
            decimal sumaTotal = 0;

            foreach (DataGridViewRow fila in dgvItems.Rows)
            {
                if (fila.IsNewRow) continue;

                decimal precio = 0;
                decimal volumen = 0;

                decimal.TryParse(fila.Cells["PrecioUnitario"].Value?.ToString(), out precio);
                decimal.TryParse(fila.Cells["Volumen"].Value?.ToString(), out volumen);

                decimal subtotal = precio * volumen;

                decimal iva = subtotal * 0.19m;

                decimal total = subtotal + iva;

                fila.Cells["SubTotal"].Value = subtotal.ToString("N2");
                fila.Cells["Iva"].Value = iva.ToString("N2");
                fila.Cells["Total"].Value = total.ToString("N2");

                sumaSubtotal += subtotal;
                sumaIva += iva;
                sumaTotal += total;
            }

            lblSubtotal.Text = "$ " + sumaSubtotal.ToString("N2");
            lblIva.Text = "$ " + sumaIva.ToString("N2");
            lblTotal.Text = "$ " + sumaTotal.ToString("N2");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            if (dgvItems.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos.");
                return;
            }

            List<Terreno> terrenos = new List<Terreno>();
            List<Material> materiales = new List<Material>();

            double subtotalGeneral = 0;
            double ivaGeneral = 0;
            double totalGeneral = 0;

            foreach (DataGridViewRow fila in dgvItems.Rows)
            {
                if (fila.IsNewRow) continue;

                // ✅ Obtener terreno
                if (fila.Tag is Terreno terreno)
                {
                    terrenos.Add(terreno);
                }

                // ✅ 🔥 CORRECCIÓN IMPORTANTE: obtener material correctamente
                var valor = fila.Cells["Material"].Value;

                if (valor != null)
                {
                    var material = materialesSeleccionados
                        .FirstOrDefault(m => m.nombre == valor.ToString());

                    if (material != null)
                    {
                        materiales.Add(material);
                    }
                }

                // ✅ Obtener valores numéricos
                double subtotal = 0;
                double iva = 0;
                double total = 0;

                double.TryParse(fila.Cells["SubTotal"]?.Value?.ToString(), out subtotal);
                double.TryParse(fila.Cells["Iva"]?.Value?.ToString(), out iva);
                double.TryParse(fila.Cells["Total"]?.Value?.ToString(), out total);

                subtotalGeneral += subtotal;
                ivaGeneral += iva;
                totalGeneral += total;
            }

            // ✅ VALIDAR que sí haya materiales
            if (materiales.Count == 0)
            {
                MessageBox.Show("No se seleccionaron materiales.");
                return;
            }

            // ✅ Crear cotización
            Cotizacion cotizacion = new Cotizacion(
                txtId.Text,
                clienteSeleccionado,
                terrenos,
                materiales,
                ivaGeneral,
                subtotalGeneral,
                totalGeneral,
                dtpFecha.Value
            );

            // ✅ Guardar en controller
            cotizacionController.AgregarCotizacion(cotizacion);

            MessageBox.Show("Cotización guardada correctamente ✅");
            this.Close();
        }

    }
}
    