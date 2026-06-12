using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Terrenos
{
    public partial class TerrenoForm : Form
    {
        private FormDashboard formularioPrincipal;
        private ControlsUtils resizer;
        private TerrenoController terrenoController = new TerrenoController();
        public TerrenoForm(FormDashboard formulario)
        {
            InitializeComponent();
            this.resizer = new ControlsUtils(this);
            this.formularioPrincipal = formulario;
        }
        private void cargarEnTabla(List<Terreno> terrenos)
        {
            tablaTerrenos.Rows.Clear();
            foreach (var t in terrenos)
            {

                int fila = tablaTerrenos.Rows.Add(
                    t.id,
                    t.nombre,
                    t.cliente.identificacion,
                    t.operacion,
                    t.volumen
                );
                tablaTerrenos.Rows[fila].Tag = t;
            }
        }
        private void EstilizarTabla()
        {
            tablaTerrenos.BackgroundColor = Color.White;
            tablaTerrenos.BorderStyle = BorderStyle.None;
            tablaTerrenos.RowHeadersVisible = false;
            tablaTerrenos.AllowUserToAddRows = false;
            tablaTerrenos.EnableHeadersVisualStyles = false;

            tablaTerrenos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablaTerrenos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaTerrenos.GridColor = Color.FromArgb(220, 220, 220);

            tablaTerrenos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            tablaTerrenos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tablaTerrenos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            tablaTerrenos.DefaultCellStyle.BackColor = Color.White;
            tablaTerrenos.DefaultCellStyle.ForeColor = Color.Black;
            tablaTerrenos.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            tablaTerrenos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            tablaTerrenos.DefaultCellStyle.SelectionForeColor = Color.Black;

            tablaTerrenos.RowTemplate.Height = 36;
            tablaTerrenos.ColumnHeadersHeight = 34;

            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.DefaultCellStyle.BackColor = Color.FromArgb(80, 0, 0);
            Eliminar.DefaultCellStyle.ForeColor = Color.White;
            Eliminar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 0, 0);
            Eliminar.DefaultCellStyle.SelectionForeColor = Color.White;
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Eliminar.Width = 90;
        }
        public void cargarTerrenos()
        {
            List<Terreno> terrenos = terrenoController.ObtenerTerrenos();
            cargarEnTabla(terrenos);
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            formularioPrincipal.AbrirFormularioEnPanel(new CalculoForm());
        }

        private void TerrenoForm_Load(object sender, EventArgs e)
        {
            tablaTerrenos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EstilizarTabla();
            cargarTerrenos();
        }

        private void TerrenoForm_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.ToLower();

            var TerrenosFiltrados = terrenoController.Buscador(filtro);

            cargarEnTabla(TerrenosFiltrados);

        }

        private void tablaTerrenos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            Terreno TerrenoSeleccionado = (Terreno)tablaTerrenos.Rows[e.RowIndex].Tag;

            if (tablaTerrenos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este Terreno?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    terrenoController.EliminarTerreno(TerrenoSeleccionado.id);
                    cargarTerrenos();
                }
            }
            if (tablaTerrenos.Columns[e.ColumnIndex].Name == "Ver")
            {
                GraficaForm grafica = new GraficaForm(TerrenoSeleccionado.cotas, TerrenoSeleccionado.alturaReferencia,
                    TerrenoSeleccionado.dx, TerrenoSeleccionado.dy);
                grafica.ShowDialog();
            }
        }
    }
}
