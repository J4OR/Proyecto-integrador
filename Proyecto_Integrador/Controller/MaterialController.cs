using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;

namespace Proyecto_Integrador.Controller
{
    public class MaterialController
    {
        private readonly MaterialRepository repository;
        private List<Material> materiales;

        public MaterialController(string rutaDatos)
        {
            repository = new MaterialRepository(
                Path.Combine(rutaDatos, "materiales.json"));

            materiales = repository.Leer();

            SeedMateriales();
        }

        private void SeedMateriales()
        {
            if (materiales.Count == 0)
            {
                materiales.Add(new Material("Arena", 25000));
                materiales.Add(new Material("Tierra", 18000));
                materiales.Add(new Material("Roca", 55000));
                materiales.Add(new Material("Grava", 30000));

                repository.Guardar(materiales);
            }
        }

        public (bool ok, string mensaje) CrearMaterial(
            string nombre,
            double costo)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return (false, "El nombre es obligatorio.");

            if (costo <= 0)
                return (false, "El costo debe ser mayor que cero.");

            materiales.Add(new Material(nombre, costo));

            repository.Guardar(materiales);

            return (true, "Material creado correctamente.");
        }

        public (bool ok, string mensaje) ActualizarCosto(
            string materialId,
            double nuevoCosto)
        {
            Material material = materiales.Find(m => m.Id == materialId);

            if (material == null)
                return (false, "Material no encontrado.");

            if (nuevoCosto <= 0)
                return (false, "El costo debe ser mayor que cero.");

            material.CostoPorUnidad = nuevoCosto;

            repository.Guardar(materiales);

            return (true, "Costo actualizado correctamente.");
        }

        public List<Material> ObtenerTodos()
        {
            return materiales;
        }

        public Material ObtenerPorId(string id)
        {
            return materiales.Find(m => m.Id == id);
        }
    }
}
