using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Models
{
    public enum EstadoCotizacion { Activa, Inactiva }
    public enum EstadoFactura { Activa, Inactiva }
    public class Cotizacion
    {
        public string Id { get; set; }
        public string ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string MaterialId { get; set; }
        public string NombreMaterial { get; set; }
        public double VolumenM3 { get; set; }
        public double CostoPorM3 { get; set; }
        public double Total => VolumenM3 * CostoPorM3;
        public DateTime Fecha { get; set; }
        public EstadoCotizacion Estado { get; set; }
        public string Descripcion { get; set; }

        public Cotizacion()
        {
            Id = Guid.NewGuid().ToString();
            Fecha = DateTime.Now;
            Estado = EstadoCotizacion.Activa;
        }
    }

    public class Factura
    {
        public string Id { get; set; }
        public string CotizacionId { get; set; }
        public string ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string MaterialNombre { get; set; }
        public double VolumenM3 { get; set; }
        public double CostoPorM3 { get; set; }
        public double Total => VolumenM3 * CostoPorM3;
        public DateTime Fecha { get; set; }
        public EstadoFactura Estado { get; set; }

        public Factura()
        {
            Id = Guid.NewGuid().ToString();
            Fecha = DateTime.Now;
            Estado = EstadoFactura.Activa;
        }

        public static Factura DesdeCotizacion(Cotizacion c)
        {
            return new Factura
            {
                CotizacionId = c.Id,
                ClienteId = c.ClienteId,
                NombreCliente = c.NombreCliente,
                MaterialNombre = c.NombreMaterial,
                VolumenM3 = c.VolumenM3,
                CostoPorM3 = c.CostoPorM3,
                Fecha = DateTime.Now,
                Estado = EstadoFactura.Activa
            };
        }
    }
}
