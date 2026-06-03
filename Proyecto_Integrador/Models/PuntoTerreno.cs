using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    /// <summary>
    /// Representa un punto 3D del terreno (x, y, z) donde z es la altura.
    /// </summary>
    public class PuntoTerreno
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        [JsonConstructor]
        public PuntoTerreno(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
