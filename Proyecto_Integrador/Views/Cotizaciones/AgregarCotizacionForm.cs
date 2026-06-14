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
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        private void ConfigurarDGV()
        {
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 70, 130);
            dgvItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvItems.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            dgvItems.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 70, 130);
            dgvItems.DefaultCellStyle.Font = new Font("Arial", 9F);
            dgvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 255);
            dgvItems.GridColor = Color.FromArgb(200, 210, 230);
            Total.DefaultCellStyle.Format = "C0";
            PrecioUnitario.DefaultCellStyle.Format = "N2";
        }
        private void AgregarCotizacionForm_Load(object sender, EventArgs e)
        {
            txtId.Text = cotizacionController.obtenerId();
            txtId.ForeColor = Color.DarkBlue;

            dgvItems.RowTemplate.Height = 50;
            dgvItems.ColumnHeadersHeight = 45;
            dgvItems.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigurarDGV();
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
            bool hayMaterialSeleccionado = false;

            foreach (DataGridViewRow fila in dgvItems.Rows)
            {
                if (fila.IsNewRow) continue;

                var valorMaterial = fila.Cells["Material"].Value;

                if (valorMaterial != null && !string.IsNullOrEmpty(valorMaterial.ToString()))
                {
                    hayMaterialSeleccionado = true;
                }

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

            if (!hayMaterialSeleccionado)
            {
                MessageBox.Show("Selecciona al menos un material en la tabla.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            lblSubtotal.Text = "Subtotal:     $ " + sumaSubtotal.ToString("N2");
            lblIva.Text = "IVA:            $ " + sumaIva.ToString("N2");
            lblTotal.Text = "Total:      $ " + sumaTotal.ToString("N2");

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

                if (fila.Tag is Terreno terreno)
                {
                    terrenos.Add(terreno);
                }


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


                double subtotal = 0;
                double iva = 0;
                double total = 0;


                double.TryParse(fila.Cells["SubTotal"]?.Value?.ToString(), out subtotal);
                double.TryParse(fila.Cells["Iva"]?.Value?.ToString(), out iva);
                double.TryParse(fila.Cells["Total"]?.Value?.ToString(), out total);

                subtotalGeneral += subtotal;
                ivaGeneral += iva;
                totalGeneral += total;
                if (total == 0)
                {
                    MessageBox.Show("Calcule la cotizacion");
                    return;
                }
            }

            if (materiales.Count == 0)
            {
                MessageBox.Show("No se seleccionaron materiales.");
                return;
            }


            Cotizacion cotizacion = new Cotizacion(txtId.Text, clienteSeleccionado, terrenos, materiales, ivaGeneral, subtotalGeneral,
                totalGeneral, dtpFecha.Value);

            cotizacionController.AgregarCotizacion(cotizacion);

            MessageBox.Show("Cotización guardada correctamente");
            this.Close();
        }

        private void dgvItems_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar esta fila?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                dgvItems.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
    