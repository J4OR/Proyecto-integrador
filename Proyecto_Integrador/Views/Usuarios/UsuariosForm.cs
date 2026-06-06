using OpenTK.Graphics;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.Usuarios;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Proyecto_Integrador.Views.Inicio
{
    public partial class UsuariosForm : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        private ControlsUtils resizer;
        private Usuario usuarioLogueado;
        public UsuariosForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
            this.resizer = new ControlsUtils(this);
        }
        private void cargarUsuarios()
        {
            List<Usuario> usuarios = usuarioController.ObtenerUsuarios();
            if (usuarioLogueado.userName != "admin")
            {
                usuarios = usuarios.Where(u => u.userName != "admin").ToList();
            }

            tablaUsuarios.AutoGenerateColumns = false;
            Id.DataPropertyName = "Id";
            UserName.DataPropertyName = "UserName";
            Nombre.DataPropertyName = "Nombre";
            Identificacion.DataPropertyName = "Identificacion";
            Telefono.DataPropertyName = "Telefono";
            Correo.DataPropertyName = "Correo";
            Rol.DataPropertyName = "Rol";
            Estado.DataPropertyName = "EstadoTexto";

            tablaUsuarios.DataSource = null;
            tablaUsuarios.DataSource = usuarios;

        }
        private void EstilizarTabla()
        {
            tablaUsuarios.BackgroundColor = Color.White;
            tablaUsuarios.BorderStyle = BorderStyle.None;
            tablaUsuarios.RowHeadersVisible = false;
            tablaUsuarios.AllowUserToAddRows = false;
            tablaUsuarios.EnableHeadersVisualStyles = false;

            tablaUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaUsuarios.GridColor = Color.FromArgb(220, 220, 220);

            tablaUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            tablaUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            tablaUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            tablaUsuarios.DefaultCellStyle.BackColor = Color.White;
            tablaUsuarios.DefaultCellStyle.ForeColor = Color.Black;
            tablaUsuarios.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            tablaUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            tablaUsuarios.DefaultCellStyle.SelectionForeColor = Color.Black;

            tablaUsuarios.RowTemplate.Height = 36;
            tablaUsuarios.ColumnHeadersHeight = 34;

            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.DefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);
            Editar.DefaultCellStyle.ForeColor = Color.White;
            Editar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 0, 64);
            Editar.DefaultCellStyle.SelectionForeColor = Color.White;

            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Editar.Width = 90;
        }
        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            tablaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EstilizarTabla();
            cargarUsuarios();
        }

        private void UsuariosForm_Resize(object sender, EventArgs e)
        {
            resizer.ejecutarEscalado();
        }

        private void txtBuscador_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.ToLower();
            List<Usuario> usuarios = usuarioController.ObtenerUsuarios();
            var usuariosFiltrados = usuarios.FindAll(u =>
                u.nombre.ToLower().Contains(filtro) ||
                u.identificacion.ToLower().Contains(filtro) ||
                u.rol.ToString().ToLower().Contains(filtro) ||
                u.estado.ToString().ToLower().Contains(filtro)
            );
            tablaUsuarios.DataSource = null;
            tablaUsuarios.DataSource = usuariosFiltrados;
        }

        private void tablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Usuario usuario = (Usuario)tablaUsuarios.Rows[e.RowIndex].DataBoundItem;


            if (tablaUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                EditarUsuarioForm formEditar = new EditarUsuarioForm(usuario, usuarioLogueado);
                formEditar.ShowDialog();

                cargarUsuarios();
            }

            else if (tablaUsuarios.Columns[e.ColumnIndex].Name == "Accion")
            {
                if (usuario.id == usuarioLogueado.id)
                {
                    MessageBox.Show("No puedes desactivar tu propio usuario mientras tienes la sesión iniciada.","Acción no permitida",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                string mensaje = usuario.estado
                    ? "¿Seguro que quiere desactivar este usuario?"
                    : "¿Seguro que quiere activar este usuario?";

                DialogResult respuesta = MessageBox.Show(mensaje, "Cambiar estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                if (respuesta == DialogResult.OK)
                {
                    bool nuevoEstado = !usuario.estado;

                    usuarioController.CambiarEstadoUsuario(usuario.id, nuevoEstado);

                    cargarUsuarios();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuarioForm formAgregar = new AgregarUsuarioForm();
            formAgregar.ShowDialog();

        }

        private void tablaUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaUsuarios.Columns[e.ColumnIndex].Name == "Estado")
            {
                string estado = e.Value?.ToString();

                if (estado == "Activo")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (estado == "Inactivo")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }

        }
    }
}
