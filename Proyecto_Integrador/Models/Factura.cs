using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Factura
    {
        public string id { get; set; }
        public string observacion { get; set; }
        public DateTime fecha { get; set; }
        public Cotizacion cotizacion { get; set; } 
        public double precioIva { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }

        public bool estado { get; set; }
        

        [JsonConstructor]
        public Factura(string id, DateTime fecha, Cotizacion cotizacion, double precioIva , double subtotal, double total, string observacion = " ")
        {
            this.id = id;
            this.observacion = observacion;
            this.cotizacion = cotizacion;
            this.fecha = fecha;
            this.cotizacion = cotizacion;
            this.precioIva = precioIva;
            this.subtotal = subtotal;
            this.total = total;
            this.estado = true;
        }
    }
}
