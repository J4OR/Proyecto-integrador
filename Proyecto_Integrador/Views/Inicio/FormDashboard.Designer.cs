namespace Proyecto_Integrador.Views
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panelMenu = new Panel();
            btnCerrarSesion = new Button();
            panel1 = new Panel();
            lblRol = new Label();
            lblCorreo = new Label();
            lblUser = new Label();
            pictureBox2 = new PictureBox();
            btnUsuarios = new Button();
            btnCambiarContraseña = new Button();
            btnFactura = new Button();
            btnCotizaciones = new Button();
            btnTerrenos = new Button();
            btnMateriales = new Button();
            pictureBox1 = new PictureBox();
            btnClientes = new Button();
            panel2 = new Panel();
            lblBienvenida = new Label();
            PanelContenido = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            PanelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 0, 64);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnCambiarContraseña);
            panelMenu.Controls.Add(btnFactura);
            panelMenu.Controls.Add(btnCotizaciones);
            panelMenu.Controls.Add(btnTerrenos);
            panelMenu.Controls.Add(btnMateriales);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Location = new Point(1, 1);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(380, 791);
            panelMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.MidnightBlue;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.Location = new Point(22, 696);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(341, 49);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = " Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(22, 578);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 112);
            panel1.TabIndex = 9;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(101, 67);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(33, 20);
            lblRol.TabIndex = 3;
            lblRol.Text = "Rol";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(101, 47);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(136, 20);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "correo@gmail.com";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(101, 19);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(82, 28);
            lblUser.TabIndex = 1;
            lblUser.Text = "usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(0, 0, 64);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(22, 188);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(355, 52);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.Text = "     Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.BackColor = Color.FromArgb(0, 0, 64);
            btnCambiarContraseña.FlatAppearance.BorderSize = 0;
            btnCambiarContraseña.FlatStyle = FlatStyle.Flat;
            btnCambiarContraseña.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarContraseña.ForeColor = Color.White;
            btnCambiarContraseña.Image = (Image)resources.GetObject("btnCambiarContraseña.Image");
            btnCambiarContraseña.ImageAlign = ContentAlignment.MiddleLeft;
            btnCambiarContraseña.Location = new Point(22, 179);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(355, 52);
            btnCambiarContraseña.TabIndex = 6;
            btnCambiarContraseña.Text = "     Cambiar Contraseña";
            btnCambiarContraseña.TextAlign = ContentAlignment.MiddleLeft;
            btnCambiarContraseña.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCambiarContraseña.UseVisualStyleBackColor = false;
            btnCambiarContraseña.Visible = false;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click_1;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.FromArgb(0, 0, 64);
            btnFactura.FlatAppearance.BorderSize = 0;
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFactura.ForeColor = Color.White;
            btnFactura.Image = (Image)resources.GetObject("btnFactura.Image");
            btnFactura.ImageAlign = ContentAlignment.MiddleLeft;
            btnFactura.Location = new Point(22, 469);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(355, 52);
            btnFactura.TabIndex = 5;
            btnFactura.Text = "     Factura";
            btnFactura.TextAlign = ContentAlignment.MiddleLeft;
            btnFactura.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnCotizaciones
            // 
            btnCotizaciones.BackColor = Color.FromArgb(0, 0, 64);
            btnCotizaciones.FlatAppearance.BorderSize = 0;
            btnCotizaciones.FlatStyle = FlatStyle.Flat;
            btnCotizaciones.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCotizaciones.ForeColor = Color.White;
            btnCotizaciones.Image = (Image)resources.GetObject("btnCotizaciones.Image");
            btnCotizaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnCotizaciones.Location = new Point(22, 411);
            btnCotizaciones.Name = "btnCotizaciones";
            btnCotizaciones.Size = new Size(355, 52);
            btnCotizaciones.TabIndex = 4;
            btnCotizaciones.Text = "     Cotizaciones";
            btnCotizaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnCotizaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCotizaciones.UseVisualStyleBackColor = false;
            btnCotizaciones.Click += btnCotizaciones_Click;
            // 
            // btnTerrenos
            // 
            btnTerrenos.BackColor = Color.FromArgb(0, 0, 64);
            btnTerrenos.FlatAppearance.BorderSize = 0;
            btnTerrenos.FlatStyle = FlatStyle.Flat;
            btnTerrenos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTerrenos.ForeColor = Color.White;
            btnTerrenos.Image = (Image)resources.GetObject("btnTerrenos.Image");
            btnTerrenos.ImageAlign = ContentAlignment.MiddleLeft;
            btnTerrenos.Location = new Point(22, 353);
            btnTerrenos.Name = "btnTerrenos";
            btnTerrenos.Size = new Size(355, 52);
            btnTerrenos.TabIndex = 3;
            btnTerrenos.Text = "     Terrenos";
            btnTerrenos.TextAlign = ContentAlignment.MiddleLeft;
            btnTerrenos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTerrenos.UseVisualStyleBackColor = false;
            btnTerrenos.Click += btnTerrenos_Click;
            // 
            // btnMateriales
            // 
            btnMateriales.BackColor = Color.FromArgb(0, 0, 64);
            btnMateriales.FlatAppearance.BorderSize = 0;
            btnMateriales.FlatStyle = FlatStyle.Flat;
            btnMateriales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMateriales.ForeColor = Color.White;
            btnMateriales.Image = (Image)resources.GetObject("btnMateriales.Image");
            btnMateriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnMateriales.Location = new Point(22, 295);
            btnMateriales.Name = "btnMateriales";
            btnMateriales.Size = new Size(355, 52);
            btnMateriales.TabIndex = 2;
            btnMateriales.Text = "     Materiales";
            btnMateriales.TextAlign = ContentAlignment.MiddleLeft;
            btnMateriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMateriales.UseVisualStyleBackColor = false;
            btnMateriales.Click += btnMateriales_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(0, 0, 64);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(22, 237);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(355, 52);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "     Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblBienvenida);
            panel2.Location = new Point(111, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 243);
            panel2.TabIndex = 1;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(22, 33);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(400, 46);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Mensaje de bienvenida";
            // 
            // PanelContenido
            // 
            PanelContenido.BackColor = Color.White;
            PanelContenido.Controls.Add(panel2);
            PanelContenido.Location = new Point(384, 1);
            PanelContenido.Name = "PanelContenido";
            PanelContenido.Size = new Size(1017, 791);
            PanelContenido.TabIndex = 2;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 783);
            Controls.Add(panelMenu);
            Controls.Add(PanelContenido);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            Resize += FormDashboard_Resize;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PanelContenido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnClientes;
        private PictureBox pictureBox1;
        private Button btnCotizaciones;
        private Button btnTerrenos;
        private Button btnMateriales;
        private Button btnFactura;
        private Button btnUsuarios;
        private Button btnCambiarContraseña;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private Label lblUser;
        private Panel panel1;
        private Label lblCorreo;
        private Button btnCerrarSesion;
        private Label label2;
        private Panel panel2;
        private Label lblBienvenida;
        private Label lblRol;
        private Panel PanelContenido;
    }
}