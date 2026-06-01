using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Proyecto_Integrador.Models;

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

        public void Editar(Cotizacion nuevaCotizacion, int id)
        {
            jsonRepository.Editar(nuevaCotizacion, c => c.id == id);
        }

    }
}
