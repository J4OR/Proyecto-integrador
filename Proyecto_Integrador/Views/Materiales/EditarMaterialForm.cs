using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Materiales
{
    public partial class EditarMaterialForm : Form
    {
        private MaterialController materialController = new MaterialController();
        private Material materialSeleccionado;
        public EditarMaterialForm(Material material)
        {
            InitializeComponent();
            this.materialSeleccionado = material;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        private void cargarDatos()
        {
            txtNombre.Text = materialSeleccionado.nombre;
            txtPrecio.Text = materialSeleccionado.precioUnidad.ToString();
        }

        private void EditarMaterialForm_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var errores = MaterialValidator.Validar(txtNombre.Text, txtPrecio.Text);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores.Values), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (materialController.ExisteMaterial(txtNombre.Text) && txtNombre.Text != materialSeleccionado.nombre)
            {
                MessageBox.Show("El material ya existe. Por favor, ingrese otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Material material = new Material(materialSeleccionado.id, txtNombre.Text, double.Parse(txtPrecio.Text));

            materialController.EditarMaterial(material, materialSeleccionado.id);

            MessageBox.Show("Material editado correctamente.", "Agregar material", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
