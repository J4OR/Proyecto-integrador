using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{

    public class Terreno
    {
        public Guid id { get; set; }
        public string nombre { get; set; }

        // Malla de alturas z[i][j] ingresada por el usuario
        public double[][] cotas { get; set; }

        // Espaciado entre nodos en X y en Y (metros)
        public double dx { get; set; }
        public double dy { get; set; }

        // Nivel de corte / altura de referencia
        public double alturaReferencia { get; set; }

        // Resultado del cálculo
        public double volumen { get; set; }

        [JsonConstructor]
        public Terreno (double[][] cotas, double dx, double dy, double alturaReferencia, double volumen = 0, string nombre = "")
        {
            this.id = Guid.NewGuid();
            this.nombre = nombre;
            this.cotas = cotas;
            this.dx = dx;
            this.dy = dy;
            this.alturaReferencia = alturaReferencia;
            this.volumen = volumen;
        }
    }
}
