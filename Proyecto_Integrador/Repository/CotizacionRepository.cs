using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Repository
{
    public class CotizacionRepository
    {
        private readonly string rutaArchivo;

        public CotizacionRepository(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }

        public List<Cotizacion> Leer()
        {
            if (!File.Exists(rutaArchivo))
                return new List<Cotizacion>();

            string json = File.ReadAllText(rutaArchivo);

            if (string.IsNullOrWhiteSpace(json))
                return new List<Cotizacion>();

            return JsonSerializer.Deserialize<List<Cotizacion>>(json)
                   ?? new List<Cotizacion>();
        }

        public void Guardar(List<Cotizacion> cotizaciones)
        {
            string json = JsonSerializer.Serialize(
                cotizaciones,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(rutaArchivo, json);
        }
    }
}
