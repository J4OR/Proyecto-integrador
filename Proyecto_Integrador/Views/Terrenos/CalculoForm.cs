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
        private ClienteController clienteController = new ClienteController();
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
            crearTabla(4, 4);
            lblResultado.Text = "";
            tablaPuntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbOperacion.DataSource = Enum.GetValues(typeof(TipoOperacion));
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
                    nupAltura.Value = 2;
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
                Terreno terreno = new Terreno((TipoOperacion)cbOperacion.SelectedItem, alturas, (double)nupDx.Value, (double)nupDy.Value, (double)nupAltura.Value);
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
            lblValidacionCliente.Visible = string.IsNullOrWhiteSpace(txtCliente.Text);
            if (lblValidacionCliente.Visible) return;


            Cliente clienteEncontrado = clienteController.Buscar(txtCliente.Text);

            if (clienteEncontrado == null)
            {
                lblValidacionCliente.Text = "El cliente no existe";
                lblValidacionCliente.Visible = true;
                return;
            }

            if (!clienteController.ExisteCliente(clienteEncontrado.identificacion))
            {
                lblValidacionCliente.Text = "El cliente no existe";
                return;
            }

            if (volumenTerreno <= 0)
            {
                MessageBox.Show("Debe calcular el volumen antes de guardar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Terreno terreno = new Terreno((TipoOperacion)cbOperacion.SelectedItem, altura, (double)nupDx.Value, (double)nupDy.Value,
            (double)nupAltura.Value, Math.Round(volumenTerreno, 2), txtNombre.Text, clienteEncontrado);

            terrenoController.AgregarTerreno(terreno);
            MessageBox.Show("terreno agregado correctamente.", "Agregar terreno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;

            FormDashboard principal = (FormDashboard)this.ParentForm;
            principal.AbrirFormularioEnPanel(new TerrenoForm(principal));

        }

        private void cbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((TipoOperacion)cbOperacion.SelectedItem == TipoOperacion.Excavar)
            {
                double[][] alturas = LeerAlturas();

                if (alturas != null)
                {
                    double alturaMaxima = alturas.SelectMany(fila => fila).Max();

                    nupAltura.Value = (decimal)alturaMaxima;
                }
            }
            if((TipoOperacion)cbOperacion.SelectedItem == TipoOperacion.Remover)
            {
                double[][] alturas = LeerAlturas();

                if (alturas != null)
                {
                    double alturaMinima = alturas.SelectMany(fila => fila).Min();

                    nupAltura.Value = (decimal)alturaMinima;
                }

            }
        }

        private void btnMontañas_Click(object sender, EventArgs e)
        {
            nupDx.Value = 5;
            nupDy.Value = 5;
            nupAltura.Value = 0;
            Random random = new Random();

            int filas = tablaPuntos.Rows.Count;
            int columnas = tablaPuntos.Columns.Count;

            double[,] alturas = new double[filas, columnas];

            int cantidadPicos = random.Next(1, 6);

            for (int p = 0; p < cantidadPicos; p++)
            {
                double picoX = random.NextDouble() * (columnas - 1);
                double picoY = random.NextDouble() * (filas - 1);

                double alturaPico = random.Next(10, 40);

                double ancho = random.Next(2, 8);

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        double distancia2 =
                            Math.Pow(j - picoX, 2) +
                            Math.Pow(i - picoY, 2);

                        alturas[i, j] +=
                            alturaPico *
                            Math.Exp(-distancia2 / (2 * ancho * ancho));
                    }
                }
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    alturas[i, j] += random.NextDouble() * 2;

                    tablaPuntos.Rows[i].Cells[j].Value =
                        alturas[i, j].ToString("F2",
                        System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            lblResultado.Text = "Terreno montañoso generado";
            lblResultado.ForeColor = Color.DarkBlue;
        }

        private void btnExcavaciones_Click(object sender, EventArgs e)
        { 
            Random random = new Random();

            int filas = tablaPuntos.Rows.Count;
            int columnas = tablaPuntos.Columns.Count;

            double centroX = (columnas - 1) / 2.0;
            double centroY = (filas - 1) / 2.0;

            double profundidad = random.Next(4, 9); // 4 a 8 metros
            double alturaBorde = random.Next(1, 4); // bordes

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    double distancia = Math.Sqrt(
                        Math.Pow(j - centroX, 2) +
                        Math.Pow(i - centroY, 2));

                    double altura =
                        alturaBorde +
                        distancia * 1.2 -
                        profundidad;

                    altura += (random.NextDouble() - 0.5) * 0.5;

                    tablaPuntos.Rows[i].Cells[j].Value =
                        altura.ToString("F2",
                        System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            lblResultado.Text = "Excavación tipo piscina generada";
            lblResultado.ForeColor = Color.DarkBlue;
        }
    }
}
