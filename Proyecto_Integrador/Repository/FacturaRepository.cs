using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Repository
{
    public class FacturaRepository
    {
        private static readonly string carpeta = "Data";
        private static readonly string rutaCarpeta = Path.Combine("Data", "facturas.json");
        JsonRepository<Factura> jsonRepository = new JsonRepository<Factura>(carpeta, rutaCarpeta);

        public List<Factura> Leer()
        {
          return jsonRepository.Leer();
        }

        public void Agregar(Factura factura)
        {
            List<Factura> lista = jsonRepository.Leer();
            lista.Add(factura);
            jsonRepository.Guardar(lista); 
        }
        public List<Factura> buscador(string texto)
        {
            return jsonRepository.filtrar(f => f.cotizacion.cliente.identificacion.Contains(texto, StringComparison.OrdinalIgnoreCase));
        }
        public void cambiarEstado(string id, bool nuevoEstado)
        {
            jsonRepository.Actualizar(
                factura => factura.id == id,
                factura => factura.estado = nuevoEstado);
        }
        public List<Factura> filtrarPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return jsonRepository.filtrar(f =>
                f.fecha.Date >= fechaInicio.Date &&
                f.fecha.Date <= fechaFin.Date);
        }
    }
}
