using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Proyecto_Integrador.Models;
namespace Proyecto_Integrador.Repository
{
    public class MaterialRepository
    {
        private static readonly string carpeta = "Data";
        private static readonly string rutaCarpeta = Path.Combine(carpeta, "materiales.json");

        JsonRepository<Material> jsonRepository = new JsonRepository<Material>(carpeta, rutaCarpeta);

        public int ObtenerSiguienteId(List<Material> lista)
        {
            if (lista.Count == 0)
                return 1;
            else
                return lista.Max(m => m.id) + 1;
        }

        public List<Material> Leer()
        {
            return jsonRepository.Leer();
        }

        public void Agregar(Material material)
        {
            List<Material> lista = jsonRepository.Leer();
            lista.Add(material);
            jsonRepository.Guardar(lista); ;
        }

        public void Editar(Material nuevoMaterial, int id)
        {
            jsonRepository.Editar(nuevoMaterial, u => u.id == id);
        }
    }
}
