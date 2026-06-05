using OpenTK;
using OpenTK.Graphics;

namespace Proyecto_Integrador.Views
{
    partial class FormTerreno
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
            this.Text = "Terreno – Calculo de Volumen y Grafica 3D";
            this.Size = new Size(1300, 750);

            // Panel izquierdo
            Panel panelIzq = new Panel();
            panelIzq.Dock = DockStyle.Left;
            panelIzq.Width = 300;
            panelIzq.BackColor = Color.WhiteSmoke;
            panelIzq.Padding = new Padding(12);

            int y = 12;
            Label lblTit = new Label();
            lblTit.Text = "Terreno / Volumen";
            lblTit.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblTit.Location = new Point(12, y); lblTit.AutoSize = true;
            panelIzq.Controls.Add(lblTit); y += 36;

            panelIzq.Controls.Add(MakeLabel("Coordenada X (m):", 12, y)); y += 20;
            txtX = MakeTxt(panelIzq, 12, y); y += 32;
            panelIzq.Controls.Add(MakeLabel("Coordenada Y (m):", 12, y)); y += 20;
            txtY = MakeTxt(panelIzq, 12, y); y += 32;
            panelIzq.Controls.Add(MakeLabel("Altura Z (m):", 12, y)); y += 20;
            txtZ = MakeTxt(panelIzq, 12, y); y += 32;

            btnAgregar = MakeBtn("Agregar Punto", Color.SteelBlue, 12, y, panelIzq);
            btnAgregar.Click += new EventHandler(BtnAgregar_Click); y += 44;

            panelIzq.Controls.Add(MakeLabel("Nivel de corte (m):", 12, y)); y += 20;
            txtNivel = MakeTxt(panelIzq, 12, y, "0"); y += 40;

            btnCalcular = MakeBtn("Calcular Volumen", Color.FromArgb(34, 120, 50), 12, y, panelIzq);
            btnCalcular.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCalcular.Click += new EventHandler(BtnCalcular_Click); y += 48;

            lblVolumen = new Label();
            lblVolumen.Location = new Point(12, y); lblVolumen.Width = 265;
            lblVolumen.Height = 60; lblVolumen.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblVolumen.ForeColor = Color.DarkGreen;
            panelIzq.Controls.Add(lblVolumen); y += 60;

            lblEstado = new Label();
            lblEstado.Location = new Point(12, y); lblEstado.Width = 265;
            lblEstado.Height = 20; lblEstado.Font = new Font("Segoe UI", 9);
            lblEstado.ForeColor = Color.Gray;
            panelIzq.Controls.Add(lblEstado); y += 28;

            btnLimpiar = MakeBtn("Limpiar todo", Color.Gray, 12, y, panelIzq);
            btnLimpiar.Click += new EventHandler(BtnLimpiar_Click); y += 44;

            panelIzq.Controls.Add(MakeLabel("Puntos ingresados:", 12, y)); y += 20;

            dgvPuntos = new DataGridView();
            dgvPuntos.Location = new Point(12, y);
            dgvPuntos.Width = 265; dgvPuntos.Height = 180;
            dgvPuntos.ReadOnly = true; dgvPuntos.AllowUserToAddRows = false;
            dgvPuntos.ScrollBars = ScrollBars.Vertical;
            dgvPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPuntos.RowHeadersVisible = false;
            dgvPuntos.BackgroundColor = Color.White;
            dgvPuntos.BorderStyle = BorderStyle.None;
            dgvPuntos.Columns.Add(new DataGridViewTextBoxColumn { Name = "X", HeaderText = "X (m)" });
            dgvPuntos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Y", HeaderText = "Y (m)" });
            dgvPuntos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Z", HeaderText = "Z (m)" });
            panelIzq.Controls.Add(dgvPuntos);

            // Panel derecho con gráfica
            Panel panelDer = new Panel();
            panelDer.Dock = DockStyle.Fill;
            panelDer.BackColor = Color.FromArgb(20, 20, 24);

            // Barra de botones de vista
            Panel panelVista = new Panel();
            panelVista.Dock = DockStyle.Top;
            panelVista.Height = 50;
            panelVista.BackColor = Color.FromArgb(40, 40, 45);

            Label lblVista = new Label();
            lblVista.Text = "Vista 3D:";
            lblVista.ForeColor = Color.White;
            lblVista.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblVista.Location = new Point(12, 15); lblVista.AutoSize = true;
            panelVista.Controls.Add(lblVista);

            btnAntes = MakeBtnVista("ANTES del corte", Color.FromArgb(139, 90, 43), 80, panelVista);
            btnAntes.Click += new EventHandler(BtnAntes_Click);

            btnDespues = MakeBtnVista("DESPUES del corte", Color.FromArgb(34, 120, 50), 230, panelVista);
            btnDespues.Click += new EventHandler(BtnDespues_Click);

            btnAmbos = MakeBtnVista("AMBOS", Color.FromArgb(100, 50, 160), 400, panelVista);
            btnAmbos.Click += new EventHandler(BtnAmbos_Click);

            // Leyenda
            int lx = 530;
            AgregarLeyenda(panelVista, Color.FromArgb(160, 100, 40), "Terreno original", ref lx);
            AgregarLeyenda(panelVista, Color.FromArgb(40, 160, 40), "Despues del corte", ref lx);
            AgregarLeyenda(panelVista, Color.FromArgb(220, 60, 60), "Material removido", ref lx);
            AgregarLeyenda(panelVista, Color.FromArgb(255, 80, 80), "Plano de corte", ref lx);

            Label lblRot = new Label();
            lblRot.Text = "  |  Arrastrar para rotar";
            lblRot.ForeColor = Color.LightGray;
            lblRot.Font = new Font("Segoe UI", 8, FontStyle.Italic);
            lblRot.Location = new Point(lx, 17); lblRot.AutoSize = true;
            panelVista.Controls.Add(lblRot);

            // GLControl
            glControl = new GLControl(new GraphicsMode(32, 24, 0, 4));
            glControl.Dock = DockStyle.Fill;
            glControl.Load += new EventHandler(GL_Load);
            glControl.Paint += new System.Windows.Forms.PaintEventHandler(GL_Paint);
            glControl.Resize += new EventHandler(GL_Resize);
            glControl.MouseDown += new MouseEventHandler(GL_MouseDown);
            glControl.MouseMove += new MouseEventHandler(GL_MouseMove);
            glControl.MouseUp += new MouseEventHandler(GL_MouseUp);
            glControl.MouseWheel += new MouseEventHandler(GL_MouseWheel);

            panelDer.Controls.Add(glControl);
            panelDer.Controls.Add(panelVista);

            this.Controls.Add(panelDer);
            this.Controls.Add(panelIzq);
        }

        private Label MakeLabel(string t, int x, int y)
        {
            return new Label
            {
                Text = t,
                Location = new Point(x, y),
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
        }
        private TextBox MakeTxt(Panel p, int x, int y, string def = "")
        {
            var tb = new TextBox { Location = new Point(x, y), Width = 265, Text = def };
            p.Controls.Add(tb); return tb;
        }
        private Button MakeBtn(string t, Color c, int x, int y, Panel p)
        {
            var b = new Button
            {
                Text = t,
                Location = new Point(x, y),
                Width = 265,
                Height = 36,
                BackColor = c,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            p.Controls.Add(b); return b;
        }
        private Button MakeBtnVista(string t, Color c, int x, Panel p)
        {
            var b = new Button
            {
                Text = t,
                Location = new Point(x, 10),
                Width = 140,
                Height = 30,
                BackColor = c,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            p.Controls.Add(b); return b;
        }
        private void AgregarLeyenda(Panel p, Color c, string t, ref int x)
        {
            p.Controls.Add(new Panel { BackColor = c, Size = new Size(14, 14), Location = new Point(x, 18) });
            var lbl = new Label
            {
                Text = t,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8),
                Location = new Point(x + 16, 17),
                AutoSize = true
            };
            p.Controls.Add(lbl);
            x += 16 + lbl.PreferredWidth + 12;
        }
        #endregion
    }
}