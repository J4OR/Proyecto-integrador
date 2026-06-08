using HelixToolkit.Wpf.SharpDX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;


namespace Proyecto_Integrador.Views.Terrenos
{
    public partial class GraficaForm : Form
    {
        public GraficaForm()
        {
            InitializeComponent();

            var viewport = new Viewport3DX();
            var camera = new PerspectiveCamera()
            {
                Position = new System.Windows.Media.Media3D.Point3D(0, 0, 5),
                LookDirection = new System.Windows.Media.Media3D.Vector3D(0, 0, -1),
                UpDirection = new System.Windows.Media.Media3D.Vector3D(0, 1, 0),
                FieldOfView = 45
            };

            viewport.Camera = camera;

            // No usar 'Content' en un Form de WinForms.
            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;

            // Alojar el control WPF dentro del ElementHost
            host.Child = viewport;

            this.Controls.Add(host);

        }
    }
}
