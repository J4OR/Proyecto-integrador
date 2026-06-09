using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Material
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precioUnidad { get; set; }
        public bool estado { get; set; }
        public string estadoTexto
        {
            get
            {
                return estado ? "Activo" : "Inactivo";
            }
        }

        [JsonConstructor]
        public Material(int id, string nombre, double precioUnidad, bool estado = true)
        {
            this.id = id;
            this.nombre = nombre;
            this.precioUnidad = precioUnidad;
            this.estado = estado;
        }
    }
}
