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
            InitializeComponen();
            RefrescarTabla();
        }

        private void InitializeComponen()
        {
            this.Text = "Gestión de Clientes";
            this.Size = new Size(900, 560);

            Panel panelForm = new Panel();
            panelForm.Dock = DockStyle.Left;
            panelForm.Width = 300;
            panelForm.Padding = new Padding(10);

            int y = 10;

            Label lNombre = new Label();
            lNombre.Text = "Nombre:";
            lNombre.Location = new Point(10, y);
            lNombre.AutoSize = true;
            panelForm.Controls.Add(lNombre);
            y += 18;

            txtNombre = new TextBox();
            txtNombre.Location = new Point(10, y);
            txtNombre.Width = 270;
            panelForm.Controls.Add(txtNombre);
            y += 32;

            Label lId = new Label();
            lId.Text = "Identificación:";
            lId.Location = new Point(10, y);
            lId.AutoSize = true;
            panelForm.Controls.Add(lId);
            y += 18;

            txtIdentificacion = new TextBox();
            txtIdentificacion.Location = new Point(10, y);
            txtIdentificacion.Width = 270;
            panelForm.Controls.Add(txtIdentificacion);
            y += 32;

            Label lTel = new Label();
            lTel.Text = "Teléfono:";
            lTel.Location = new Point(10, y);
            lTel.AutoSize = true;
            panelForm.Controls.Add(lTel);
            y += 18;

            txtTelefono = new TextBox();
            txtTelefono.Location = new Point(10, y);
            txtTelefono.Width = 270;
            panelForm.Controls.Add(txtTelefono);
            y += 32;

            Label lCorreo = new Label();
            lCorreo.Text = "Correo:";
            lCorreo.Location = new Point(10, y);
            lCorreo.AutoSize = true;
            panelForm.Controls.Add(lCorreo);
            y += 18;

            txtCorreo = new TextBox();
            txtCorreo.Location = new Point(10, y);
            txtCorreo.Width = 270;
            panelForm.Controls.Add(txtCorreo);
            y += 32;

            lblMsg = new Label();
            lblMsg.Location = new Point(10, y);
            lblMsg.Width = 270;
            lblMsg.Height = 20;
            lblMsg.ForeColor = Color.Red;
            panelForm.Controls.Add(lblMsg);
            y += 25;

            btnRegistrar = new Button();
            btnRegistrar.Text = "Registrar Cliente";
            btnRegistrar.Location = new Point(10, y);
            btnRegistrar.Width = 270;
            btnRegistrar.Height = 34;
            btnRegistrar.BackColor = Color.SteelBlue;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Click += new EventHandler(BtnRegistrar_Click);
            panelForm.Controls.Add(btnRegistrar);
            y += 44;

            Label lBuscar = new Label();
            lBuscar.Text = "Buscar:";
            lBuscar.Location = new Point(10, y);
            lBuscar.AutoSize = true;
            panelForm.Controls.Add(lBuscar);
            y += 18;

            txtBuscar = new TextBox();
            txtBuscar.Location = new Point(10, y);
            txtBuscar.Width = 200;
            panelForm.Controls.Add(txtBuscar);

            btnBuscar = new Button();
            btnBuscar.Text = "Buscar";
            btnBuscar.Location = new Point(215, y - 1);
            btnBuscar.Width = 65;
            btnBuscar.Height = 24;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Click += new EventHandler(BtnBuscar_Click);
            panelForm.Controls.Add(btnBuscar);

            dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Identificacion";
            colId.HeaderText = "Identificación";

            DataGridViewTextBoxColumn colTel = new DataGridViewTextBoxColumn();
            colTel.Name = "Telefono";
            colTel.HeaderText = "Teléfono";

            DataGridViewTextBoxColumn colCorreo = new DataGridViewTextBoxColumn();
            colCorreo.Name = "Correo";
            colCorreo.HeaderText = "Correo";

            dgv.Columns.Add(colNombre);
            dgv.Columns.Add(colId);
            dgv.Columns.Add(colTel);
            dgv.Columns.Add(colCorreo);

            this.Controls.Add(dgv);
            this.Controls.Add(panelForm);
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
