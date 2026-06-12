using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public enum TipoOperacion
    {
        Excavar, Remover, Rellenar, Mixto
    }
    public class Terreno
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public Cliente cliente { get; set; }
        public TipoOperacion operacion { get; set; }

        public double[][] cotas { get; set; }

        public double dx { get; set; }
        public double dy { get; set; }

        public double alturaReferencia { get; set; }

        public double volumen { get; set; }

        [JsonConstructor]
        public Terreno (TipoOperacion operacion, double[][] cotas, double dx, double dy, double alturaReferencia, 
            double volumen = 0, string nombre = "", Cliente cliente = null)
        {
            this.id = Guid.NewGuid();
            this.nombre = nombre;
            this.operacion = operacion;
            this.cotas = cotas;
            this.dx = dx;
            this.dy = dy;
            this.alturaReferencia = alturaReferencia;
            this.volumen = volumen;
            this.cliente = cliente;
        }
    }
}
