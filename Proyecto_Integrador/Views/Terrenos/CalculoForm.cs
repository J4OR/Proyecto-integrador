using OpenTK.Audio.OpenAL;
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

namespace Proyecto_Integrador.Views.Terrenos
{
    public partial class CalculoForm : Form
    {
        private TerrenoController terrenoController = new TerrenoController();
        private ControlsUtils resizer;
        private bool cargado = false;
        public CalculoForm()
        {
            InitializeComponent();
            this.resizer = new ControlsUtils(this);

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
            crearTabla(3, 3);
            lblResultado.Text = "";
            tablaPuntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargado = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            crearTabla((int)nupFilas.Value, (int)nupColumnas.Value);
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            nupAltura.Value = 10;
            nupDx.Value = 5;
            nupDy.Value = 5;

            int filas = tablaPuntos.Rows.Count;
            int cols = tablaPuntos.Columns.Count;

            // Gaussiana 2D: simula un pico de montaña
            //   base  = 4.5 m  (zona de valle, bajo h=10)
            //   pico  = 4.5+17 = 21.5 m  (cima, 11.5 m sobre h)
            //   centro ligeramente descentrado para mayor realismo
            const double baseZ = 4.5;
            const double ampl = 17.0;
            const double cx = 0.45, cy = 0.40;
            const double sx = 0.28, sy = 0.22;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double u = cols > 1 ? (double)j / (cols - 1) : 0.5;
                    double v = filas > 1 ? (double)i / (filas - 1) : 0.5;
                    double g = ampl * Math.Exp(
                        -((u - cx) * (u - cx) / (2 * sx * sx)
                        + (v - cy) * (v - cy) / (2 * sy * sy)));
                    double valor = baseZ + g;
                    tablaPuntos.Rows[i].Cells[j].Value = valor.ToString("F2",
                        System.Globalization.CultureInfo.InvariantCulture);
                    tablaPuntos.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.White;
                }

            }
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            tablaPuntos.CurrentCell = null;
            int filas = tablaPuntos.Rows.Count;
            int columnas = tablaPuntos.Columns.Count;
            double[][] alturas = new double[filas][];
            bool error = false;
            double volumen;

            for (int i = 0; i < filas; i++)
            {
                alturas[i] = new double[columnas];
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    string celda = tablaPuntos.Rows[i].Cells[j].Value?.ToString() ?? "";
                    if (!double.TryParse(celda, System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture, out double valor))
                    {
                        tablaPuntos.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.LightCoral;
                        error = true;
                    }
                    else
                    {
                        tablaPuntos.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.White;
                        alturas[i][j] = valor;
                    }
                }
            }
            if (error)
            {
                lblResultado.Text = "Error: celdas inválidas marcadas en rojo.";
                lblResultado.ForeColor = System.Drawing.Color.Crimson;
                return;
            }
            try
            {
                Terreno terreno = new Terreno(alturas, (double)nupDx.Value, (double)nupDy.Value, (double)nupAltura.Value);
                volumen = terrenoController.CalcularVolumen(terreno);
                terreno.volumen = volumen;


                lblResultado.ForeColor = Color.DarkGreen;
            }
            catch (ArgumentException ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
                lblResultado.ForeColor = System.Drawing.Color.Crimson;
                return;
            }
            lblResultado.Text = $"Volumen = {volumen:F2} m³";
        }

        private void CalculoForm_Resize(object sender, EventArgs e)
        { 
            resizer.ejecutarEscalado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormDashboard principal = (FormDashboard)this.ParentForm;
            principal.AbrirFormularioEnPanel(new TerrenoForm(principal));
        }
    }
}
