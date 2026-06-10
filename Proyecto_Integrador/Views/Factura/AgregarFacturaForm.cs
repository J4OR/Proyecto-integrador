using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views
{
    public partial class AgregarFacturaForm : Form
    {
        public AgregarFacturaForm()
        {
            InitializeComponent();
        }
        private void ConfigurarDGV()
        {
            dtvgItems.EnableHeadersVisualStyles = false;
            dtvgItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 70, 130);
            dtvgItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtvgItems.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            dtvgItems.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 70, 130);
            dtvgItems.DefaultCellStyle.Font = new Font("Arial", 9F);
            dtvgItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 255);
            dtvgItems.GridColor = Color.FromArgb(200, 210, 230);
            Total.DefaultCellStyle.Format = "C2";
            PrecioUnitario.DefaultCellStyle.Format = "N2";
        }
        private void AgregarFacturaForm_Load(object sender, EventArgs e)
        {
            ConfigurarDGV();
            dtvgItems.Rows.Add();
            dtvgItems.Columns["Total"].ReadOnly = true;
        }
    }
}
