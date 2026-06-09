using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Proyecto_Integrador.Models;
using System.IO;

namespace Proyecto_Integrador.Repository
{
    public class CotizacionRepository
    {
        private static readonly string carpeta = "Data";
        private  static readonly string rutaArchivo = Path.Combine(carpeta, "cotizaciones.json");

        JsonRepository<Cotizacion> jsonRepository = new JsonRepository<Cotizacion>(carpeta, rutaArchivo);

        public List<Cotizacion> Leer()
        {
            return jsonRepository.Leer();
        }

        public void Agregar(Cotizacion cotizacion)
        {
            List<Cotizacion> lista = jsonRepository.Leer();
            lista.Add(cotizacion);
            jsonRepository.Guardar(lista); ;
        }

        public void Editar(Cotizacion nuevaCotizacion, string id)
        {
            jsonRepository.Editar(nuevaCotizacion, c => c.id == id);
        }
        public List<Cotizacion> buscador(string texto)
        {
            return jsonRepository.filtrar(c => c.cliente.identificacion.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
            c.id.Contains(texto, StringComparison.OrdinalIgnoreCase));
        }

        public void cambiarEstado(bool nuevoEstado, string id)
        {
            jsonRepository.Actualizar(
                m => m.id == id,
                m => m.estado = nuevoEstado);
        }

    }
}
