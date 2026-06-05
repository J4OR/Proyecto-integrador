namespace Proyecto_Integrador.Views
{
    partial class FormMateriales
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
            this.Text = "Gestión de Materiales";
            this.Size = new Size(750, 480);

            Panel pl = new Panel();
            pl.Dock = DockStyle.Left;
            pl.Width = 280;
            pl.Padding = new Padding(10);

            int y = 10;

            Label lNombre = new Label();
            lNombre.Text = "Nombre del material:";
            lNombre.Location = new Point(10, y);
            lNombre.AutoSize = true;
            pl.Controls.Add(lNombre);
            y += 18;

            txtNombre = new TextBox();
            txtNombre.Location = new Point(10, y);
            txtNombre.Width = 250;
            pl.Controls.Add(txtNombre);
            y += 32;

            Label lCosto = new Label();
            lCosto.Text = "Costo por m³ ($):";
            lCosto.Location = new Point(10, y);
            lCosto.AutoSize = true;
            pl.Controls.Add(lCosto);
            y += 18;

            txtCosto = new TextBox();
            txtCosto.Location = new Point(10, y);
            txtCosto.Width = 250;
            pl.Controls.Add(txtCosto);
            y += 32;

            lblMsg = new Label();
            lblMsg.Location = new Point(10, y);
            lblMsg.Width = 250;
            lblMsg.Height = 20;
            lblMsg.ForeColor = Color.Red;
            pl.Controls.Add(lblMsg);
            y += 25;

            btnCrear = new Button();
            btnCrear.Text = "Crear Material";
            btnCrear.Location = new Point(10, y);
            btnCrear.Width = 250;
            btnCrear.Height = 34;
            btnCrear.BackColor = Color.SteelBlue;
            btnCrear.ForeColor = Color.White;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Click += new EventHandler(BtnCrear_Click);
            pl.Controls.Add(btnCrear);

            dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Material";

            DataGridViewTextBoxColumn colCosto = new DataGridViewTextBoxColumn();
            colCosto.Name = "Costo";
            colCosto.HeaderText = "Costo x m³ ($)";

            dgv.Columns.Add(colNombre);
            dgv.Columns.Add(colCosto);

            this.Controls.Add(dgv);
            this.Controls.Add(pl);
        }

        #endregion
    }
}