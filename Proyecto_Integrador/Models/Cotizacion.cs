using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Cotizacion
    {
        public string id { get; set; }
        public int numero { get; set; }
        public Cliente cliente { get; set; }
        public Terreno terreno { get; set; }
        public Material material { get; set; }
        public double costoTotal { get; set; }
        public DateTime fecha { get; set; }
        public string estado { get; set; }
        public string observaciones { get; set; }

        [JsonConstructor]
        public Cotizacion(string id,Cliente cliente, Terreno terreno,Material material, DateTime fecha, string estado, string observaciones)
        {
            this.id = id;
            this.cliente = cliente;
            this.terreno = terreno;
            this.material = material;
            this.costoTotal = material.precioUnidad * terreno.volumen;
            this.fecha = fecha;
            this.estado = estado;
            this.observaciones = observaciones;
        }
    }
}
