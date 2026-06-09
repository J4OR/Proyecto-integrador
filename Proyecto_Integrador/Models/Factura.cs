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
        public List<ItemFactura> items { get; set; }
        public bool estado { get; set; }
        public decimal subtotal => items.Sum(i => i.valorTotal);

        [JsonConstructor]
        public Factura(string id, Cotizacion cotizacion, DateTime fechaEmision)
        {
            this.id = id;
            this.cotizacion = cotizacion;
            this.fecha = fecha;
            this.estado = true;
        }
        public class ItemFactura
        {
            public string descripcion { get; set; }
            public string unidad { get; set; }
            public decimal cantidad { get; set; }
            public decimal valorUnitario { get; set; }
            public decimal valorTotal => cantidad * valorUnitario;
        }
    }
}
