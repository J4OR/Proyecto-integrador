using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;

namespace Proyecto_Integrador.Controller
{
    public class FacturaController
    {
        private readonly FacturaRepository repository;
        private List<Factura> facturas;

        public FacturaController(string rutaDatos)
        {
            repository = new FacturaRepository(
                Path.Combine(rutaDatos, "facturas.json"));

            facturas = repository.Leer();
        }

        public (bool ok, Factura factura, string mensaje)
            ConvertirDesde(Cotizacion cotizacion)
        {
            if (cotizacion == null)
                return (false, null, "Cotización inválida.");

            Factura factura =
                Factura.DesdeCotizacion(cotizacion);

            facturas.Add(factura);

            repository.Guardar(facturas);

            return (true,
                    factura,
                    $"Factura generada. Total: ${factura.Total:F2}");
        }

        public List<Factura> ObtenerTodas()
        {
            return facturas;
        }

        public Factura ObtenerPorId(string id)
        {
            return facturas.Find(f => f.Id == id);
        }

        public List<Factura> Filtrar(
            string clienteId,
            DateTime? desde,
            DateTime? hasta,
            EstadoFactura? estado)
        {
            return facturas.FindAll(f =>
                (string.IsNullOrEmpty(clienteId) ||
                 f.ClienteId == clienteId)
                &&
                (!desde.HasValue ||
                 f.Fecha >= desde.Value)
                &&
                (!hasta.HasValue ||
                 f.Fecha <= hasta.Value)
                &&
                (!estado.HasValue ||
                 f.Estado == estado.Value)
            );
        }

        public (bool ok, string mensaje)
            CambiarEstado(
            string facturaId,
            EstadoFactura estado)
        {
            Factura encontrada =
                facturas.Find(f => f.Id == facturaId);

            if (encontrada == null)
                return (false, "Factura no encontrada.");

            encontrada.Estado = estado;

            repository.Guardar(facturas);

            return (true, $"Estado cambiado a {estado}.");
        }
    }
}
