using OpenTK.Audio.OpenAL;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Views.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Terrenos
{
    public partial class CalculoForm : Form
    {
        private TerrenoController terrenoController = new TerrenoController();
        private ControlsUtils resizer;
        double volumenTerreno;
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
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            crearTabla((int)nupFilas.Value, (int)nupColumnas.Value);
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            var random = new Random();

            // Tipo de terreno aleatorio
            string[] tipos = { "Plano", "Montañoso", "Excavación", "Ondulado" };
            string tipo = tipos[random.Next(tipos.Length)];

            int filas = tablaPuntos.Rows.Count;
            int cols = tablaPuntos.Columns.Count;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double valor = tipo switch
                    {
                        "Plano" => 2.0 + random.NextDouble() * 2.0,           // 2 - 4 m
                        "Montañoso" => 5.0 + random.NextDouble() * 20.0,          // 5 - 25 m
                        "Excavación" => -(1.0 + random.NextDouble() * 8.0),        // -1 a -9 m
                        "Ondulado" => 3.0 + random.NextDouble() * 10.0,          // 3 - 13 m
                        _ => random.NextDouble() * 10.0
                    };

                    tablaPuntos.Rows[i].Cells[j].Value =
                        valor.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                    tablaPuntos.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }

            lblResultado.Text = $"Datos aleatorios generados — Tipo: {tipo}";
            lblResultado.ForeColor = Color.DarkBlue;
            volumenTerreno = 0;
        }

        private double[][]? LeerAlturas()
        {
            tablaPuntos.CurrentCell = null;
            int filas = tablaPuntos.Rows.Count;
            int columnas = tablaPuntos.Columns.Count;
            double[][] alturas = new double[filas][];
            bool error = false;

            for (int i = 0; i < filas; i++)
                alturas[i] = new double[columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    string celda = tablaPuntos.Rows[i].Cells[j].Value?.ToString() ?? "";
                    if (!double.TryParse(celda, System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture, out double valor))
                    {
                        tablaPuntos.Rows[i].Cells[j].Style.BackColor = Color.LightCoral;
                        error = true;
                    }
                    else
                    {
                        tablaPuntos.Rows[i].Cells[j].Style.BackColor = Color.White;
                        alturas[i][j] = valor;
                    }
                }
            }

            return error ? null : alturas;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[][] alturas = LeerAlturas();
            if (alturas == null)
            {
                lblResultado.Text = "Error: celdas inválidas marcadas en rojo.";
                lblResultado.ForeColor = System.Drawing.Color.Crimson;
                return;
            }
            try
            {
                Terreno terreno = new Terreno(alturas, (double)nupDx.Value, (double)nupDy.Value, (double)nupAltura.Value);
                double volumen = terrenoController.CalcularVolumen(terreno);

                volumenTerreno = volumen;

                lblResultado.Text = $"Volumen = {volumen:F2} m³";
                lblResultado.ForeColor = Color.DarkGreen;
            }
            catch (ArgumentException ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
                lblResultado.ForeColor = Color.Crimson;
            }
        }

        private void CalculoForm_Resize(object sender, EventArgs e)
        {
            resizer?.ejecutarEscalado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormDashboard principal = (FormDashboard)this.ParentForm;
            principal.AbrirFormularioEnPanel(new TerrenoForm(principal));
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            double[][] alturas = LeerAlturas();

            GraficaForm graficaForm = new GraficaForm(alturas, (double)nupAltura.Value, (double)nupDx.Value, (double)nupDy.Value);
            graficaForm.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            double[][] altura = LeerAlturas();

            lblValidacion.Visible = string.IsNullOrWhiteSpace(txtNombre.Text);
            if (lblValidacion.Visible) return;

            if (volumenTerreno == 0)
            {
                lblResultado.Text = "Calcula el volumen";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            Terreno terreno = new Terreno(altura, (double)nupDx.Value, (double)nupDy.Value,
            (double)nupAltura.Value, volumenTerreno, txtNombre.Text);

            terrenoController.AgregarTerreno(terreno);
            MessageBox.Show("terreno agregado correctamente.", "Agregar terreno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;

            FormDashboard principal = (FormDashboard)this.ParentForm;
            principal.AbrirFormularioEnPanel(new TerrenoForm(principal));

        }


        private void btnExcavaciones_Click(object sender, EventArgs e)
        {
            var ejemplos = new Dictionary<string, Func<int, int, double>>()
            {
                ["Zanja rectangular"] = (i, j) => 3.0,   // profundidad uniforme
                ["Pozo circular"] = (i, j) =>
                {
                    double u = nupColumnas.Value > 1 ? (double)j / ((double)nupColumnas.Value - 1) - 0.5 : 0;
                    double v = nupFilas.Value > 1 ? (double)i / ((double)nupFilas.Value - 1) - 0.5 : 0;
                    double r = Math.Sqrt(u * u + v * v);
                    return r < 0.35 ? 5.0 + 3.0 * (0.35 - r) / 0.35 : 0.5;  // fondo cónico
                },
                ["Corte en talud"] = (i, j) =>
                {
                    double u = nupColumnas.Value > 1 ? (double)j / ((double)nupColumnas.Value - 1) : 0;
                    return 1.0 + 6.0 * u;   // profundidad crece de izquierda a derecha
                }
            };

            CargarEjemplo(ejemplos);

        }

        private void btnMontañas_Click(object sender, EventArgs e)
        {
            var ejemplos = new Dictionary<string, Func<int, int, double>>()
            {
                ["Montaña gaussiana"] = (i, j) =>
                {
                    double u = nupColumnas.Value > 1 ? (double)j / ((double)nupColumnas.Value - 1) : 0.5;
                    double v = nupFilas.Value > 1 ? (double)i / ((double)nupFilas.Value - 1) : 0.5;
                    return 2.0 + 18.0 * Math.Exp(-((u - 0.5) * (u - 0.5) + (v - 0.5) * (v - 0.5)) / 0.08);
                },
                ["Loma alargada"] = (i, j) =>
                {
                    double v = nupFilas.Value > 1 ? (double)i / ((double)nupFilas.Value - 1) : 0.5;
                    return 3.0 + 12.0 * Math.Exp(-(v - 0.5) * (v - 0.5) / 0.05);  // cresta horizontal
                },
                ["Terreno ondulado"] = (i, j) =>
                {
                    double u = nupColumnas.Value > 1 ? (double)j / ((double)nupColumnas.Value - 1) : 0.5;
                    double v = nupFilas.Value > 1 ? (double)i / ((double)nupFilas.Value - 1) : 0.5;
                    return 5.0 + 3.0 * Math.Sin(u * Math.PI * 2) + 2.0 * Math.Cos(v * Math.PI * 2);
                }
            };

            CargarEjemplo(ejemplos);
        }
        // ── Método compartido: muestra lista y rellena la tabla ───────────────────
        private void CargarEjemplo(Dictionary<string, Func<int, int, double>> ejemplos)
        {
            // Construir mensaje de selección
            var sb = new System.Text.StringBuilder("Selecciona un ejemplo:\n\n");
            var keys = new List<string>(ejemplos.Keys);
            for (int k = 0; k < keys.Count; k++)
                sb.AppendLine($"  {k + 1}. {keys[k]}");

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                sb.ToString(), "Ejemplos predefinidos", "1");

            if (!int.TryParse(input.Trim(), out int opcion) || opcion < 1 || opcion > keys.Count)
            {
                if (!string.IsNullOrWhiteSpace(input))   // silencio si el usuario canceló
                    MessageBox.Show("Opción inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreElegido = keys[opcion - 1];
            var formula = ejemplos[nombreElegido];

            nupAltura.Value = 10;
            nupDx.Value = 5;
            nupDy.Value = 5;

            int filas = tablaPuntos.Rows.Count;
            int cols = tablaPuntos.Columns.Count;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double valor = formula(i, j);
                    tablaPuntos.Rows[i].Cells[j].Value =
                        valor.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                    tablaPuntos.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }

            // Limpiar resultados anteriores
            lblResultado.Text = "";
            volumenTerreno = 0;
        }
    }
}
