using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Controller
{
    public class CotizacionController
    {
        private readonly CotizacionRepository repository;
        private List<Cotizacion> cotizaciones;

        public CotizacionController(string rutaDatos)
        {
            repository = new CotizacionRepository(
                Path.Combine(rutaDatos, "cotizaciones.json"));

            cotizaciones = repository.Leer();
        }

        public (bool ok, Cotizacion cotizacion, string mensaje)
            GenerarCotizacion(
            Cliente cliente,
            Material material,
            double volumenM3,
            string descripcion)
        {
            if (cliente == null)
                return (false, null, "Debe seleccionar un cliente.");

            if (material == null)
                return (false, null, "Debe seleccionar un material.");

            if (volumenM3 <= 0)
                return (false, null, "El volumen debe ser mayor que 0.");

            Cotizacion cot = new Cotizacion
            {
                ClienteId = cliente.Id,
                NombreCliente = cliente.Nombre,
                MaterialId = material.Id,
                NombreMaterial = material.Nombre,
                VolumenM3 = volumenM3,
                CostoPorM3 = material.CostoPorUnidad,
                Descripcion = descripcion
            };

            cotizaciones.Add(cot);

            repository.Guardar(cotizaciones);

            return (true,
                    cot,
                    $"Cotización generada. Total: ${cot.Total:F2}");
        }

        public List<Cotizacion> ObtenerTodas()
        {
            return cotizaciones;
        }

        public List<Cotizacion> ObtenerPorCliente(string clienteId)
        {
            return cotizaciones
                .FindAll(c => c.ClienteId == clienteId);
        }

        public Cotizacion ObtenerPorId(string id)
        {
            return cotizaciones
                .Find(c => c.Id == id);
        }

        public (bool ok, string mensaje)
            CambiarEstado(
            string cotizacionId,
            EstadoCotizacion estado)
        {
            Cotizacion encontrada =
                cotizaciones.Find(c => c.Id == cotizacionId);

            if (encontrada == null)
                return (false, "Cotización no encontrada.");

            encontrada.Estado = estado;

            repository.Guardar(cotizaciones);

            return (true, $"Estado cambiado a {estado}.");
        }
    }
}
