using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Inicio.Terreno
{
    public partial class TerrenoForm : Form
    {
        public TerrenoForm()
        {
            InitializeComponent();
        }

        private void crearTabla(int filas, int columnas)
        {
            tablaPuntos.Rows.Clear();
            tablaPuntos.Columns.Clear();

            for (int j = 0; j < columnas; j++)
            {
                var columna = new DataGridViewTextBoxColumn()
                {
                    HeaderText = $"X{j + 1}",
                    DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleCenter }
                };
                tablaPuntos.Columns.Add(columna);

            }

            for (int i = 0; i < filas; i++)
            {
                int fila = tablaPuntos.Rows.Add();
                tablaPuntos.Rows[fila].HeaderCell.Value = $"Y{i + 1}";
                for (int j = 0; j < columnas; j++)
                {
                    tablaPuntos.Rows[fila].Cells[j].Value = "0";
                }

            }
        }
        private void TerrenoForm_Load(object sender, EventArgs e)
        {
            crearTabla((int)nupFilas.Value, (int)nupColumnas.Value);
            lblResultado.Text = "";
        }
    }
}
