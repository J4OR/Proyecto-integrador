using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Repository
{
    public class FacturaRepository
    {
        private readonly string rutaArchivo;

        public FacturaRepository(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }

        public List<Factura> Leer()
        {
            if (!File.Exists(rutaArchivo))
                return new List<Factura>();

            string json = File.ReadAllText(rutaArchivo);

            if (string.IsNullOrWhiteSpace(json))
                return new List<Factura>();

            return JsonSerializer.Deserialize<List<Factura>>(json)
                   ?? new List<Factura>();
        }

        public void Guardar(List<Factura> facturas)
        {
            string json = JsonSerializer.Serialize(
                facturas,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(rutaArchivo, json);
        }
    }
}
