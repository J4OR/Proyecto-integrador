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
    public partial class SeleccionMaterialesForm : Form
    {
        public List<Material> MaterialesSeleccionados = new List<Material>();
        private MaterialController materialController = new MaterialController();
        public SeleccionMaterialesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            tablaMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void cargarEnTabla(List<Material> materiales)
        {
            tablaMateriales.Rows.Clear();



            foreach (var m in materiales)
            {
                int fila = tablaMateriales.Rows.Add(
                m.id,
                m.nombre,
                m.precioUnidad,
                m.estado ? "Activo" : "Inactivo",
                false
                );
                tablaMateriales.Rows[fila].Tag = m;
            }
        }
        private void EstilizarTabla()
        {
            tablaMateriales.BackgroundColor = Color.White;
            tablaMateriales.BorderStyle = BorderStyle.None;
            tablaMateriales.RowHeadersVisible = false;
            tablaMateriales.AllowUserToAddRows = false;
            tablaMateriales.EnableHeadersVisualStyles = false;

            tablaMateriales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablaMateriales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaMateriales.GridColor = Color.FromArgb(220, 220, 220);

            tablaMateriales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            tablaMateriales.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tablaMateriales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            tablaMateriales.DefaultCellStyle.BackColor = Color.White;
            tablaMateriales.DefaultCellStyle.ForeColor = Color.Black;
            tablaMateriales.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            tablaMateriales.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            tablaMateriales.DefaultCellStyle.SelectionForeColor = Color.Black;

            tablaMateriales.RowTemplate.Height = 36;
            tablaMateriales.ColumnHeadersHeight = 34;
        }
        private void cargarMateriales()
        {
            List<Material> materiales = materialController.ObtenerMateriales();
            cargarEnTabla(materiales);
        }

        private void SeleccionMaterialesForm_Load(object sender, EventArgs e)
        {
            EstilizarTabla();
            cargarMateriales();

        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.ToLower();
            var materialesFiltrados = materialController.buscador(filtro);
            cargarEnTabla(materialesFiltrados);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tablaMateriales.EndEdit();
            MaterialesSeleccionados.Clear();

            foreach (DataGridViewRow fila in tablaMateriales.Rows)
            {

                bool seleccionado = fila.Cells["Agregar"].Value != null && (bool)fila.Cells["Agregar"].Value;

                if (seleccionado && fila.Tag is Material material)
                    MaterialesSeleccionados.Add(material);
            }

            if (MaterialesSeleccionados.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un material.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
