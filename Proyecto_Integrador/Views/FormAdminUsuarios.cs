using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views
{
    public partial class FormAdminUsuarios : Form
    {
        // ── Lista ──
        private DataGridView dgv;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnLimpiarBusqueda;

        // ── Formulario de edición/creación ──
        private Panel panelForm;
        private Label lblFormTitulo;
        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private ComboBox cmbRol;
        private CheckBox chkEstado;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnCancelar;
        private Label lblMsg;

        // Labels de error inline
        private Label lblErrNombre, lblErrDoc, lblErrTel, lblErrCorreo, lblErrUser, lblErrPass;

        private readonly UsuarioController _ctrl;
        private int _idEditando = -1; // -1 = nuevo

        public FormAdminUsuarios(UsuarioController ctrl)
        {
            _ctrl = ctrl;
            InitializeComponent();
            RefrescarTabla(_ctrl.ObtenerUsuarios());
        }

        

        private TextBox AgregarCampo(Panel parent, string etiqueta, ref int y, out Label lblError, bool esPassword = false)
        {
            Label lbl = new Label();
            lbl.Text = etiqueta;
            lbl.Location = new Point(18, y);
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9);
            parent.Controls.Add(lbl);
            y += 18;

            TextBox txt = new TextBox();
            txt.Location = new Point(18, y);
            txt.Width = 290;
            txt.Font = new Font("Segoe UI", 9.5f);
            if (esPassword) txt.PasswordChar = '*';
            parent.Controls.Add(txt);
            y += 26;

            lblError = new Label();
            lblError.Location = new Point(18, y);
            lblError.Width = 290;
            lblError.Height = 16;
            lblError.Font = new Font("Segoe UI", 7.5f);
            lblError.ForeColor = Color.Crimson;
            parent.Controls.Add(lblError);
            y += 18;

            return txt;
        }

        // ── Eventos ──

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _idEditando = -1;
            LimpiarFormulario();
            lblFormTitulo.Text = "Nuevo Usuario";
            txtPassword.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _idEditando = -1;
            LimpiarFormulario();
            lblFormTitulo.Text = "Nuevo Usuario";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(texto))
            {
                RefrescarTabla(_ctrl.ObtenerUsuarios());
                return;
            }

            List<Usuario> todos = _ctrl.ObtenerUsuarios();
            List<Usuario> filtrado = todos.FindAll(u =>
                u.nombre.ToLower().Contains(texto) ||
                u.userName.ToLower().Contains(texto) ||
                u.identificacion.ToLower().Contains(texto));

            RefrescarTabla(filtrado);
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            List<Usuario> lista = _ctrl.ObtenerUsuarios();
            if (e.RowIndex >= lista.Count) return;

            Usuario u = lista[e.RowIndex];

            if (e.ColumnIndex == dgv.Columns["Editar"].Index)
            {
                CargarUsuarioEnFormulario(u);
            }
            else if (e.ColumnIndex == dgv.Columns["Toggle"].Index)
            {
                string accion = u.estado ? "desactivar" : "activar";
                DialogResult res = MessageBox.Show(
                    $"¿Desea {accion} al usuario \"{u.userName}\"?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    u.estado = !u.estado;
                    _ctrl.EditarUsuario(u, u.id);
                    RefrescarTabla(_ctrl.ObtenerUsuarios());

                    lblMsg.ForeColor = Color.DarkGreen;
                    lblMsg.Text = $"Usuario {(u.estado ? "activado" : "desactivado")}.";
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            LimpiarErrores();
            lblMsg.Text = "";

            string nombre = txtNombre.Text.Trim();
            string doc = txtIdentificacion.Text.Trim();
            string tel = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string user = txtUserName.Text.Trim();
            string pass = txtPassword.Text.Trim();
            Rol rol = cmbRol.SelectedIndex == 1 ? Rol.Administrador : Rol.Usuario;
            bool estado = chkEstado.Checked;

            bool hayError = false;

            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3 || !Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            { lblErrNombre.Text = "Nombre inválido (mínimo 3 letras)."; hayError = true; }

            if (string.IsNullOrEmpty(doc) || !Regex.IsMatch(doc, @"^[0-9\-]{6,11}$"))
            { lblErrDoc.Text = "Documento inválido (6-11 dígitos)."; hayError = true; }

            if (!Regex.IsMatch(tel, @"^\d{10}$"))
            { lblErrTel.Text = "Teléfono debe tener 10 dígitos."; hayError = true; }

            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            { lblErrCorreo.Text = "Correo inválido."; hayError = true; }

            if (string.IsNullOrEmpty(user) || user.Length < 4 || !Regex.IsMatch(user, @"^[a-zA-Z0-9_]+$"))
            { lblErrUser.Text = "Usuario inválido (mín 4 caracteres, sin espacios)."; hayError = true; }

            // Solo validar contraseña al crear nuevo usuario
            if (_idEditando == -1)
            {
                if (string.IsNullOrEmpty(pass) || pass.Length < 6 ||
                    !Regex.IsMatch(pass, @"[0-9]") || !Regex.IsMatch(pass, @"[^a-zA-Z0-9]"))
                { lblErrPass.Text = "Contraseña: mín 6 chars, un número y un carácter especial."; hayError = true; }
            }

            if (hayError) return;

            // Verificar unicidad de userName y documento (excepto el propio registro en edición)
            List<Usuario> todos = _ctrl.ObtenerUsuarios();

            bool userDuplicado = todos.Exists(u => u.userName == user && u.id != _idEditando);
            if (userDuplicado) { lblErrUser.Text = "Ese nombre de usuario ya está en uso."; return; }

            bool docDuplicado = todos.Exists(u => u.identificacion == doc && u.id != _idEditando);
            if (docDuplicado) { lblErrDoc.Text = "Ese documento ya está registrado."; return; }

            if (_idEditando == -1)
            {
                // Crear
                int nuevoId = _ctrl.ObtenerSiguienteId();
                Usuario nuevo = new Usuario(nuevoId, doc, nombre, tel, correo, user, pass, rol, estado);
                _ctrl.AgregarUsuario(nuevo);
                lblMsg.ForeColor = Color.DarkGreen;
                lblMsg.Text = "✔ Usuario creado correctamente.";
            }
            else
            {
                // Editar — conservar contraseña si el campo está vacío
                Usuario original = todos.Find(u => u.id == _idEditando);
                string passwordFinal = string.IsNullOrEmpty(pass) ? original.password : pass;
                Usuario editado = new Usuario(_idEditando, doc, nombre, tel, correo, user, passwordFinal, rol, estado);
                _ctrl.EditarUsuario(editado, _idEditando);
                lblMsg.ForeColor = Color.DarkGreen;
                lblMsg.Text = "✔ Usuario actualizado correctamente.";
            }

            _idEditando = -1;
            LimpiarFormulario();
            lblFormTitulo.Text = "Nuevo Usuario";
            RefrescarTabla(_ctrl.ObtenerUsuarios());
        }

        // ── Helpers ──

        private void CargarUsuarioEnFormulario(Usuario u)
        {
            _idEditando = u.id;
            lblFormTitulo.Text = "Editar Usuario";
            txtNombre.Text = u.nombre;
            txtIdentificacion.Text = u.identificacion;
            txtTelefono.Text = u.telefono;
            txtCorreo.Text = u.correo;
            txtUserName.Text = u.userName;
            txtPassword.Text = "";
            txtPassword.PlaceholderText = "(dejar vacío para no cambiar)";
            cmbRol.SelectedIndex = u.rol == Rol.Administrador ? 1 : 0;
            chkEstado.Checked = u.estado;
            LimpiarErrores();
            lblMsg.Text = "";
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear(); txtIdentificacion.Clear();
            txtTelefono.Clear(); txtCorreo.Clear();
            txtUserName.Clear(); txtPassword.Clear();
            txtPassword.PlaceholderText = "";
            cmbRol.SelectedIndex = 0;
            chkEstado.Checked = true;
            LimpiarErrores();
            lblMsg.Text = "";
        }

        private void LimpiarErrores()
        {
            lblErrNombre.Text = ""; lblErrDoc.Text = "";
            lblErrTel.Text = ""; lblErrCorreo.Text = "";
            lblErrUser.Text = ""; lblErrPass.Text = "";
        }

        private void RefrescarTabla(List<Usuario> lista)
        {
            dgv.Rows.Clear();
            foreach (Usuario u in lista)
            {
                dgv.Rows.Add(
                    u.id,
                    u.nombre,
                    u.identificacion,
                    u.userName,
                    u.rol.ToString(),
                    u.estado ? "✔ Activo" : "✖ Inactivo"
                );
            }
        }
    }
}
