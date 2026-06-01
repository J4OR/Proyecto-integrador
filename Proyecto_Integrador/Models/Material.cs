using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Material
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public double CostoPorUnidad { get; set; } // Costo por m³

        public Material() { Id = Guid.NewGuid().ToString(); }

        [JsonConstructor]
        public Material(string nombre, double costoPorUnidad)
        {
            Id = Guid.NewGuid().ToString();
            Nombre = nombre;
            CostoPorUnidad = costoPorUnidad;
        }

        public override string ToString() => $"{Nombre} - ${CostoPorUnidad:F2}/m³";
    }
}
