namespace Proyecto_Integrador.Views
{
    public partial class FormAdminUsuarios
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
            this.Text = "Administración de Usuarios";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.WhiteSmoke;

            // ── Encabezado ──
            Panel header = new Panel();
            header.Dock = DockStyle.Top;
            header.Height = 52;
            header.BackColor = Color.FromArgb(28, 62, 110);

            Label lblTitulo = new Label();
            lblTitulo.Text = "👥  Administración de Usuarios";
            lblTitulo.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            header.Controls.Add(lblTitulo);

            // ── Panel derecho: formulario ──
            panelForm = new Panel();
            panelForm.Dock = DockStyle.Right;
            panelForm.Width = 330;
            panelForm.BackColor = Color.White;
            panelForm.Padding = new Padding(18, 12, 18, 12);

            int y = 12;

            lblFormTitulo = new Label();
            lblFormTitulo.Text = "Nuevo Usuario";
            lblFormTitulo.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblFormTitulo.ForeColor = Color.FromArgb(28, 62, 110);
            lblFormTitulo.Location = new Point(18, y);
            lblFormTitulo.AutoSize = true;
            panelForm.Controls.Add(lblFormTitulo);
            y += 30;

            txtNombre = AgregarCampo(panelForm, "Nombre completo:", ref y, out lblErrNombre);
            txtIdentificacion = AgregarCampo(panelForm, "Documento:", ref y, out lblErrDoc);
            txtTelefono = AgregarCampo(panelForm, "Teléfono (10 dígitos):", ref y, out lblErrTel);
            txtCorreo = AgregarCampo(panelForm, "Correo electrónico:", ref y, out lblErrCorreo);
            txtUserName = AgregarCampo(panelForm, "Nombre de usuario:", ref y, out lblErrUser);
            txtPassword = AgregarCampo(panelForm, "Contraseña:", ref y, out lblErrPass, esPassword: true);

            // Rol
            Label lRol = new Label();
            lRol.Text = "Rol:";
            lRol.Location = new Point(18, y);
            lRol.AutoSize = true;
            lRol.Font = new Font("Segoe UI", 9);
            panelForm.Controls.Add(lRol);
            y += 18;

            cmbRol = new ComboBox();
            cmbRol.Location = new Point(18, y);
            cmbRol.Width = 290;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Items.Add("Usuario");
            cmbRol.Items.Add("Administrador");
            cmbRol.SelectedIndex = 0;
            panelForm.Controls.Add(cmbRol);
            y += 32;

            // Estado
            chkEstado = new CheckBox();
            chkEstado.Text = "Usuario activo";
            chkEstado.Location = new Point(18, y);
            chkEstado.Checked = true;
            chkEstado.Font = new Font("Segoe UI", 9);
            panelForm.Controls.Add(chkEstado);
            y += 30;

            // Mensaje
            lblMsg = new Label();
            lblMsg.Location = new Point(18, y);
            lblMsg.Width = 290;
            lblMsg.Height = 20;
            lblMsg.Font = new Font("Segoe UI", 8.5f);
            panelForm.Controls.Add(lblMsg);
            y += 24;

            // Botones
            btnGuardar = new Button();
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.Location = new Point(18, y);
            btnGuardar.Width = 135;
            btnGuardar.Height = 34;
            btnGuardar.BackColor = Color.FromArgb(28, 62, 110);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnGuardar.Click += new EventHandler(BtnGuardar_Click);
            panelForm.Controls.Add(btnGuardar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(162, y);
            btnCancelar.Width = 90;
            btnCancelar.Height = 34;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderColor = Color.Silver;
            btnCancelar.Click += new EventHandler(BtnCancelar_Click);
            panelForm.Controls.Add(btnCancelar);

            // ── Panel izquierdo: tabla ──
            Panel panelTabla = new Panel();
            panelTabla.Dock = DockStyle.Fill;
            panelTabla.Padding = new Padding(10, 10, 10, 10);

            // Barra de búsqueda + botón nuevo
            Panel barraTop = new Panel();
            barraTop.Dock = DockStyle.Top;
            barraTop.Height = 30;

            txtBuscar = new TextBox();
            txtBuscar.Location = new Point(0, 10);
            txtBuscar.Width = 260;
            txtBuscar.Font = new Font("Segoe UI", 10);
            txtBuscar.PlaceholderText = "Buscar por nombre o usuario...";
            barraTop.Controls.Add(txtBuscar);

            btnBuscar = new Button();
            btnBuscar.Text = "Buscar";
            btnBuscar.Location = new Point(228, 9);
            btnBuscar.Width = 72;
            btnBuscar.Height = 28;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderColor = Color.Silver;
            btnBuscar.Click += new EventHandler(BtnBuscar_Click);
            barraTop.Controls.Add(btnBuscar);

            btnLimpiarBusqueda = new Button();
            btnLimpiarBusqueda.Text = "Ver todos";
            btnLimpiarBusqueda.Location = new Point(308, 9);
            btnLimpiarBusqueda.Width = 80;
            btnLimpiarBusqueda.Height = 28;
            btnLimpiarBusqueda.FlatStyle = FlatStyle.Flat;
            btnLimpiarBusqueda.FlatAppearance.BorderColor = Color.Silver;
            btnLimpiarBusqueda.Click += (s, e) => { txtBuscar.Clear(); RefrescarTabla(_ctrl.ObtenerUsuarios()); };
            barraTop.Controls.Add(btnLimpiarBusqueda);

            btnNuevo = new Button();
            btnNuevo.Text = "+ Nuevo Usuario";
            btnNuevo.Location = new Point(400, 8);
            btnNuevo.Width = 130;
            btnNuevo.Height = 30;
            btnNuevo.BackColor = Color.FromArgb(34, 120, 50);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnNuevo.Click += new EventHandler(BtnNuevo_Click);
            barraTop.Controls.Add(btnNuevo);

            panelTabla.Controls.Add(barraTop);

            // DataGridView
            dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.Font = new Font("Segoe UI", 9);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 62, 110);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellClick += new DataGridViewCellEventHandler(Dgv_CellClick);

            // Agregar columnas al DataGridView (como lo tenías)
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", Width = 40 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Documento", HeaderText = "Documento" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "UserName", HeaderText = "Usuario" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Rol", HeaderText = "Rol" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado" });

            // Botones
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "Editar";
            btnEditar.HeaderText = "";
            btnEditar.Text = "✏ Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 80;
            dgv.Columns.Add(btnEditar);

            DataGridViewButtonColumn btnToggle = new DataGridViewButtonColumn();
            btnToggle.Name = "Toggle";
            btnToggle.HeaderText = "";
            btnToggle.Text = "Activar/Desactivar";
            btnToggle.UseColumnTextForButtonValue = true;
            btnToggle.Width = 120;
            dgv.Columns.Add(btnToggle);

            // Agregar el DataGridView al panelTabla DESPUÉS de configurarlo
            panelTabla.Controls.Add(dgv);

            panelTabla.Controls.Add(dgv);

            this.Controls.Add(panelTabla);
            this.Controls.Add(panelForm);
            this.Controls.Add(header);
        }
        #region Windows Form Designer generated code

        #endregion
    }
}