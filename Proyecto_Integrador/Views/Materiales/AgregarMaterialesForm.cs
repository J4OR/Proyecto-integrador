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
    public partial class AgregarMaterialesForm : Form
    {
        private MaterialController materialController = new MaterialController();
        public AgregarMaterialesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var errores = MaterialValidator.Validar(txtNombre.Text, txtPrecio.Text);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores.Values), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (materialController.ExisteMaterial(txtNombre.Text))
            {
                MessageBox.Show("El material ya existe. Por favor, ingrese otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = materialController.ObtenerSiguienteId();
            Material material = new Material(id, txtNombre.Text, double.Parse(txtPrecio.Text));

            materialController.AgregarMaterial(material);

            MessageBox.Show("Cliente agregado correctamente.", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
