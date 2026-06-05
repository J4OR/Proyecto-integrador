using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views
{
    public partial class FormMateriales : Form
    {
        private DataGridView dgv;
        private TextBox txtNombre;
        private TextBox txtCosto;
        private Button btnCrear;
        private Label lblMsg;
        private readonly MaterialController _ctrl;

        public FormMateriales(MaterialController ctrl)
        {
            _ctrl = ctrl;
            InitializeComponent();
            RefrescarTabla();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (!double.TryParse(txtCosto.Text, out double costo))
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Ingrese un costo numérico válido.";
                return;
            }

            if (_ctrl.ExisteMaterial(nombre))
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Ya existe un material con ese nombre.";
                return;
            }

            Material material = new Material(
                _ctrl.ObtenerSiguienteId(),
                nombre,
                costo,
                true
            );

            _ctrl.AgregarMaterial(material);

            lblMsg.ForeColor = Color.Green;
            lblMsg.Text = "Material creado correctamente.";

            txtNombre.Clear();
            txtCosto.Clear();

            RefrescarTabla();
        }

        private void RefrescarTabla()
        {
            dgv.Rows.Clear();

            foreach (Material m in _ctrl.ObtenerMateriales())
            {
                dgv.Rows.Add(
                    m.id,
                    m.nombre,
                    m.precioUnidad,
                    m.estado
                );
            }
        }
    }
}
