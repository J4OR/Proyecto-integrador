using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views
{
    partial class FormFactura
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text = "Gestión de Facturas";
            this.Size = new Size(950, 650);
            this.StartPosition = FormStartPosition.CenterParent;

            TabControl tabs = new TabControl();
            tabs.Dock = DockStyle.Fill;

            // ─── Tab 1: Convertir cotización ───
            TabPage tabConv = new TabPage("Convertir Cotización");

            dgvCotizaciones = new DataGridView();
            dgvCotizaciones.Dock = DockStyle.Fill;
            dgvCotizaciones.ReadOnly = true;
            dgvCotizaciones.AllowUserToAddRows = false;
            dgvCotizaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCotizaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID" });
            dgvCotizaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Fecha", HeaderText = "Fecha" });
            dgvCotizaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cliente", HeaderText = "Cliente" });
            dgvCotizaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Material", HeaderText = "Material" });
            dgvCotizaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Volumen", HeaderText = "m³" });
            dgvCotizaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total", HeaderText = "Total ($)" });
            dgvCotizaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado" });

            btnConvertir = new Button();
            btnConvertir.Text = "Convertir Cotización Seleccionada a Factura";
            btnConvertir.Dock = DockStyle.Bottom;
            btnConvertir.Height = 38;
            btnConvertir.BackColor = Color.FromArgb(34, 120, 50);
            btnConvertir.ForeColor = Color.White;
            btnConvertir.FlatStyle = FlatStyle.Flat;
            btnConvertir.Click += new EventHandler(BtnConvertir_Click);

            tabConv.Controls.Add(dgvCotizaciones);
            tabConv.Controls.Add(btnConvertir);

            // ─── Tab 2: Historial / Filtros ───
            TabPage tabHist = new TabPage("Historial de Facturas");

            Panel panelFiltros = new Panel();
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Height = 65;
            panelFiltros.Padding = new Padding(8);

            Label lDesde = new Label(); lDesde.Text = "Desde:"; lDesde.Location = new Point(8, 16); lDesde.AutoSize = true;
            panelFiltros.Controls.Add(lDesde);

            dtpDesde = new DateTimePicker();
            dtpDesde.Location = new Point(58, 12);
            dtpDesde.Width = 120;
            dtpDesde.Format = DateTimePickerFormat.Short;
            panelFiltros.Controls.Add(dtpDesde);

            Label lHasta = new Label(); lHasta.Text = "Hasta:"; lHasta.Location = new Point(188, 16); lHasta.AutoSize = true;
            panelFiltros.Controls.Add(lHasta);

            dtpHasta = new DateTimePicker();
            dtpHasta.Location = new Point(238, 12);
            dtpHasta.Width = 120;
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Value = DateTime.Now;
            panelFiltros.Controls.Add(dtpHasta);

            Label lCliente = new Label(); lCliente.Text = "Cliente:"; lCliente.Location = new Point(368, 16); lCliente.AutoSize = true;
            panelFiltros.Controls.Add(lCliente);

            cmbCliente = new ComboBox();
            cmbCliente.Location = new Point(418, 12);
            cmbCliente.Width = 150;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Items.Add("Todos");
            foreach (Cliente cl in _cliCtrl.ObtenerClientes())
                cmbCliente.Items.Add(cl.nombre);
            cmbCliente.SelectedIndex = 0;
            panelFiltros.Controls.Add(cmbCliente);

            Label lEstado = new Label(); lEstado.Text = "Estado:"; lEstado.Location = new Point(578, 16); lEstado.AutoSize = true;
            panelFiltros.Controls.Add(lEstado);

            cmbEstado = new ComboBox();
            cmbEstado.Location = new Point(628, 12);
            cmbEstado.Width = 100;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.Add("Todos");
            cmbEstado.Items.Add("Activa");
            cmbEstado.Items.Add("Inactiva");
            cmbEstado.SelectedIndex = 0;
            panelFiltros.Controls.Add(cmbEstado);

            btnFiltrar = new Button();
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Location = new Point(736, 10);
            btnFiltrar.Width = 70;
            btnFiltrar.Height = 28;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Click += new EventHandler(BtnFiltrar_Click);
            panelFiltros.Controls.Add(btnFiltrar);

            dgvFacturas = new DataGridView();
            dgvFacturas.Dock = DockStyle.Fill;
            dgvFacturas.ReadOnly = true;
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID Factura" });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Fecha", HeaderText = "Fecha" });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cliente", HeaderText = "Cliente" });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Material", HeaderText = "Material" });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Volumen", HeaderText = "m³" });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total", HeaderText = "Total ($)" });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado" });

            btnImprimir = new Button();
            btnImprimir.Text = "Imprimir Factura Seleccionada";
            btnImprimir.Dock = DockStyle.Bottom;
            btnImprimir.Height = 32;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Click += new EventHandler(BtnImprimir_Click);

            if (_usuario.rol == Rol.Administrador)
            {
                Button btnEstado = new Button();
                btnEstado.Text = "Cambiar Estado (Activa/Inactiva)";
                btnEstado.Dock = DockStyle.Bottom;
                btnEstado.Height = 30;
                btnEstado.FlatStyle = FlatStyle.Flat;
                btnEstado.Click += new EventHandler(BtnCambiarEstado_Click);
                tabHist.Controls.Add(btnEstado);
            }

            tabHist.Controls.Add(btnImprimir);
            tabHist.Controls.Add(dgvFacturas);
            tabHist.Controls.Add(panelFiltros);

            tabs.TabPages.Add(tabConv);
            tabs.TabPages.Add(tabHist);
            this.Controls.Add(tabs);
        }

        #endregion
    }
}