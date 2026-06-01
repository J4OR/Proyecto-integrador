using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Repository
{
    internal class MaterialRepository
    {
        private readonly string rutaArchivo;

        public MaterialRepository(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }

        public List<Material> Leer()
        {
            if (!File.Exists(rutaArchivo))
                return new List<Material>();

            string json = File.ReadAllText(rutaArchivo);

            if (string.IsNullOrWhiteSpace(json))
                return new List<Material>();

            return JsonSerializer.Deserialize<List<Material>>(json)
                   ?? new List<Material>();
        }

        public void Guardar(List<Material> materiales)
        {
            string json = JsonSerializer.Serialize(
                materiales,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(rutaArchivo, json);
        }
    }
}
