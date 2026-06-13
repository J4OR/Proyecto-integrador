namespace Proyecto_Integrador.Views.Cotizaciones
{
    partial class AgregarCotizacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCotizacionForm));
            btnCancelar = new Button();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            label7 = new Label();
            txtIdentificacion = new TextBox();
            label9 = new Label();
            txtCorreo = new TextBox();
            label8 = new Label();
            txtTelefono = new TextBox();
            panel2 = new Panel();
            btnBuscarCliente = new Button();
            dgvItems = new DataGridView();
            Descripcion = new DataGridViewTextBoxColumn();
            Material = new DataGridViewComboBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Volumen = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Iva = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            txtId = new TextBox();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            panelTitulo = new Panel();
            lblSubtotal = new Label();
            lblIva = new Label();
            lblTotal = new Label();
            btnGuardar = new Button();
            panel3 = new Panel();
            btnCalcular = new Button();
            btnMateriales = new Button();
            label14 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panel1.SuspendLayout();
            panelTitulo.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(852, 709);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(10, 5, 0, 5);
            btnCancelar.Size = new Size(121, 36);
            btnCancelar.TabIndex = 65;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(16, 9);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 1;
            label5.Text = "Datos del cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(16, 44);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Cliente:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(367, 27);
            txtNombre.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(510, 44);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 7;
            label7.Text = "NIT / CC:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(588, 41);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(200, 27);
            txtIdentificacion.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(16, 77);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 9;
            label9.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(83, 74);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(367, 27);
            txtCorreo.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(510, 77);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 11;
            label8.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(588, 74);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 27);
            txtTelefono.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtIdentificacion);
            panel2.Controls.Add(btnBuscarCliente);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(10, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 115);
            panel2.TabIndex = 55;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(166, 4);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(157, 34);
            btnBuscarCliente.TabIndex = 60;
            btnBuscarCliente.Text = "Buscar Cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { Descripcion, Material, PrecioUnitario, Volumen, SubTotal, Iva, Total });
            dgvItems.Location = new Point(10, 332);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.RowTemplate.Height = 40;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1143, 295);
            dgvItems.TabIndex = 56;
            dgvItems.CellValueChanged += dgvItems_CellValueChanged;
            dgvItems.CurrentCellDirtyStateChanged += dgvItems_CurrentCellDirtyStateChanged;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion del servicio";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 200;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.Width = 125;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.Width = 125;
            // 
            // Volumen
            // 
            Volumen.HeaderText = "Volumen";
            Volumen.MinimumWidth = 6;
            Volumen.Name = "Volumen";
            Volumen.Width = 125;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 125;
            // 
            // Iva
            // 
            Iva.HeaderText = "Iva";
            Iva.MinimumWidth = 6;
            Iva.Name = "Iva";
            Iva.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(601, 38);
            label1.TabIndex = 25;
            label1.Text = "Sistema de Gestion de Movimiento de Tierra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(924, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 102);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 4;
            label4.Text = "Fecha:";
            // 
            // txtId
            // 
            txtId.Location = new Point(49, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(160, 27);
            txtId.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(67, 65);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(142, 27);
            dtpFecha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(12, 37);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 1;
            label3.Text = "N°:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(12, 5);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 0;
            label2.Text = "Numero Cotizacion";
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 0, 64);
            panelTitulo.Controls.Add(panel1);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Location = new Point(-2, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1169, 123);
            panelTitulo.TabIndex = 54;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(673, 642);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(148, 23);
            lblSubtotal.TabIndex = 61;
            lblSubtotal.Text = "Subtotal:     $ 0,00";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIva.Location = new Point(673, 674);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(148, 23);
            lblIva.TabIndex = 62;
            lblIva.Text = "Iva (19%):    $ 0,00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotal.Location = new Point(673, 704);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(153, 28);
            lblTotal.TabIndex = 63;
            lblTotal.Text = "Total:     $ 0,00";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 64);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(989, 709);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 5, 0, 5);
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 64;
            btnGuardar.Text = " Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(btnCalcular);
            panel3.Controls.Add(btnMateriales);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(10, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(1143, 76);
            panel3.TabIndex = 66;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(1015, 42);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(128, 34);
            btnCalcular.TabIndex = 61;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnMateriales
            // 
            btnMateriales.Location = new Point(133, 4);
            btnMateriales.Name = "btnMateriales";
            btnMateriales.Size = new Size(190, 34);
            btnMateriales.TabIndex = 60;
            btnMateriales.Text = "Seleccionar Materiales";
            btnMateriales.UseVisualStyleBackColor = true;
            btnMateriales.Click += btnMateriales_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(0, 0, 64);
            label14.Location = new Point(16, 9);
            label14.Name = "label14";
            label14.Size = new Size(93, 23);
            label14.TabIndex = 1;
            label14.Text = "Materiales";
            // 
            // AgregarCotizacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 752);
            Controls.Add(panel3);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTotal);
            Controls.Add(lblIva);
            Controls.Add(lblSubtotal);
            Controls.Add(dgvItems);
            Controls.Add(panel2);
            Controls.Add(panelTitulo);
            Name = "AgregarCotizacionForm";
            Text = "AgregarCotizacionForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private Label label7;
        private TextBox txtIdentificacion;
        private Label label9;
        private TextBox txtCorreo;
        private Label label8;
        private TextBox txtTelefono;
        private Panel panel2;
        private Button btnBuscarCliente;
        private DataGridView dgvItems;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private TextBox txtId;
        private DateTimePicker dtpFecha;
        private Label label3;
        private Label label2;
        private Panel panelTitulo;
        private Label lblSubtotal;
        private Label lblIva;
        private Label lblTotal;
        private Button btnGuardar;
        private Panel panel3;
        private Button btnMateriales;
        private Label label14;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewComboBoxColumn Material;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Volumen;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Iva;
        private DataGridViewTextBoxColumn Total;
        private Button btnCalcular;
    }
}