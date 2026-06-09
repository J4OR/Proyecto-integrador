using HelixToolkit;
using HelixToolkit.Maths;
using HelixToolkit.SharpDX;
using HelixToolkit.Wpf.SharpDX;
using SharpDX;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Media3D;




namespace Proyecto_Integrador.Views.Terrenos
{
    public partial class GraficaForm : Form
    {
        private Viewport3DX viewport;
        private double dx, dy, h;
        private double[][] alturas;

        public GraficaForm(double[][] alturas, double dx, double dy, double h)
        {
            InitializeComponent();
            this.alturas = alturas;
            this.dx = dx;
            this.dy = dy;
            this.h = h;
            viewport = new Viewport3DX();

            var effectsManager = new DefaultEffectsManager();
            viewport.EffectsManager = effectsManager;

            viewport.BackgroundColor = System.Windows.Media.Color.FromRgb(200, 200, 200);

            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;

            host.Child = viewport;

            this.Controls.Add(host);
            InitLights();

        }

        //Inicializar las luces para la escena 3D
        private void InitLights()
        {

            viewport.Items.Add(new AmbientLight3D
            {
                Color = System.Windows.Media.Colors.White
            });
            viewport.Items.Add(new DirectionalLight3D
            {
                Color = System.Windows.Media.Color.FromRgb(255, 255, 255),
                Direction = new System.Windows.Media.Media3D.Vector3D(0.3, 0.5, 1)
            });
            viewport.Items.Add(new DirectionalLight3D
            {
                Color = System.Windows.Media.Color.FromRgb(100, 100, 120),
                Direction = new System.Windows.Media.Media3D.Vector3D(-1, -0.5, -0.8)
            });
        }
    }
}
