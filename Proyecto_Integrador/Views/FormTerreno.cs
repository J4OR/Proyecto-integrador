using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Views
{
    public partial class FormTerreno : Form
    {
                // ── Controles UI ──
            private DataGridView dgvPuntos;  
            private TextBox txtX, txtY, txtZ, txtNivel;
            private Button btnAgregar, btnCalcular, btnLimpiar;
            private Button btnAntes, btnDespues, btnAmbos;
            private Label lblVolumen, lblEstado;
            private GLControl glControl;
            private readonly TerrenoController _ctrl;

            // ── Estado de la gráfica ──
            private float rotX = 25f;
            private float rotY = -40f;
            private float zoomFactor = 1.0f;
            private Point ultimoMouse;
            private bool arrastrando = false;
            private int modoVista = 2; // 0=Antes, 1=Despues, 2=Ambos
            private int resolucion = 35;

            // Matrices precalculadas
            private double[,] matrizAntes = null; // Terreno original sin tocar
            private double[,] matrizDespues = null; // Terreno después: lo que supera nivelCorte queda plano

            private double nivelCorteActual = 0;
            private double xMin, xMax, yMin, yMax;
            private double zMaxGlobal = 1;

            public double VolumenResultado { get { return _ctrl.VolumenCalculado; } }

            public FormTerreno(TerrenoController ctrl)
            {
                _ctrl = ctrl;
                InitializeComponen();

                // Puntos de ejemplo precargados
                _ctrl.LimpiarPuntos();
                _ctrl.AgregarPunto(0, 0, 1);
                _ctrl.AgregarPunto(5, 0, 3);
                _ctrl.AgregarPunto(10, 0, 1);
                _ctrl.AgregarPunto(0, 5, 3);
                _ctrl.AgregarPunto(5, 5, 9);
                _ctrl.AgregarPunto(5, 5, 9);
                _ctrl.AgregarPunto(10, 5, 3);
                _ctrl.AgregarPunto(0, 10, 1);
                _ctrl.AgregarPunto(5, 10, 3);
                _ctrl.AgregarPunto(10, 10, 1);
                txtNivel.Text = "3";
                RefrescarTabla();
            }

            // ────────────────────────────────────────────────
            //  UI
            // ────────────────────────────────────────────────
            private void InitializeComponen()
            {
                this.Text = "Terreno – Calculo de Volumen y Grafica 3D";
                this.Size = new Size(1300, 750);

                // Panel izquierdo
                Panel panelIzq = new Panel();
                panelIzq.Dock = DockStyle.Left;
                panelIzq.Width = 300;
                panelIzq.BackColor = Color.WhiteSmoke;
                panelIzq.Padding = new Padding(12);

                int y = 12;
                Label lblTit = new Label();
                lblTit.Text = "Terreno / Volumen";
                lblTit.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                lblTit.Location = new Point(12, y); lblTit.AutoSize = true;
                panelIzq.Controls.Add(lblTit); y += 36;

                panelIzq.Controls.Add(MakeLabel("Coordenada X (m):", 12, y)); y += 20;
                txtX = MakeTxt(panelIzq, 12, y); y += 32;
                panelIzq.Controls.Add(MakeLabel("Coordenada Y (m):", 12, y)); y += 20;
                txtY = MakeTxt(panelIzq, 12, y); y += 32;
                panelIzq.Controls.Add(MakeLabel("Altura Z (m):", 12, y)); y += 20;
                txtZ = MakeTxt(panelIzq, 12, y); y += 32;

                btnAgregar = MakeBtn("Agregar Punto", Color.SteelBlue, 12, y, panelIzq);
                btnAgregar.Click += new EventHandler(BtnAgregar_Click); y += 44;

                panelIzq.Controls.Add(MakeLabel("Nivel de corte (m):", 12, y)); y += 20;
                txtNivel = MakeTxt(panelIzq, 12, y, "0"); y += 40;

                btnCalcular = MakeBtn("Calcular Volumen", Color.FromArgb(34, 120, 50), 12, y, panelIzq);
                btnCalcular.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnCalcular.Click += new EventHandler(BtnCalcular_Click); y += 48;

                lblVolumen = new Label();
                lblVolumen.Location = new Point(12, y); lblVolumen.Width = 265;
                lblVolumen.Height = 40; lblVolumen.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblVolumen.ForeColor = Color.DarkGreen;
                panelIzq.Controls.Add(lblVolumen); y += 50;

                lblEstado = new Label();
                lblEstado.Location = new Point(12, y); lblEstado.Width = 265;
                lblEstado.Height = 20; lblEstado.Font = new Font("Segoe UI", 9);
                lblEstado.ForeColor = Color.Gray;
                panelIzq.Controls.Add(lblEstado); y += 28;

                btnLimpiar = MakeBtn("Limpiar todo", Color.Gray, 12, y, panelIzq);
                btnLimpiar.Click += new EventHandler(BtnLimpiar_Click); y += 44;

                panelIzq.Controls.Add(MakeLabel("Puntos ingresados:", 12, y)); y += 20;

                dgvPuntos = new DataGridView();
                dgvPuntos.Location = new Point(12, y);
                dgvPuntos.Width = 265; dgvPuntos.Height = 180;
                dgvPuntos.ReadOnly = true; dgvPuntos.AllowUserToAddRows = false;
                dgvPuntos.ScrollBars = ScrollBars.Vertical;
                dgvPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvPuntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPuntos.RowHeadersVisible = false;
                dgvPuntos.BackgroundColor = Color.White;
                dgvPuntos.BorderStyle = BorderStyle.None;
                dgvPuntos.Columns.Add(new DataGridViewTextBoxColumn { Name = "X", HeaderText = "X (m)" });
                dgvPuntos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Y", HeaderText = "Y (m)" });
                dgvPuntos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Z", HeaderText = "Z (m)" });
                panelIzq.Controls.Add(dgvPuntos);

                // Panel derecho con gráfica
                Panel panelDer = new Panel();
                panelDer.Dock = DockStyle.Fill;
                panelDer.BackColor = Color.FromArgb(20, 20, 24);

                // Barra de botones de vista
                Panel panelVista = new Panel();
                panelVista.Dock = DockStyle.Top;
                panelVista.Height = 50;
                panelVista.BackColor = Color.FromArgb(40, 40, 45);

                Label lblVista = new Label();
                lblVista.Text = "Vista 3D:";
                lblVista.ForeColor = Color.White;
                lblVista.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblVista.Location = new Point(12, 15); lblVista.AutoSize = true;
                panelVista.Controls.Add(lblVista);

                btnAntes = MakeBtnVista("ANTES del corte", Color.FromArgb(139, 90, 43), 80, panelVista);
                btnAntes.Click += new EventHandler(BtnAntes_Click);

                btnDespues = MakeBtnVista("DESPUES del corte", Color.FromArgb(34, 120, 50), 230, panelVista);
                btnDespues.Click += new EventHandler(BtnDespues_Click);

                btnAmbos = MakeBtnVista("AMBOS", Color.FromArgb(100, 50, 160), 400, panelVista);
                btnAmbos.Click += new EventHandler(BtnAmbos_Click);

                // Leyenda
                int lx = 530;
                AgregarLeyenda(panelVista, Color.FromArgb(160, 100, 40), "Terreno original", ref lx);
                AgregarLeyenda(panelVista, Color.FromArgb(40, 160, 40), "Despues del corte", ref lx);
                AgregarLeyenda(panelVista, Color.FromArgb(220, 60, 60), "Material removido", ref lx);
                AgregarLeyenda(panelVista, Color.FromArgb(255, 80, 80), "Plano de corte", ref lx);

                Label lblRot = new Label();
                lblRot.Text = "  |  Arrastrar para rotar";
                lblRot.ForeColor = Color.LightGray;
                lblRot.Font = new Font("Segoe UI", 8, FontStyle.Italic);
                lblRot.Location = new Point(lx, 17); lblRot.AutoSize = true;
                panelVista.Controls.Add(lblRot);

                // GLControl
                glControl = new GLControl(new GraphicsMode(32, 24, 0, 4));
                glControl.Dock = DockStyle.Fill;
                glControl.Load += new EventHandler(GL_Load);
                glControl.Paint += new System.Windows.Forms.PaintEventHandler(GL_Paint);
                glControl.Resize += new EventHandler(GL_Resize);
                glControl.MouseDown += new MouseEventHandler(GL_MouseDown);
                glControl.MouseMove += new MouseEventHandler(GL_MouseMove);
                glControl.MouseUp += new MouseEventHandler(GL_MouseUp);
                glControl.MouseWheel += new MouseEventHandler(GL_MouseWheel);

                panelDer.Controls.Add(glControl);
                panelDer.Controls.Add(panelVista);

                this.Controls.Add(panelDer);
                this.Controls.Add(panelIzq);
            }

            // ── Helpers UI ──
            private Label MakeLabel(string t, int x, int y)
            {
                return new Label
                {
                    Text = t,
                    Location = new Point(x, y),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };
            }
            private TextBox MakeTxt(Panel p, int x, int y, string def = "")
            {
                var tb = new TextBox { Location = new Point(x, y), Width = 265, Text = def };
                p.Controls.Add(tb); return tb;
            }
            private Button MakeBtn(string t, Color c, int x, int y, Panel p)
            {
                var b = new Button
                {
                    Text = t,
                    Location = new Point(x, y),
                    Width = 265,
                    Height = 36,
                    BackColor = c,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                p.Controls.Add(b); return b;
            }
            private Button MakeBtnVista(string t, Color c, int x, Panel p)
            {
                var b = new Button
                {
                    Text = t,
                    Location = new Point(x, 10),
                    Width = 140,
                    Height = 30,
                    BackColor = c,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };
                p.Controls.Add(b); return b;
            }
            private void AgregarLeyenda(Panel p, Color c, string t, ref int x)
            {
                p.Controls.Add(new Panel { BackColor = c, Size = new Size(14, 14), Location = new Point(x, 18) });
                var lbl = new Label
                {
                    Text = t,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 8),
                    Location = new Point(x + 16, 17),
                    AutoSize = true
                };
                p.Controls.Add(lbl);
                x += 16 + lbl.PreferredWidth + 12;
            }

            // ── Eventos de botones ──
            private void BtnAgregar_Click(object s, EventArgs e)
            {
                double x = 0, y = 0, z = 0;
                if (!double.TryParse(txtX.Text, out x) ||
                    !double.TryParse(txtY.Text, out y) ||
                    !double.TryParse(txtZ.Text, out z))
                {
                    MessageBox.Show("Ingrese valores numericos validos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _ctrl.AgregarPunto(x, y, z);
                RefrescarTabla();
                lblEstado.Text = "Punto agregado. Total: " + _ctrl.ObtenerPuntos().Count + " puntos.";
                txtX.Clear(); txtY.Clear(); txtZ.Clear();
            }

            private void BtnCalcular_Click(object s, EventArgs e)
            {
                double nivel = 0;
                if (!double.TryParse(txtNivel.Text, out nivel))
                {
                    MessageBox.Show("Nivel de corte invalido.", "Error");
                    return;
                }

                _ctrl.SetNivelCorte(nivel);
                var (ok, vol, msg) = _ctrl.CalcularVolumen();

                if (ok)
                {
                    lblVolumen.Text = "Volumen:\n" + vol.ToString("F4") + " m³";
                    lblVolumen.ForeColor = Color.DarkGreen;
                    lblEstado.Text = "Calculo exitoso. Rote la grafica con el mouse.";

                    nivelCorteActual = nivel;
                    Terreno t = _ctrl.TerrenoActual;
                    xMin = t.XMin; xMax = t.XMax;
                    yMin = t.YMin; yMax = t.YMax;

                    PrecalcularMatrices();
                    glControl.Invalidate();
                }
                else
                {
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblVolumen.ForeColor = Color.Red;
                    lblVolumen.Text = msg;
                }
            }

            private void BtnLimpiar_Click(object s, EventArgs e)
            {
                _ctrl.LimpiarPuntos();
                dgvPuntos.Rows.Clear();
                lblVolumen.Text = "";
                lblEstado.Text = "";
                matrizAntes = null;
                matrizDespues = null;
                glControl.Invalidate();
            }

            private void BtnAntes_Click(object s, EventArgs e) { modoVista = 0; glControl.Invalidate(); }
            private void BtnDespues_Click(object s, EventArgs e) { modoVista = 1; glControl.Invalidate(); }
            private void BtnAmbos_Click(object s, EventArgs e) { modoVista = 2; glControl.Invalidate(); }

            private void RefrescarTabla()
            {
                dgvPuntos.Rows.Clear();
                foreach (PuntoTerreno p in _ctrl.ObtenerPuntos())
                    dgvPuntos.Rows.Add(p.x, p.y, p.z);
            }

            // ────────────────────────────────────────────────
            //  Precalculo de matrices
            // ────────────────────────────────────────────────
            private double InterpolarZ(double x, double y)
            {
                double sumaPeso = 0, sumaZPeso = 0;
                double epsilon = 1e-10;
                foreach (PuntoTerreno p in _ctrl.ObtenerPuntos())
                {
                    double dist = Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
                    if (dist < epsilon) return p.z;
                    double peso = 1.0 / (dist * dist);
                    sumaPeso += peso;
                    sumaZPeso += peso * p.z;
                }
                return sumaPeso > 0 ? sumaZPeso / sumaPeso : nivelCorteActual;
            }

            private void PrecalcularMatrices()
            {
                matrizAntes = new double[resolucion, resolucion];
                matrizDespues = new double[resolucion, resolucion];
                zMaxGlobal = 0;

                double dx = (xMax - xMin) / (resolucion - 1);
                double dy = (yMax - yMin) / (resolucion - 1);

                for (int i = 0; i < resolucion; i++)
                {
                    for (int j = 0; j < resolucion; j++)
                    {
                        double x = xMin + i * dx;
                        double y = yMin + j * dy;
                        double z = InterpolarZ(x, y);

                        // ANTES del corte: terreno original tal cual
                        matrizAntes[i, j] = z;

                        // DESPUES del corte: lo que supera el nivel queda plano en el nivel de corte
                        // lo que está por debajo permanece igual (no se toca)
                        if (z > nivelCorteActual)
                            matrizDespues[i, j] = nivelCorteActual;
                        else
                            matrizDespues[i, j] = z;

                        if (z > zMaxGlobal) zMaxGlobal = z;
                    }
                }

                if (zMaxGlobal < 0.001) zMaxGlobal = 1;
            }

            // ────────────────────────────────────────────────
            //  OpenGL
            // ────────────────────────────────────────────────
            private void GL_Load(object s, EventArgs e)
            {
                GL.ClearColor(0.08f, 0.08f, 0.10f, 1f);
                GL.Enable(EnableCap.DepthTest);
                GL.Enable(EnableCap.Lighting);
                GL.Enable(EnableCap.Light0);
                GL.Enable(EnableCap.ColorMaterial);
                GL.Enable(EnableCap.Normalize);
                GL.ShadeModel(ShadingModel.Smooth);

                GL.Light(LightName.Light0, LightParameter.Position,
                    new float[] { 1f, 2f, 2f, 0f });
                GL.Light(LightName.Light0, LightParameter.Ambient,
                    new float[] { 0.35f, 0.35f, 0.35f, 1f });
                GL.Light(LightName.Light0, LightParameter.Diffuse,
                    new float[] { 0.85f, 0.85f, 0.85f, 1f });

                ConfigurarProyeccion();
            }

            private void ConfigurarProyeccion()
            {
                if (glControl.Width <= 0 || glControl.Height <= 0) return;
                GL.Viewport(0, 0, glControl.Width, glControl.Height);
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadIdentity();
                double asp = (double)glControl.Width / glControl.Height;
                Matrix4d persp = Matrix4d.CreatePerspectiveFieldOfView(
                    MathHelper.DegreesToRadians(45), asp, 0.1, 2000.0);
                GL.LoadMatrix(ref persp);
                GL.MatrixMode(MatrixMode.Modelview);
            }

            private void GL_Resize(object s, EventArgs e)
            {
                ConfigurarProyeccion();
                glControl.Invalidate();
            }

            private void GL_Paint(object s, System.Windows.Forms.PaintEventArgs e)
            {
                glControl.MakeCurrent();
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                if (matrizAntes == null)
                {
                    // Mensaje de espera
                    glControl.SwapBuffers();
                    return;
                }

                GL.LoadIdentity();

                double cx = (xMin + xMax) / 2;
                double cy = (yMin + yMax) / 2;
                double cz = zMaxGlobal / 2;
                double tamano = Math.Max(xMax - xMin, yMax - yMin);
                double dist = tamano * 2.0 * zoomFactor;

                GL.Translate(0, 0, -dist);
                GL.Rotate(rotX, 1f, 0f, 0f);
                GL.Rotate(rotY, 0f, 0f, 1f);
                GL.Translate(-cx, -cy, -cz * 0.3);

                DibujarEjes(cx, cy);

                switch (modoVista)
                {
                    case 0: // Solo ANTES
                        DibujarSuperficie(matrizAntes, false);
                        DibujarPlanoCorte();
                        break;

                    case 1: // Solo DESPUES
                        DibujarSuperficie(matrizDespues, true);
                        DibujarPlanoCorte();
                        break;

                    case 2: // AMBOS
                        // Primero el terreno original (café)
                        DibujarSuperficie(matrizAntes, false);
                        // Encima el terreno después (verde)
                        DibujarSuperficie(matrizDespues, true);
                        // El material removido (zona entre ambas superficies)
                        DibujarMaterialRemovido();
                        // El plano de corte
                        DibujarPlanoCorte();
                        break;
                }

                glControl.SwapBuffers();
            }

            private void DibujarEjes(double cx, double cy)
            {
                GL.Disable(EnableCap.Lighting);
                GL.LineWidth(1.5f);
                GL.Begin(PrimitiveType.Lines);
                // X rojo
                GL.Color3(0.9f, 0.2f, 0.2f);
                GL.Vertex3(xMin, cy, 0); GL.Vertex3(xMax + 1, cy, 0);
                // Y verde
                GL.Color3(0.2f, 0.9f, 0.2f);
                GL.Vertex3(cx, yMin, 0); GL.Vertex3(cx, yMax + 1, 0);
                // Z azul
                GL.Color3(0.2f, 0.2f, 0.9f);
                GL.Vertex3(cx, cy, 0); GL.Vertex3(cx, cy, zMaxGlobal + 1);
                GL.End();
                GL.Enable(EnableCap.Lighting);
            }

            private void DibujarSuperficie(double[,] matriz, bool esDespues)
            {
                double dx = (xMax - xMin) / (resolucion - 1);
                double dy = (yMax - yMin) / (resolucion - 1);

                for (int i = 0; i < resolucion - 1; i++)
                {
                    for (int j = 0; j < resolucion - 1; j++)
                    {
                        double x0 = xMin + i * dx, y0 = yMin + j * dy;
                        double x1 = xMin + (i + 1) * dx, y1 = yMin + (j + 1) * dy;

                        double z00 = matriz[i, j];
                        double z10 = matriz[i + 1, j];
                        double z01 = matriz[i, j + 1];
                        double z11 = matriz[i + 1, j + 1];

                        // Normal para iluminación
                        Vector3d v1 = new Vector3d(x1 - x0, 0, z10 - z00);
                        Vector3d v2 = new Vector3d(0, y1 - y0, z01 - z00);
                        Vector3d n = Vector3d.Cross(v1, v2);
                        n.Normalize();

                        GL.Begin(PrimitiveType.Quads);
                        GL.Normal3(n);
                        SetColor(z00, esDespues); GL.Vertex3(x0, y0, z00);
                        SetColor(z10, esDespues); GL.Vertex3(x1, y0, z10);
                        SetColor(z11, esDespues); GL.Vertex3(x1, y1, z11);
                        SetColor(z01, esDespues); GL.Vertex3(x0, y1, z01);
                        GL.End();

                        // Cuadrícula fina
                        GL.Disable(EnableCap.Lighting);
                        GL.Color4(0f, 0f, 0f, 0.12f);
                        GL.LineWidth(0.4f);
                        GL.Begin(PrimitiveType.LineLoop);
                        GL.Vertex3(x0, y0, z00 + 0.01);
                        GL.Vertex3(x1, y0, z10 + 0.01);
                        GL.Vertex3(x1, y1, z11 + 0.01);
                        GL.Vertex3(x0, y1, z01 + 0.01);
                        GL.End();
                        GL.Enable(EnableCap.Lighting);
                    }
                }
            }

            private void SetColor(double z, bool esDespues)
            {
                double t = zMaxGlobal > 0 ? z / zMaxGlobal : 0;
                if (t < 0) t = 0; if (t > 1) t = 1;

                if (!esDespues)
                {
                    // ANTES: degradado café (oscuro en bajo, claro en alto)
                    GL.Color3(
                        0.30f + (float)(t * 0.45),
                        0.16f + (float)(t * 0.18),
                        0.04f + (float)(t * 0.05));
                }
                else
                {
                    // DESPUES: degradado verde (oscuro en bajo, claro en alto)
                    GL.Color3(
                        0.05f + (float)(t * 0.15),
                        0.30f + (float)(t * 0.50),
                        0.05f + (float)(t * 0.10));
                }
            }

            private void DibujarPlanoCorte()
            {
                GL.Disable(EnableCap.Lighting);
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

                // Relleno semitransparente
                GL.Color4(1f, 0.15f, 0.15f, 0.18f);
                GL.Begin(PrimitiveType.Quads);
                GL.Vertex3(xMin, yMin, nivelCorteActual);
                GL.Vertex3(xMax, yMin, nivelCorteActual);
                GL.Vertex3(xMax, yMax, nivelCorteActual);
                GL.Vertex3(xMin, yMax, nivelCorteActual);
                GL.End();

                // Borde
                GL.Color4(1f, 0.2f, 0.2f, 0.9f);
                GL.LineWidth(2f);
                GL.Begin(PrimitiveType.LineLoop);
                GL.Vertex3(xMin, yMin, nivelCorteActual);
                GL.Vertex3(xMax, yMin, nivelCorteActual);
                GL.Vertex3(xMax, yMax, nivelCorteActual);
                GL.Vertex3(xMin, yMax, nivelCorteActual);
                GL.End();

                GL.Disable(EnableCap.Blend);
                GL.Enable(EnableCap.Lighting);
            }

            private void DibujarMaterialRemovido()
            {
                // El material removido es la zona entre matrizAntes y matrizDespues
                // es decir, la parte que estaba por encima del nivel de corte
                GL.Disable(EnableCap.Lighting);
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

                double dx = (xMax - xMin) / (resolucion - 1);
                double dy = (yMax - yMin) / (resolucion - 1);

                for (int i = 0; i < resolucion - 1; i++)
                {
                    for (int j = 0; j < resolucion - 1; j++)
                    {
                        double zAntes00 = matrizAntes[i, j];
                        double zAntes10 = matrizAntes[i + 1, j];
                        double zAntes01 = matrizAntes[i, j + 1];
                        double zAntes11 = matrizAntes[i + 1, j + 1];

                        // Solo dibujar celdas donde hay material que remover
                        bool hayMaterial =
                            zAntes00 > nivelCorteActual ||
                            zAntes10 > nivelCorteActual ||
                            zAntes01 > nivelCorteActual ||
                            zAntes11 > nivelCorteActual;

                        if (!hayMaterial) continue;

                        double x0 = xMin + i * dx, y0 = yMin + j * dy;
                        double x1 = xMin + (i + 1) * dx, y1 = yMin + (j + 1) * dy;

                        // Cara superior: el terreno original (zona roja)
                        GL.Color4(0.9f, 0.15f, 0.15f, 0.45f);
                        GL.Begin(PrimitiveType.Quads);
                        GL.Vertex3(x0, y0, zAntes00);
                        GL.Vertex3(x1, y0, zAntes10);
                        GL.Vertex3(x1, y1, zAntes11);
                        GL.Vertex3(x0, y1, zAntes01);
                        GL.End();
                    }
                }

                GL.Disable(EnableCap.Blend);
                GL.Enable(EnableCap.Lighting);
            }

            // ── Mouse para rotar ──
            private void GL_MouseDown(object s, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                { arrastrando = true; ultimoMouse = e.Location; }
            }

            private void GL_MouseMove(object s, MouseEventArgs e)
            {
                if (!arrastrando) return;
                rotY += (e.X - ultimoMouse.X) * 0.5f;
                rotX += (e.Y - ultimoMouse.Y) * 0.5f;


                ultimoMouse = e.Location;
                glControl.Invalidate();
            }

            private void GL_MouseUp(object s, MouseEventArgs e)
            {
                arrastrando = false;
            }
            private void GL_MouseWheel(object s, MouseEventArgs e)
            {
                // Rueda hacia arriba (Delta positivo) = acercar
                // Rueda hacia abajo (Delta negativo) = alejar
                zoomFactor -= e.Delta * 0.001f;
                if (zoomFactor < 0.1f) zoomFactor = 0.1f;
                if (zoomFactor > 8.0f) zoomFactor = 8.0f;
                glControl.Invalidate();
            }
    }
}