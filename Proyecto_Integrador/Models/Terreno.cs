using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public enum TipoOperacion
    {
        Remover, Rellenar, Ambos
    }
    public class Terreno
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public TipoOperacion operacion { get; set; }

        public double[][] cotas { get; set; }

        public double dx { get; set; }
        public double dy { get; set; }

        public double alturaReferencia { get; set; }

        public double volumen { get; set; }

        [JsonConstructor]
        public Terreno (TipoOperacion operacion, double[][] cotas, double dx, double dy, double alturaReferencia, double volumen = 0, string nombre = "")
        {
            this.id = Guid.NewGuid();
            this.nombre = nombre;
            this.operacion = operacion;
            this.cotas = cotas;
            this.dx = dx;
            this.dy = dy;
            this.alturaReferencia = alturaReferencia;
            this.volumen = volumen;
        }
    }
}
