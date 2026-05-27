namespace Proyecto_Integrador.Views
{
    partial class RegistroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            txtNombre = new TextBox();
            lblTitullo = new Label();
            pbUser = new PictureBox();
            panel1 = new Panel();
            lblErrorConfirmar = new Label();
            lblErrorContraseña = new Label();
            lblErrorUsuario = new Label();
            lblErrorDocumento = new Label();
            lblErrorCorreo = new Label();
            lblErrorTelefono = new Label();
            lblErrorNombre = new Label();
            pbOjo2 = new PictureBox();
            pbOjo = new PictureBox();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            txtConfirmar = new TextBox();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            txtContraseña = new TextBox();
            label9 = new Label();
            label10 = new Label();
            pictureBox8 = new PictureBox();
            txtUsuario = new TextBox();
            panelLinea = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            txtDocumento = new TextBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            txtCorreo = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            txtTelefono = new TextBox();
            lblSubtitulo = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOjo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOjo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AccessibleDescription = "";
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(82, 240);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(502, 45);
            txtNombre.TabIndex = 7;
            txtNombre.Text = "Ingrese el nombre completo";
            txtNombre.Enter += TextBoxs_Enter;
            txtNombre.Leave += TextBoxs_Leave;
            // 
            // lblTitullo
            // 
            lblTitullo.AutoSize = true;
            lblTitullo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitullo.Location = new Point(160, 24);
            lblTitullo.Name = "lblTitullo";
            lblTitullo.Size = new Size(328, 50);
            lblTitullo.TabIndex = 13;
            lblTitullo.Text = "Registrar usuario ";
            // 
            // pbUser
            // 
            pbUser.BackColor = Color.Transparent;
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(34, 3);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(119, 131);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 14;
            pbUser.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblErrorConfirmar);
            panel1.Controls.Add(lblErrorContraseña);
            panel1.Controls.Add(lblErrorUsuario);
            panel1.Controls.Add(lblErrorDocumento);
            panel1.Controls.Add(lblErrorCorreo);
            panel1.Controls.Add(lblErrorTelefono);
            panel1.Controls.Add(lblErrorNombre);
            panel1.Controls.Add(pbOjo2);
            panel1.Controls.Add(pbOjo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(txtConfirmar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(panelLinea);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTitullo);
            panel1.Controls.Add(pbUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(-10, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1318, 778);
            panel1.TabIndex = 15;
            // 
            // lblErrorConfirmar
            // 
            lblErrorConfirmar.AutoSize = true;
            lblErrorConfirmar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorConfirmar.ForeColor = Color.FromArgb(192, 0, 0);
            lblErrorConfirmar.Location = new Point(82, 734);
            lblErrorConfirmar.Name = "lblErrorConfirmar";
            lblErrorConfirmar.Size = new Size(14, 20);
            lblErrorConfirmar.TabIndex = 46;
            lblErrorConfirmar.Text = "t";
            lblErrorConfirmar.Visible = false;
            // 
            // lblErrorContraseña
            // 
            lblErrorContraseña.AutoSize = true;
            lblErrorContraseña.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorContraseña.ForeColor = Color.FromArgb(192, 0, 0);
            lblErrorContraseña.Location = new Point(722, 604);
            lblErrorContraseña.Name = "lblErrorContraseña";
            lblErrorContraseña.Size = new Size(14, 20);
            lblErrorContraseña.TabIndex = 45;
            lblErrorContraseña.Text = "t";
            lblErrorContraseña.Visible = false;
            // 
            // lblErrorUsuario
            // 
            lblErrorUsuario.AutoSize = true;
            lblErrorUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorUsuario.ForeColor = Color.FromArgb(192, 0, 0);
            lblErrorUsuario.Location = new Point(82, 604);
            lblErrorUsuario.Name = "lblErrorUsuario";
            lblErrorUsuario.Size = new Size(14, 20);
            lblErrorUsuario.TabIndex = 44;
            lblErrorUsuario.Text = "t";
            lblErrorUsuario.Visible = false;
            // 
            // lblErrorDocumento
            // 
            lblErrorDocumento.AutoSize = true;
            lblErrorDocumento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorDocumento.ForeColor = Color.FromArgb(192, 0, 0);
            lblErrorDocumento.Location = new Point(722, 414);
            lblErrorDocumento.Name = "lblErrorDocumento";
            lblErrorDocumento.Size = new Size(14, 20);
            lblErrorDocumento.TabIndex = 43;
            lblErrorDocumento.Text = "t";
            lblErrorDocumento.Visible = false;
            // 
            // lblErrorCorreo
            // 
            lblErrorCorreo.AutoSize = true;
            lblErrorCorreo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorCorreo.ForeColor = Color.FromArgb(192, 0, 0);
            lblErrorCorreo.Location = new Point(82, 413);
            lblErrorCorreo.Name = "lblErrorCorreo";
            lblErrorCorreo.Size = new Size(14, 20);
            lblErrorCorreo.TabIndex = 42;
            lblErrorCorreo.Text = "t";
            lblErrorCorreo.Visible = false;
            // 
            // lblErrorTelefono
            // 
            lblErrorTelefono.AutoSize = true;
            lblErrorTelefono.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorTelefono.ForeColor = Color.FromArgb(192, 0, 0);
            lblErrorTelefono.Location = new Point(722, 288);
            lblErrorTelefono.Name = "lblErrorTelefono";
            lblErrorTelefono.Size = new Size(14, 20);
            lblErrorTelefono.TabIndex = 41;
            lblErrorTelefono.Text = "t";
            lblErrorTelefono.Visible = false;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorNombre.ForeColor = Color.FromArgb(192, 0, 0);
            lblErrorNombre.Location = new Point(82, 288);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(14, 20);
            lblErrorNombre.TabIndex = 40;
            lblErrorNombre.Text = "t";
            lblErrorNombre.Visible = false;
            // 
            // pbOjo2
            // 
            pbOjo2.BackColor = Color.Transparent;
            pbOjo2.Image = (Image)resources.GetObject("pbOjo2.Image");
            pbOjo2.Location = new Point(559, 695);
            pbOjo2.Name = "pbOjo2";
            pbOjo2.Size = new Size(25, 27);
            pbOjo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOjo2.TabIndex = 39;
            pbOjo2.TabStop = false;
            pbOjo2.Click += pbOjo2_Click;
            // 
            // pbOjo
            // 
            pbOjo.BackColor = Color.Transparent;
            pbOjo.Image = (Image)resources.GetObject("pbOjo.Image");
            pbOjo.Location = new Point(1199, 567);
            pbOjo.Name = "pbOjo";
            pbOjo.Size = new Size(25, 27);
            pbOjo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOjo.TabIndex = 38;
            pbOjo.TabStop = false;
            pbOjo.Click += pbOjo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(34, 644);
            label7.Name = "label7";
            label7.Size = new Size(191, 25);
            label7.TabIndex = 37;
            label7.Text = "Confirmar contraseña";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(34, 687);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(42, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 36;
            pictureBox6.TabStop = false;
            // 
            // txtConfirmar
            // 
            txtConfirmar.AccessibleDescription = "";
            txtConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtConfirmar.ForeColor = SystemColors.InactiveCaption;
            txtConfirmar.Location = new Point(82, 686);
            txtConfirmar.Multiline = true;
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(502, 45);
            txtConfirmar.TabIndex = 35;
            txtConfirmar.Text = "Confirma la contraseña";
            txtConfirmar.Enter += TextBoxs_Enter;
            txtConfirmar.Leave += TextBoxs_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(674, 514);
            label8.Name = "label8";
            label8.Size = new Size(106, 25);
            label8.TabIndex = 34;
            label8.Text = "Contraseña";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(674, 557);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(42, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 33;
            pictureBox7.TabStop = false;
            // 
            // txtContraseña
            // 
            txtContraseña.AccessibleDescription = "";
            txtContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = SystemColors.InactiveCaption;
            txtContraseña.Location = new Point(722, 556);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(502, 45);
            txtContraseña.TabIndex = 32;
            txtContraseña.Text = "Ingrese la contraseña";
            txtContraseña.Enter += TextBoxs_Enter;
            txtContraseña.Leave += TextBoxs_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(34, 514);
            label9.Name = "label9";
            label9.Size = new Size(179, 25);
            label9.TabIndex = 31;
            label9.Text = "Nombre del usuario";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkBlue;
            label10.Location = new Point(34, 460);
            label10.Name = "label10";
            label10.Size = new Size(232, 28);
            label10.TabIndex = 30;
            label10.Text = "Informacion de usuario";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(34, 557);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(42, 44);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 29;
            pictureBox8.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.AccessibleDescription = "";
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.InactiveCaption;
            txtUsuario.Location = new Point(82, 556);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(502, 45);
            txtUsuario.TabIndex = 28;
            txtUsuario.Text = "Ingrese el nombre de usuario";
            txtUsuario.Enter += TextBoxs_Enter;
            txtUsuario.Leave += TextBoxs_Leave;
            // 
            // panelLinea
            // 
            panelLinea.BackColor = Color.Gray;
            panelLinea.BorderStyle = BorderStyle.Fixed3D;
            panelLinea.Location = new Point(34, 140);
            panelLinea.Name = "panelLinea";
            panelLinea.Size = new Size(1190, 1);
            panelLinea.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(674, 323);
            label4.Name = "label4";
            label4.Size = new Size(221, 25);
            label4.TabIndex = 26;
            label4.Text = "Documento de identidad";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(674, 366);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // txtDocumento
            // 
            txtDocumento.AccessibleDescription = "";
            txtDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDocumento.ForeColor = SystemColors.InactiveCaption;
            txtDocumento.Location = new Point(722, 366);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(502, 45);
            txtDocumento.TabIndex = 24;
            txtDocumento.Text = "Ingrese el documento de identidad";
            txtDocumento.Enter += TextBoxs_Enter;
            txtDocumento.Leave += TextBoxs_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(34, 323);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 23;
            label5.Text = "Correo electronico";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(34, 366);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // txtCorreo
            // 
            txtCorreo.AccessibleDescription = "";
            txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = SystemColors.InactiveCaption;
            txtCorreo.Location = new Point(82, 365);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(502, 45);
            txtCorreo.TabIndex = 21;
            txtCorreo.Text = "Ingrese el correo electrónico";
            txtCorreo.Enter += TextBoxs_Enter;
            txtCorreo.Leave += TextBoxs_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(674, 198);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 20;
            label3.Text = "Telefono";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(674, 241);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.AccessibleDescription = "";
            txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = SystemColors.InactiveCaption;
            txtTelefono.Location = new Point(722, 240);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(502, 45);
            txtTelefono.TabIndex = 18;
            txtTelefono.Text = "Ingrese el número de telefono";
            txtTelefono.Enter += TextBoxs_Enter;
            txtTelefono.Leave += TextBoxs_Leave;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(160, 74);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(432, 25);
            lblSubtitulo.TabIndex = 16;
            lblSubtitulo.Text = "Completa la informacion para crear un nuevo usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 198);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 17;
            label2.Text = "Nombre completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(34, 152);
            label1.Name = "label1";
            label1.Size = new Size(213, 28);
            label1.TabIndex = 16;
            label1.Text = "Informacion Personal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(802, 819);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(10, 5, 0, 5);
            btnCancelar.Size = new Size(153, 55);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 192);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(993, 819);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 5, 0, 5);
            btnGuardar.Size = new Size(223, 55);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar Usuario";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 901);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Name = "RegistroForm";
            Text = "RegistroForm";
            Resize += RegistroForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbOjo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOjo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNombre;
        private Label lblTitullo;
        private PictureBox pbUser;
        private Panel panel1;
        private Label lblSubtitulo;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox txtTelefono;
        private Label label4;
        private PictureBox pictureBox3;
        private TextBox txtDocumento;
        private Label label5;
        private PictureBox pictureBox4;
        private TextBox txtCorreo;
        private Panel panelLinea;
        private Label label7;
        private PictureBox pictureBox6;
        private TextBox txtConfirmar;
        private Label label8;
        private PictureBox pictureBox7;
        private TextBox txtContraseña;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox8;
        private TextBox txtUsuario;
        private Button btnCancelar;
        private Button btnGuardar;
        private PictureBox pbOjo2;
        private PictureBox pbOjo;
        private Label lblErrorConfirmar;
        private Label lblErrorContraseña;
        private Label lblErrorUsuario;
        private Label lblErrorDocumento;
        private Label lblErrorCorreo;
        private Label lblErrorTelefono;
        private Label lblErrorNombre;
    }
}