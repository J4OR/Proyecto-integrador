using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Terrenos
{
    public partial class TerrenoForm : Form
    {
        private FormDashboard formularioPrincipal;
        private ControlsUtils resizer;
        public TerrenoForm(FormDashboard formulario)
        {
            InitializeComponent();
            this.resizer = new ControlsUtils(this);
            this.formularioPrincipal = formulario;
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            formularioPrincipal.AbrirFormularioEnPanel(new CalculoForm());
        }

        private void TerrenoForm_Load(object sender, EventArgs e)
        {
        }

        private void TerrenoForm_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();
        }
    }
}
