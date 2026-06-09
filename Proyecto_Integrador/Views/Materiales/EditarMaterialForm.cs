using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Materiales
{
    public partial class EditarMaterialForm : Form
    {
        Material material;
        public EditarMaterialForm(Material material)
        {
            InitializeComponent();
            this.material = material;
        }
    }
}
