namespace Proyecto_Integrador.Views.FormsAuxiliares
{
    partial class FormClientes
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

        #endregion
    }
}