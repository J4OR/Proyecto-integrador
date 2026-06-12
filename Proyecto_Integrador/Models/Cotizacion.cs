using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Cotizacion
    {
        public string id { get; set; }
        public Cliente cliente { get; set; }
        public List<Terreno> terrenos { get; set; }
        public List<Material> materiales { get; set; }
        public double PrecioIva { get; set; }
        public double subTotal { get; set; }
        public double total { get; set; }
        public DateTime fecha { get; set; }
        public bool estado { get; set; }

        [JsonConstructor]

        public Cotizacion(string id, Cliente cliente, List<Terreno> terrenos, List<Material> materiales, double precioIva, 
        double subtotal, double total, bool estado = true)
        {
            this.id = id;
            this.cliente = cliente;
            this.terrenos = terrenos;
            this.materiales = materiales;
            this.PrecioIva = precioIva;
            this.subTotal = subtotal;
            this.total = total;
            this.fecha = fecha;
            this.estado = estado;
        }
    }
}