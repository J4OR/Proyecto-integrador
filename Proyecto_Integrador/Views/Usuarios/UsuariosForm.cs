using OpenTK.Graphics;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Inicio
{
    public partial class UsuariosForm : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        private ControlsUtils resizer;
        public UsuariosForm()
        {
            InitializeComponent();
            this.resizer = new ControlsUtils(this);
        }
        private void cargarUsuarios()
        {
            List<Usuario> usuarios = usuarioController.ObtenerUsuarios();

            tablaUsuarios.AutoGenerateColumns = false;

            Id.DataPropertyName = "Id";
            Nombre.DataPropertyName = "Nombre";
            Identificacion.DataPropertyName = "Identificacion";
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

            if (tablaUsuarios.Columns[e.ColumnIndex].Name == "Accion")
            {
                Usuario usuario = (Usuario)tablaUsuarios.Rows[e.RowIndex].DataBoundItem;

                string mensaje = usuario.estado
                    ? "¿Seguro que quiere desactivar este usuario?"
                    : "¿Seguro que quiere activar este usuario?";

                DialogResult respuesta = MessageBox.Show(
                    mensaje,
                    "Cambiar estado",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.OK)
                {
                    bool nuevoEstado = !usuario.estado;

                    usuarioController.CambiarEstadoUsuario(usuario.id, nuevoEstado);

                    cargarUsuarios();
                }
            }
        }
    }
}
