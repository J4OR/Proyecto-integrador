using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views.FormsAuxiliares
{
    public partial class FormClientes : Form
    {
        private DataGridView dgv;
        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtBuscar;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Label lblMsg;
        private readonly ClienteController _ctrl;

        public FormClientes(ClienteController ctrl)
        {
            _ctrl = ctrl;
            InitializeComponent();
            RefrescarTabla();
        }

        

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
            0, // o el ID que corresponda
            txtIdentificacion.Text.Trim(),
            txtNombre.Text.Trim(),
            txtTelefono.Text.Trim(),
            txtCorreo.Text.Trim()
            );

            _ctrl.AgregarCliente(cliente);

            lblMsg.ForeColor = Color.Green;
            lblMsg.Text = "Cliente registrado correctamente.";

            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            RefrescarTabla();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();

            dgv.Rows.Clear();

            foreach (Cliente c in _ctrl.ObtenerClientes())
            {
                if (c.nombre.ToLower().Contains(texto) ||
                    c.identificacion.ToLower().Contains(texto))
                {
                    dgv.Rows.Add(
                        c.nombre,
                        c.identificacion,
                        c.telefono,
                        c.correo
                    );
                }
            }
        }

        private void RefrescarTabla()
        {
            dgv.Rows.Clear();

            List<Cliente> lista = _ctrl.ObtenerClientes();

            foreach (Cliente c in lista)
            {
                dgv.Rows.Add(
                    c.nombre,
                    c.identificacion,
                    c.telefono,
                    c.correo
                );
            }
        }
    }
}
