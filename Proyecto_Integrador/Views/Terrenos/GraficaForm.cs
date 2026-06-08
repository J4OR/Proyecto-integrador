using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Controls;


namespace Proyecto_Integrador.Views.Terrenos
{
    public partial class GraficaForm : Form
    {
        public GraficaForm()
        {
            InitializeComponent();

            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;

            host.Child = new System.Windows.Controls.Button()
            {
                Content = "Botón WPF"
            };

            this.Controls.Add(host);

        }
    }
}
