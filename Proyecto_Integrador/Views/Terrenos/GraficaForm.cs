using HelixToolkit;
using HelixToolkit.Maths;
using HelixToolkit.Wpf.SharpDX;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using SharpDX;
using System.Windows.Media.Media3D;
using System.Numerics;




namespace Proyecto_Integrador.Views.Terrenos
{
    public partial class GraficaForm : Form
    {
        private Viewport3DX viewport;

        public GraficaForm()
        {
            InitializeComponent();

            viewport = new Viewport3DX();


            viewport.Camera = new PerspectiveCamera
            {
                Position = new System.Windows.Media.Media3D.Point3D(20, -30, 20),
                LookDirection = new System.Windows.Media.Media3D.Vector3D(-20, 30, -20),
                UpDirection = new System.Windows.Media.Media3D.Vector3D(0, 0, 1),
                FieldOfView = 45
            };


            // ✅ ESTO TE FALTABA (MUY IMPORTANTE)
            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;
            host.Child = viewport;

            this.Controls.Add(host);

            InitLights();
            DibujarTerreno();
        }

        // ✅ LUCES SHARPDX

        private void InitLights()
        {
            viewport.Items.Add(new DirectionalLight3D()
            {
                Color = System.Windows.Media.Colors.White,
                Direction = new Vector3D(-1, -1, -1)
            });

            viewport.Items.Add(new AmbientLight3D()
            {
                Color = System.Windows.Media.Color.FromRgb(80, 80, 80)
            });
        }
        private Color4 AlturaColor(float z, float min, float max, double h)
        {
            float t = (z - min) / (max - min);

            if (z > h)
                return new Color4(1f, 0.3f, 0.1f, 1f); // rojo
            else
                return new Color4(0.2f, 0.7f, 0.3f, 1f); // verde
        }

        // ✅ TERRENO 3D (versión equivalente a tu código)
        private void DibujarTerreno()
        {
            int filas = 6;
            int cols = 6;
            double dx = 5;
            double dy = 5;
            double h = 10;

            var posiciones = new Vector3Collection();
            var indices = new IntCollection();
            var colores = new Color4Collection();

            double[,] alturas = new double[,]
            {
        {8.1, 7.0, 9.8, 12.3, 10.3, 7.9},
        {9.1, 9.0, 9.7, 9.7, 9.5, 7.5},
        {11.1, 11.1, 11.6, 10.0, 10.0, 7.5},
        {9.6, 10.5, 11.0, 9.8, 9.3, 8.0},
        {8.5, 9.0, 9.5, 8.7, 8.2, 7.9},
        {7.5, 8.2, 8.8, 8.0, 7.6, 7.2}
            };

            float zMin = 7f;
            float zMax = 13f;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    float z = (float)alturas[i, j];

                    posiciones.Add(new Vector3(
                        (float)(j * dx),
                        (float)(i * dy),
                        z
                    ));

                    colores.Add(AlturaColor(z, zMin, zMax, h));
                }
            }

            for (int i = 0; i < filas - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    int i0 = i * cols + j;
                    int i1 = i * cols + j + 1;
                    int i2 = (i + 1) * cols + j + 1;
                    int i3 = (i + 1) * cols + j;

                    indices.Add(i0); indices.Add(i1); indices.Add(i2);
                    indices.Add(i0); indices.Add(i2); indices.Add(i3);
                }
            }

            var mesh = new HelixToolkit.Wpf.SharpDX.MeshGeometry3D()
            {
                Positions = posiciones,
                Indices = indices,
                Colors = colores
            };


            var model = new MeshGeometryModel3D()
            {
                Geometry = mesh,
                Material = PhongMaterials.White,
                VertexColorBlendingFactor = 1.0
            };

            viewport.Items.Add(model);
        }
    }
}
