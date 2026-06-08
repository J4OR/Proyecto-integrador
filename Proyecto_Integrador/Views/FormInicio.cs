using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.FormsAuxiliares;
using Proyecto_Integrador.Views.Utils;

namespace Proyecto_Integrador.Views
{
    public partial class FormInicio : Form
    {
        private readonly Usuario _usuario;
        private readonly UsuarioController _usuarioCtrl;
        private readonly ClienteController _clienteCtrl;
        private readonly MaterialController _materialCtrl;
        private readonly TerrenoController _terrenoCtrl;
        private readonly CotizacionController _cotCtrl;
        private readonly FacturaController _facCtrl;

        public FormInicio(Usuario usuario)
        {
            _usuario = usuario;

            _usuarioCtrl = new UsuarioController();
            _clienteCtrl = new ClienteController();
            _materialCtrl = new MaterialController();
            _terrenoCtrl = new TerrenoController();
            _cotCtrl = new CotizacionController();
            _facCtrl = new FacturaController();

            InitializeComponent();
        }

        private Panel panelMenu;
        private Panel panelContenido;
        private Label lblBienvenida;
        private Label lblRol;

        public FormInicio(Usuario usuario, UsuarioController uc, ClienteController cc,
            MaterialController mc, TerrenoController tc, CotizacionController coc, FacturaController fc)
        {
            _usuario = usuario;
            _usuarioCtrl = uc;
            _clienteCtrl = cc;
            _materialCtrl = mc;
            _terrenoCtrl = tc;
            _cotCtrl = coc;
            _facCtrl = fc;
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirTerreno(object sender, EventArgs e)
        {
            //AbrirEnContenido(new FormTerreno(_terrenoCtrl));
        }

        private void AbrirClientes(object sender, EventArgs e)
        {
            AbrirEnContenido(new FormClientes(_clienteCtrl));
        }

        private void AbrirMateriales(object sender, EventArgs e)
        {
            AbrirEnContenido(new FormMateriales());
        }

        private void AbrirCotizaciones(object sender, EventArgs e)
        {

            AbrirEnContenido(new FormCotizacion(
                _cotCtrl,
                _clienteCtrl,
                _materialCtrl,
                _terrenoCtrl,
                _usuario
            ));
        }

        private void AbrirFacturas(object sender, EventArgs e)
        {
            AbrirEnContenido(new FormFactura(_facCtrl, _cotCtrl, _clienteCtrl, _usuario));
        }

        private void AbrirCambioContrasena(object sender, EventArgs e)
        {
            AbrirEnContenido(new FormCambiarContraseña(_usuarioCtrl, _usuario));
        }

        private void AbrirAdminUsuarios(object sender, EventArgs e)
        {
            //AbrirEnContenido(new FormAdminUsuarios(_usuarioCtrl));
        }
    }
}
