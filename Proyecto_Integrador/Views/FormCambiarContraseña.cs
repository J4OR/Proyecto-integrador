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
    public partial class FormCambiarContraseña : Form
    {
        private TextBox txtActual;
        private TextBox txtNueva;
        private TextBox txtConfirmar;
        private Button btnMostrarActual;
        private Button btnMostrarNueva;
        private Button btnMostrarConfirmar;
        private Button btnGuardar;
        private Label lblMsgActual;
        private Label lblMsgNueva;
        private Label lblMsgConfirmar;
        private Label lblMsgGeneral;

        private readonly UsuarioController _ctrl;
        private readonly Usuario _usuario;

        public FormCambiarContraseña(UsuarioController ctrl, Usuario usuario)
        {
            _ctrl = ctrl;
            _usuario = usuario;
            InitializeComponent();
        }

        
        // ── Helpers de construcción ──

        private Label Etiqueta(string texto, ref int y)
        {
            Label lbl = new Label();
            lbl.Text = texto;
            lbl.Location = new Point(0, y);
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9);
            lbl.ForeColor = Color.FromArgb(50, 50, 50);
            y += 18;
            return lbl;
        }

        private (TextBox txt, Button btn) CampoPassword(Panel parent, ref int y)
        {
            TextBox txt = new TextBox();
            txt.Location = new Point(0, y);
            txt.Width = 320;
            txt.Height = 28;
            txt.PasswordChar = '*';
            txt.Font = new Font("Segoe UI", 10);
            parent.Controls.Add(txt);

            Button btn = new Button();
            btn.Text = "👁";
            btn.Location = new Point(326, y);
            btn.Width = 34;
            btn.Height = 28;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.Silver;
            btn.BackColor = Color.White;
            btn.Tag = txt;
            btn.Click += (s, e) =>
            {
                txt.PasswordChar = (txt.PasswordChar == '*') ? '\0' : '*';
            };
            parent.Controls.Add(btn);

            y += 32;
            return (txt, btn);
        }

        private Label Mensaje(Panel parent, ref int y)
        {
            Label lbl = new Label();
            lbl.Location = new Point(0, y);
            lbl.Width = 360;
            lbl.Height = 18;
            lbl.Font = new Font("Segoe UI", 8);
            lbl.ForeColor = Color.Crimson;
            parent.Controls.Add(lbl);
            y += 20;
            return lbl;
        }

        // ── Lógica ──

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            LimpiarMensajes();

            string actual = txtActual.Text.Trim();
            string nueva = txtNueva.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            bool hayError = false;

            // Validar contraseña actual
            if (string.IsNullOrEmpty(actual))
            {
                lblMsgActual.Text = "Ingrese su contraseña actual.";
                hayError = true;
            }
            else if (_usuario.password != actual)
            {
                lblMsgActual.Text = "La contraseña actual es incorrecta.";
                hayError = true;
            }

            // Validar nueva contraseña
            if (string.IsNullOrEmpty(nueva))
            {
                lblMsgNueva.Text = "Ingrese la nueva contraseña.";
                hayError = true;
            }
            else if (nueva.Length < 6)
            {
                lblMsgNueva.Text = "Mínimo 6 caracteres.";
                hayError = true;
            }
            else if (!Regex.IsMatch(nueva, @"[0-9]"))
            {
                lblMsgNueva.Text = "Debe contener al menos un número.";
                hayError = true;
            }
            else if (!Regex.IsMatch(nueva, @"[^a-zA-Z0-9]"))
            {
                lblMsgNueva.Text = "Debe contener al menos un carácter especial.";
                hayError = true;
            }
            else if (nueva == actual)
            {
                lblMsgNueva.Text = "La nueva contraseña debe ser diferente a la actual.";
                hayError = true;
            }

            // Validar confirmación
            if (string.IsNullOrEmpty(confirmar))
            {
                lblMsgConfirmar.Text = "Confirme la nueva contraseña.";
                hayError = true;
            }
            else if (nueva != confirmar)
            {
                lblMsgConfirmar.Text = "Las contraseñas no coinciden.";
                hayError = true;
            }

            if (hayError) return;

            // Aplicar cambio
            _usuario.password = nueva;
            _ctrl.EditarUsuario(_usuario, _usuario.id);

            lblMsgGeneral.ForeColor = Color.DarkGreen;
            lblMsgGeneral.Text = "✔ Contraseña actualizada correctamente.";

            txtActual.Clear();
            txtNueva.Clear();
            txtConfirmar.Clear();
        }

        private void LimpiarMensajes()
        {
            lblMsgActual.Text = "";
            lblMsgNueva.Text = "";
            lblMsgConfirmar.Text = "";
            lblMsgGeneral.Text = "";
        }
    }
}
