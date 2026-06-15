using HelixToolkit.Geometry;
using HelixToolkit.Wpf;
using System;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Color = System.Windows.Media.Color;
using WpfMesh = System.Windows.Media.Media3D.MeshGeometry3D;

namespace Proyecto_Integrador.Views.Terrenos
{
    public partial class GraficaForm : Form
    {

        private readonly double[][] alturas;
        private double h, dx, dy;
        private HelixViewport3D _viewport;
        private double _zMin, _zMax;
        private double hSliderMin, hSliderMax;
        private bool _mostrarPuntos = true;
        private bool _mostrarEtiquetas = true;
        private bool _inicializando = true;
        private bool modoSoloLectura;


        public double HFinal => h;
        public double DxFinal => dx;
        public double DyFinal => dy;



        private const int SUB = 3;

        public GraficaForm(double[][] alturas, double h, double dx, double dy, bool modoLectura = false)
        {
            this.modoSoloLectura = modoLectura;
            this.alturas = alturas;
            this.h = h;
            this.dx = dx;
            this.dy = dy;

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            _viewport = new HelixViewport3D
            {
                Background = new LinearGradientBrush(
                    Color.FromRgb(18, 28, 48),
                    Color.FromRgb(6, 10, 20),
                    90),
                ShowCoordinateSystem = true,
                ShowViewCube = true
            };
            host.Child = _viewport;

            InitLights();
            BuildScene();
            InitSliders();
            _inicializando = false;
            ResetCamera();
            AplicarModo();
        }

        private void AplicarModo()
        {
            if (modoSoloLectura)
            {
                panelControles.Visible = false;
            }
        }

        private void InitLights()
        {
            _viewport.Children.Add(new SunLight());
            _viewport.Children.Add(new ModelVisual3D
            {
                Content = new AmbientLight(Color.FromRgb(65, 65, 70))
            });
            _viewport.Children.Add(new ModelVisual3D
            {
                Content = new DirectionalLight(
                    Color.FromRgb(70, 80, 110),
                    new Vector3D(-1, -0.5, -0.8))
            });
        }

        private void InitSliders()
        {
            double rangoZ = Math.Max(_zMax - _zMin, 0.001);
            hSliderMin = _zMin - rangoZ * 0.3;
            hSliderMax = _zMax + rangoZ * 0.3;

            trkH.Value = Math.Max(0, Math.Min(1000,
                (int)((h - hSliderMin) / (hSliderMax - hSliderMin) * 1000)));
            lblHVal.Text = $"{h:F1} m";

            trkDx.Value = Math.Max(1, Math.Min(100, (int)(dx * 2)));
            lblDxVal.Text = $"{dx:F1} m";

            trkDy.Value = Math.Max(1, Math.Min(100, (int)(dy * 2)));
            lblDyVal.Text = $"{dy:F1} m";

            chkPuntos.Checked = _mostrarPuntos;
            chkEtiquetas.Checked = _mostrarEtiquetas;
        }

        private void btnReset_Click(object sender, EventArgs e) => ResetCamera();

        private void trkH_Scroll(object sender, EventArgs e)
        {
            if (_inicializando) return;
            h = hSliderMin + (double)trkH.Value / 1000.0 * (hSliderMax - hSliderMin);
            lblHVal.Text = $"{h:F1} m";
            RebuildScene();
        }

        private void trkDx_Scroll(object sender, EventArgs e)
        {
            if (_inicializando) return;
            dx = trkDx.Value / 2.0;
            lblDxVal.Text = $"{dx:F1} m";
            RebuildScene();
        }

        private void trkDy_Scroll(object sender, EventArgs e)
        {
            if (_inicializando) return;
            dy = trkDy.Value / 2.0;
            lblDyVal.Text = $"{dy:F1} m";
            RebuildScene();
        }

        private void chkPuntos_CheckedChanged(object sender, EventArgs e)
        {
            if (_inicializando) return;
            _mostrarPuntos = chkPuntos.Checked;
            RebuildScene();
        }

        private void chkEtiquetas_CheckedChanged(object sender, EventArgs e)
        {
            if (_inicializando) return;
            _mostrarEtiquetas = chkEtiquetas.Checked;
            RebuildScene();
        }

        private void RebuildScene()
        {
            _viewport.Children.Clear();
            InitLights();
            BuildScene();
        }

        private void BuildScene()
        {
            int filas = alturas.Length;
            int cols = filas > 0 ? alturas[0].Length : 0;
            double xMax = (cols - 1) * dx;
            double yMax = (filas - 1) * dy;

            double zMin = double.MaxValue, zMax = double.MinValue;
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < cols; j++)
                {
                    if (alturas[i][j] < zMin) zMin = alturas[i][j];
                    if (alturas[i][j] > zMax) zMax = alturas[i][j];
                }
            _zMin = zMin;
            _zMax = zMax;

            double rangoZ = Math.Max(zMax - zMin, 0.001);
            double zBase = zMin - rangoZ * 0.12;
            double lift = rangoZ * 0.008 + 0.02;
            double rSfera = Math.Min(dx, dy) * 0.07;
            double offLbl = Math.Min(dx, dy) * 0.65;

            // 1. Terreno con subdivisión bilineal (SUB×SUB por celda)
            for (int i = 0; i < filas - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    double x0 = j * dx, x1 = (j + 1) * dx;
                    double y0 = i * dy, y1 = (i + 1) * dy;
                    double z00 = alturas[i][j];
                    double z10 = alturas[i][j + 1];
                    double z11 = alturas[i + 1][j + 1];
                    double z01 = alturas[i + 1][j];

                    for (int si = 0; si < SUB; si++)
                    {
                        for (int sj = 0; sj < SUB; sj++)
                        {
                            double u0 = (double)sj / SUB;
                            double u1 = (double)(sj + 1) / SUB;
                            double v0 = (double)si / SUB;
                            double v1 = (double)(si + 1) / SUB;

                            var p00 = BLineal(x0, y0, x1, y1, z00, z10, z01, z11, u0, v0);
                            var p10 = BLineal(x0, y0, x1, y1, z00, z10, z01, z11, u1, v0);
                            var p11 = BLineal(x0, y0, x1, y1, z00, z10, z01, z11, u1, v1);
                            var p01 = BLineal(x0, y0, x1, y1, z00, z10, z01, z11, u0, v1);

                            double zAvg = (p00.Z + p10.Z + p11.Z + p01.Z) / 4.0;
                            var col = AlturaAColor(zAvg, zMin, zMax);
                            var mb = new MeshBuilder();
                            mb.AddTriangle(ToV3(p00), ToV3(p10), ToV3(p11));
                            mb.AddTriangle(ToV3(p00), ToV3(p11), ToV3(p01));
                            AddMesh(mb, new DiffuseMaterial(new SolidColorBrush(col)));
                        }
                    }
                }
            }

            // 2. Líneas de cuadrícula (nodos originales)
            var pts = new Point3DCollection();
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < cols - 1; j++)
                {
                    pts.Add(new Point3D(j * dx, i * dy, alturas[i][j] + lift));
                    pts.Add(new Point3D((j + 1) * dx, i * dy, alturas[i][j + 1] + lift));
                }
            for (int j = 0; j < cols; j++)
                for (int i = 0; i < filas - 1; i++)
                {
                    pts.Add(new Point3D(j * dx, i * dy, alturas[i][j] + lift));
                    pts.Add(new Point3D(j * dx, (i + 1) * dy, alturas[i + 1][j] + lift));
                }
            _viewport.Children.Add(new LinesVisual3D
            {
                Color = Color.FromArgb(130, 255, 255, 255),
                Thickness = 1.0,
                Points = pts
            });

            // 3. Esferas en los nodos
            if (_mostrarPuntos)
            {
                var mbS = new MeshBuilder();
                for (int i = 0; i < filas; i++)
                    for (int j = 0; j < cols; j++)
                        mbS.AddSphere(
                            ToV3(new Point3D(j * dx, i * dy, alturas[i][j])),
                            (float)rSfera, 8, 6);
                AddMesh(mbS, new DiffuseMaterial(new SolidColorBrush(Colors.White)));
            }

            // 4. Etiquetas de altura en cada nodo
            if (_mostrarEtiquetas)
            {
                for (int i = 0; i < filas; i++)
                    for (int j = 0; j < cols; j++)
                        _viewport.Children.Add(new BillboardTextVisual3D
                        {
                            Text = alturas[i][j].ToString("F1"),
                            Position = new Point3D(j * dx, i * dy,
                                                     alturas[i][j] + rSfera * 2.5 + lift),
                            FontSize = 11,
                            Foreground = new SolidColorBrush(Colors.White),
                            Background = new SolidColorBrush(Color.FromArgb(120, 10, 15, 40))
                        });
            }

            // 5. Etiquetas eje X con Δx
            double zLbl = zBase - rangoZ * 0.04;

            for (int j = 0; j < cols; j++)
                _viewport.Children.Add(new BillboardTextVisual3D
                {
                    Text = $"X{j + 1} ({j * dx:F0} m)",
                    Position = new Point3D(j * dx, -offLbl, zLbl),
                    FontSize = 10,
                    Foreground = new SolidColorBrush(Color.FromRgb(255, 140, 140)),
                    Background = new SolidColorBrush(Color.FromArgb(100, 40, 0, 0))
                });

            if (cols >= 2)
                _viewport.Children.Add(new BillboardTextVisual3D
                {
                    Text = $"Δx = {dx:F1} m",
                    Position = new Point3D(dx / 2.0, -offLbl * 1.9, zLbl),
                    FontSize = 10,
                    Foreground = new SolidColorBrush(Color.FromRgb(255, 190, 80)),
                    Background = new SolidColorBrush(Color.FromArgb(130, 50, 30, 0))
                });

            // 6. Etiquetas eje Y con Δy
            for (int i = 0; i < filas; i++)
                _viewport.Children.Add(new BillboardTextVisual3D
                {
                    Text = $"Y{i + 1} ({i * dy:F0} m)",
                    Position = new Point3D(-offLbl, i * dy, zLbl),
                    FontSize = 10,
                    Foreground = new SolidColorBrush(Color.FromRgb(130, 230, 130)),
                    Background = new SolidColorBrush(Color.FromArgb(100, 0, 40, 0))
                });

            if (filas >= 2)
                _viewport.Children.Add(new BillboardTextVisual3D
                {
                    Text = $"Δy = {dy:F1} m",
                    Position = new Point3D(-offLbl * 1.9, dy / 2.0, zLbl),
                    FontSize = 10,
                    Foreground = new SolidColorBrush(Color.FromRgb(110, 220, 80)),
                    Background = new SolidColorBrush(Color.FromArgb(130, 0, 50, 0))
                });

            // 7. Etiqueta del plano de corte h
            _viewport.Children.Add(new BillboardTextVisual3D
            {
                Text = $"  h = {h:F1} m  ",
                Position = new Point3D(xMax + offLbl, yMax / 2.0, h),
                FontSize = 13,
                Foreground = new SolidColorBrush(Color.FromRgb(255, 230, 50)),
                Background = new SolidColorBrush(Color.FromArgb(150, 50, 40, 0))
            });

            // 8. Paredes laterales
            var matPared = new DiffuseMaterial(
                new SolidColorBrush(Color.FromRgb(100, 85, 60)));

            for (int j = 0; j < cols - 1; j++)   // Norte
            {
                double x0 = j * dx, x1 = (j + 1) * dx;
                var mb = new MeshBuilder();
                mb.AddTriangle(ToV3(x0, 0, alturas[0][j]),
                               ToV3(x1, 0, alturas[0][j + 1]),
                               ToV3(x1, 0, zBase));
                mb.AddTriangle(ToV3(x0, 0, alturas[0][j]),
                               ToV3(x1, 0, zBase),
                               ToV3(x0, 0, zBase));
                AddMesh(mb, matPared);
            }
            for (int j = 0; j < cols - 1; j++)   // Sur
            {
                double x0 = j * dx, x1 = (j + 1) * dx, yS = (filas - 1) * dy;
                var mb = new MeshBuilder();
                mb.AddTriangle(ToV3(x0, yS, alturas[filas - 1][j]),
                               ToV3(x1, yS, zBase),
                               ToV3(x1, yS, alturas[filas - 1][j + 1]));
                mb.AddTriangle(ToV3(x0, yS, alturas[filas - 1][j]),
                               ToV3(x0, yS, zBase),
                               ToV3(x1, yS, zBase));
                AddMesh(mb, matPared);
            }
            for (int i = 0; i < filas - 1; i++)  // Oeste
            {
                double y0 = i * dy, y1 = (i + 1) * dy;
                var mb = new MeshBuilder();
                mb.AddTriangle(ToV3(0, y0, alturas[i][0]),
                               ToV3(0, y0, zBase),
                               ToV3(0, y1, zBase));
                mb.AddTriangle(ToV3(0, y0, alturas[i][0]),
                               ToV3(0, y1, zBase),
                               ToV3(0, y1, alturas[i + 1][0]));
                AddMesh(mb, matPared);
            }
            for (int i = 0; i < filas - 1; i++)  // Este
            {
                double y0 = i * dy, y1 = (i + 1) * dy, xE = (cols - 1) * dx;
                var mb = new MeshBuilder();
                mb.AddTriangle(ToV3(xE, y0, alturas[i][cols - 1]),
                               ToV3(xE, y1, zBase),
                               ToV3(xE, y0, zBase));
                mb.AddTriangle(ToV3(xE, y0, alturas[i][cols - 1]),
                               ToV3(xE, y1, alturas[i + 1][cols - 1]),
                               ToV3(xE, y1, zBase));
                AddMesh(mb, matPared);
            }

            // 9. Base
            var mbBase = new MeshBuilder();
            mbBase.AddTriangle(ToV3(0, 0, zBase),
                               ToV3(xMax, yMax, zBase),
                               ToV3(xMax, 0, zBase));
            mbBase.AddTriangle(ToV3(0, 0, zBase),
                               ToV3(0, yMax, zBase),
                               ToV3(xMax, yMax, zBase));
            AddMesh(mbBase, new DiffuseMaterial(
                new SolidColorBrush(Color.FromRgb(55, 45, 30))));

            // 10. Plano de corte h (semitransparente, dos caras)
            var mbPlano = new MeshBuilder();
            mbPlano.AddTriangle(ToV3(0, 0, h), ToV3(xMax, 0, h), ToV3(xMax, yMax, h));
            mbPlano.AddTriangle(ToV3(0, 0, h), ToV3(xMax, yMax, h), ToV3(0, yMax, h));
            mbPlano.AddTriangle(ToV3(0, 0, h), ToV3(xMax, yMax, h), ToV3(xMax, 0, h));
            mbPlano.AddTriangle(ToV3(0, 0, h), ToV3(0, yMax, h), ToV3(xMax, yMax, h));
            AddMesh(mbPlano, new DiffuseMaterial(
                new SolidColorBrush(Color.FromArgb(95, 240, 220, 80))));

            // 11. Borde del plano de corte
            _viewport.Children.Add(new LinesVisual3D
            {
                Color = Color.FromRgb(240, 210, 40),
                Thickness = 2.5,
                Points = new Point3DCollection
                {
                    new Point3D(0,    0,    h), new Point3D(xMax, 0,    h),
                    new Point3D(xMax, 0,    h), new Point3D(xMax, yMax, h),
                    new Point3D(xMax, yMax, h), new Point3D(0,    yMax, h),
                    new Point3D(0,    yMax, h), new Point3D(0,    0,    h)
                }
            });
        }

        private static Point3D BLineal(
            double x0, double y0, double x1, double y1,
            double z00, double z10, double z01, double z11,
            double u, double v)
        {
            return new Point3D(
                x0 + u * (x1 - x0),
                y0 + v * (y1 - y0),
                (1 - u) * (1 - v) * z00
              + u * (1 - v) * z10
              + (1 - u) * v * z01
              + u * v * z11);
        }

        private Color AlturaAColor(double z, double zMin, double zMax)
        {
            double rango = zMax - zMin;
            if (rango < 0.001) return Color.FromRgb(150, 150, 150);

            double t = Math.Max(0, Math.Min(1, (z - zMin) / rango));
            double tH = Math.Max(0, Math.Min(1, (h - zMin) / rango));

            if (t <= tH)
            {
                double s = tH > 0 ? t / tH : 1.0;
                return Color.FromRgb(
                    (byte)(20 + s * 60),
                    (byte)(70 + s * 140),
                    (byte)(160 - s * 110));
            }
            else
            {
                double s = tH < 1 ? (t - tH) / (1 - tH) : 1.0;
                return Color.FromRgb(
                    (byte)(240 - s * 40),
                    (byte)(200 - s * 175),
                    (byte)(50 - s * 45));
            }
        }

        // Convierte el MeshBuilder de Helix 3.x (Vector3/float) a MeshGeometry3D de WPF
        private void AddMesh(MeshBuilder mb, Material mat)
        {
            var geom = mb.ToMesh();
            if (geom == null || geom.Positions == null || geom.Positions.Count == 0) return;

            var wpfMesh = new WpfMesh();
            foreach (var v in geom.Positions)
                wpfMesh.Positions.Add(new Point3D(v.X, v.Y, v.Z));
            foreach (var idx in geom.TriangleIndices)
                wpfMesh.TriangleIndices.Add(idx);

            _viewport.Children.Add(new ModelVisual3D
            {
                Content = new GeometryModel3D(wpfMesh, mat) { BackMaterial = mat }
            });
        }

        private void ResetCamera()
        {
            int filas = alturas.Length;
            int cols = filas > 0 ? alturas[0].Length : 0;
            double cx = (cols - 1) * dx / 2.0;
            double cy = (filas - 1) * dy / 2.0;
            double zCenter = (_zMin + _zMax) / 2.0;
            double diag = Math.Sqrt(
                Math.Pow((cols - 1) * dx, 2) +
                Math.Pow((filas - 1) * dy, 2));
            double dist = diag * 1.5 + 10;

            _viewport.Camera = new PerspectiveCamera
            {
                Position = new Point3D(cx - dist * 0.2,
                                                cy - dist * 0.85,
                                                zCenter + dist * 0.65),
                LookDirection = new Vector3D(dist * 0.2,
                                                 dist * 0.85,
                                                 -(dist * 0.65 - (_zMax - zCenter) * 0.4)),
                UpDirection = new Vector3D(0, 0, 1),
                FieldOfView = 48,
                NearPlaneDistance = 0.01,
                FarPlaneDistance = 100000
            };
        }

        // Helpers para convertir coordenadas double a Vector3 (float) de HelixToolkit.Geometry
        private static Vector3 ToV3(Point3D p) => new((float)p.X, (float)p.Y, (float)p.Z);
        private static Vector3 ToV3(double x, double y, double z) => new((float)x, (float)y, (float)z);


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
    