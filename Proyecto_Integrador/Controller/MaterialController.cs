using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Controller
{
    public class MaterialController
    {
        private MaterialRepository materialRepository;

        public MaterialController()
        {
            this.materialRepository = new MaterialRepository();
        }

        public List<Material> ObtenerMateriales()
        {
            return materialRepository.Leer();
        }

        public void AgregarMaterial(Material material)
        {
            materialRepository.Agregar(material);
        }

        public void EditarMaterial(Material material, int id)
        {
            materialRepository.Editar(material, id);
        }

        public int ObtenerSiguienteId()
        {
            return materialRepository.ObtenerSiguienteId();
        }

        public bool ExisteMaterial(string nombre)
        {
            List<Material> lista = materialRepository.Leer();
            return lista.Any(m => m.nombre == nombre);
        } 
        public List<Material> buscador(string texto)
        {
            return materialRepository.buscador(texto);
        }
        public void cambiarEstado(bool nuevoEstado, int id)
        {
            materialRepository.CambiarEstado(id, nuevoEstado);
        }
    }
}
