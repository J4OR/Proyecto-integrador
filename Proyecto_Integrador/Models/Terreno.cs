using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Models
{

    public class Terreno
    {
        public string id { get; set; }
        public string descripcion { get; set; }
        public List<PuntoTerreno> puntos { get; set; }

        // Límites del área rectangular analizada
        public double XMin { get; set; }
        public double XMax { get; set; }
        public double YMin { get; set; }
        public double YMax { get; set; }

        // Nivel de corte (profundidad objetivo o nivel final deseado)
        public double NivelCorte { get; set; }
        public double volumen { get; set; }

        public Terreno(List<PuntoTerreno> puntos, double xMin, double xMax, double yMin, double yMax, double nivelCorte)
        {
            this.id = Guid.NewGuid().ToString();
            this.puntos = puntos;
            this.XMin = xMin;
            this.XMax = xMax;
            this.YMin = yMin;
            this.YMax = yMax;
            this.NivelCorte = nivelCorte;
        }
    }
}
