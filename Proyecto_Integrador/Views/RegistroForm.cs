using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views
{
    public partial class RegistroForm : Form
    {
        ControlResizer resizer;
        public RegistroForm()
        {
            InitializeComponent();
            resizer = new ControlResizer(this);
        }

        private void RegistroForm_Resize(object sender, EventArgs e)
        {
            resizer.ejecutarEscalado();

        }
    }
}
