using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Factura
    {
        public string id { get; set; }
        public Cotizacion cotizacion { get; set; } 
        public DateTime fecha { get; set; }
        public bool estado { get; set; }

        [JsonConstructor]
        public Factura(string id, Cotizacion cotizacion, DateTime fechaEmision)
        {
            this.id = id;
            this.cotizacion = cotizacion;
            this.fecha = fecha;
            this.estado = true;
        }
    }
}
