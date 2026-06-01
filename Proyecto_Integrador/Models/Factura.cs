using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Factura
    {
        public string id { get; set; }
        public string numero { get; set; }
        public Cotizacion cotizacion { get; set; } 
        public DateTime fechaEmision { get; set; }
        public string estado { get; set; }
        public string observaciones { get; set; }
        public string usuarioQueFacturo { get; set; }

        [JsonConstructor]
        public Factura( )
        {
           
        }
    }
}
