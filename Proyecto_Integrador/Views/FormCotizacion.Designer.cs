using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views.Utils
{
    partial class FormCotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "Gestión de Cotizaciones";
            this.Size = new Size(950, 620);
            this.StartPosition = FormStartPosition.CenterParent;

            // Panel izquierdo
            Panel pl = new Panel();
            pl.Dock = DockStyle.Left;
            pl.Width = 320;
            pl.Padding = new Padding(12);

            int y = 12;

            Label lCliente = new Label();
            lCliente.Text = "Cliente:";
            lCliente.Location = new Point(12, y);
            lCliente.AutoSize = true;
            pl.Controls.Add(lCliente);
            y += 18;

            cmbCliente = new ComboBox();
            cmbCliente.Location = new Point(12, y);
            cmbCliente.Width = 290;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            pl.Controls.Add(cmbCliente);
            y += 34;

            Label lMaterial = new Label();
            lMaterial.Text = "Material:";
            lMaterial.Location = new Point(12, y);
            lMaterial.AutoSize = true;
            pl.Controls.Add(lMaterial);
            y += 18;

            cmbMaterial = new ComboBox();
            cmbMaterial.Location = new Point(12, y);
            cmbMaterial.Width = 290;
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterial.SelectedIndexChanged += new EventHandler(CmbMaterial_SelectedIndexChanged);
            pl.Controls.Add(cmbMaterial);
            y += 34;

            Label lVolumen = new Label();
            lVolumen.Text = "Volumen (m³):";
            lVolumen.Location = new Point(12, y);
            lVolumen.AutoSize = true;
            pl.Controls.Add(lVolumen);
            y += 18;

            txtVolumen = new TextBox();
            txtVolumen.Location = new Point(12, y);
            txtVolumen.Width = 290;
            txtVolumen.TextChanged += new EventHandler(TxtVolumen_TextChanged);
            pl.Controls.Add(txtVolumen);
            y += 34;

            btnDesdeTerreno = new Button();
            btnDesdeTerreno.Text = "Usar volumen calculado del terreno";
            btnDesdeTerreno.Location = new Point(12, y);
            btnDesdeTerreno.Width = 290;
            btnDesdeTerreno.Height = 28;
            btnDesdeTerreno.FlatStyle = FlatStyle.Flat;
            btnDesdeTerreno.BackColor = Color.SteelBlue;
            btnDesdeTerreno.ForeColor = Color.White;
            //btnDesdeTerreno.Click += new EventHandler(BtnDesdeTerreno_Click);
            pl.Controls.Add(btnDesdeTerreno);
            y += 38;

            Label lDesc = new Label();
            lDesc.Text = "Descripción (opcional):";
            lDesc.Location = new Point(12, y);
            lDesc.AutoSize = true;
            pl.Controls.Add(lDesc);
            y += 18;

            txtDescripcion = new TextBox();
            txtDescripcion.Location = new Point(12, y);
            txtDescripcion.Width = 290;
            txtDescripcion.Height = 50;
            txtDescripcion.Multiline = true;
            pl.Controls.Add(txtDescripcion);
            y += 60;

            lblTotal = new Label();
            lblTotal.Location = new Point(12, y);
            lblTotal.Width = 290;
            lblTotal.Height = 40;
            lblTotal.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkGreen;
            pl.Controls.Add(lblTotal);
            y += 50;

            lblMsg = new Label();
            lblMsg.Location = new Point(12, y);
            lblMsg.Width = 290;
            lblMsg.Height = 20;
            lblMsg.ForeColor = Color.Red;
            pl.Controls.Add(lblMsg);
            y += 28;

            btnGenerar = new Button();
            btnGenerar.Text = "Generar Cotización";
            btnGenerar.Location = new Point(12, y);
            btnGenerar.Width = 290;
            btnGenerar.Height = 36;
            btnGenerar.BackColor = Color.FromArgb(34, 120, 50);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Click += new EventHandler(BtnGenerar_Click);
            pl.Controls.Add(btnGenerar);
            y += 44;

            btnImprimir = new Button();
            btnImprimir.Text = "Imprimir / Vista previa";
            btnImprimir.Location = new Point(12, y);
            btnImprimir.Width = 290;
            btnImprimir.Height = 32;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Click += new EventHandler(BtnImprimir_Click);
            pl.Controls.Add(btnImprimir);

            // Historial derecho
            Panel panelDer = new Panel();
            panelDer.Dock = DockStyle.Fill;
            panelDer.Padding = new Padding(8);

            // REGLA WinForms Dock: agregar controles Bottom/Fill primero, Top al final
            // para que el encabezado Top quede visible encima del DataGridView.

            // 1) Bottom primero
            if (_usuario.rol == Rol.Administrador)
            {
                Button btnEstado = new Button();
                btnEstado.Text = "Cambiar Estado (Activa/Inactiva)";
                btnEstado.Dock = DockStyle.Bottom;
                btnEstado.Height = 30;
                btnEstado.FlatStyle = FlatStyle.Flat;
                btnEstado.Click += new EventHandler(BtnCambiarEstado_Click);
                panelDer.Controls.Add(btnEstado);
            }

            // 2) Fill (DataGridView)
            dgvHistorial = new DataGridView();
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn cFecha = new DataGridViewTextBoxColumn();
            cFecha.Name = "Fecha"; cFecha.HeaderText = "Fecha"; cFecha.MinimumWidth = 90;
            DataGridViewTextBoxColumn cCliente = new DataGridViewTextBoxColumn();
            cCliente.Name = "Cliente"; cCliente.HeaderText = "Cliente";
            DataGridViewTextBoxColumn cMaterial = new DataGridViewTextBoxColumn();
            cMaterial.Name = "Material"; cMaterial.HeaderText = "Material";
            DataGridViewTextBoxColumn cVol = new DataGridViewTextBoxColumn();
            cVol.Name = "Volumen"; cVol.HeaderText = "m³";
            DataGridViewTextBoxColumn cTotal = new DataGridViewTextBoxColumn();
            cTotal.Name = "Total"; cTotal.HeaderText = "Total ($)";
            DataGridViewTextBoxColumn cEstado = new DataGridViewTextBoxColumn();
            cEstado.Name = "Estado"; cEstado.HeaderText = "Estado";

            dgvHistorial.Columns.Add(cFecha);
            dgvHistorial.Columns.Add(cCliente);
            dgvHistorial.Columns.Add(cMaterial);
            dgvHistorial.Columns.Add(cVol);
            dgvHistorial.Columns.Add(cTotal);
            dgvHistorial.Columns.Add(cEstado);
            panelDer.Controls.Add(dgvHistorial);

            // 3) Top AL FINAL para que aparezca encima del Fill
            Label lHistorial = new Label();
            lHistorial.Text = "Historial de Cotizaciones";
            lHistorial.Dock = DockStyle.Top;
            lHistorial.Height = 28;
            lHistorial.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lHistorial.ForeColor = Color.FromArgb(28, 62, 110);
            lHistorial.TextAlign = ContentAlignment.MiddleLeft;
            panelDer.Controls.Add(lHistorial);

            this.Controls.Add(panelDer);
            this.Controls.Add(pl);
        }

    }
}