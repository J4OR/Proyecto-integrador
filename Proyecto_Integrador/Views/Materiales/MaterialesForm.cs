using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.Usuarios;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Materiales
{
    public partial class MaterialesForm : Form
    {
        private MaterialController materialController = new MaterialController();
        private ControlsUtils resizer;
        public MaterialesForm()
        {
            InitializeComponent();
            this.resizer = new ControlsUtils(this);
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

            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.DefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);
            Editar.DefaultCellStyle.ForeColor = Color.White;
            Editar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 0, 64);
            Editar.DefaultCellStyle.SelectionForeColor = Color.White;
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Editar.Width = 90;
        }
        private void cargarMateriales()
        {
            List<Material> materiales = materialController.ObtenerMateriales();
            tablaMateriales.AutoGenerateColumns = false;
            Id.DataPropertyName = "Id";
            Nombre.DataPropertyName = "Nombre";
            PrecioUnidad.DataPropertyName = "PrecioUnidad";
            EstadoTexto.DataPropertyName = "EstadoTexto";

            tablaMateriales.DataSource = null;
            tablaMateriales.DataSource = materiales;
        }

        private void MaterialesForm_Load(object sender, EventArgs e)
        {
            tablaMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EstilizarTabla();
            cargarMateriales();
        }

        private void MaterialesForm_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.ToLower();
            var materialesFiltrados = materialController.buscador(filtro);

            tablaMateriales.DataSource = null;
            tablaMateriales.DataSource = materialesFiltrados;

        }

        private void tablaMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Material materialSeleccionado = (Material)tablaMateriales.Rows[e.RowIndex].DataBoundItem;


            if (tablaMateriales.Columns[e.ColumnIndex].Name == "Editar")
            {
                EditarMaterialForm formEditar = new EditarMaterialForm(materialSeleccionado);
                formEditar.ShowDialog();

                cargarMateriales();
            }

            else if (tablaMateriales.Columns[e.ColumnIndex].Name == "Accion")
            {
                string mensaje = materialSeleccionado.estado
                    ? "¿Seguro que quiere desactivar este material?"
                    : "¿Seguro que quiere activar este material?";

                DialogResult respuesta = MessageBox.Show(mensaje, "Cambiar estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                if (respuesta == DialogResult.OK)
                {
                    bool nuevoEstado = !materialSeleccionado.estado;

                    materialController.cambiarEstado(nuevoEstado, materialSeleccionado.id);

                    cargarMateriales();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMaterialesForm formAgregar = new AgregarMaterialesForm();
            formAgregar.ShowDialog();
            cargarMateriales();
        }
    }
}
