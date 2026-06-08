using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Repository
{
    public class TerrenoRepository
    {
        private static readonly string carpeta = "Data";
        private static readonly string rutaCarpeta = Path.Combine(carpeta, "terrenos.json");

        private JsonRepository<Terreno> jsonRepository = new JsonRepository<Terreno>(carpeta, rutaCarpeta);

        public List<Terreno> Leer()
        {
            return jsonRepository.Leer();
        }

        public void Agregar(Terreno terreno)
        {
            List<Terreno> lista = jsonRepository.Leer();
            lista.Add(terreno);
            jsonRepository.Guardar(lista); 
        }

        public void Editar(Terreno nuevoTerreno, Guid id)
        {
            jsonRepository.Editar(nuevoTerreno, u => u.id == id);
        }

        public void Eliminar(Guid id)
        {
            jsonRepository.Eliminar(u => u.id == id);
        }

        public List<Terreno> Buscador(string texto)
        {
            return jsonRepository.filtrar(t => t.nombre.Contains(texto, StringComparison.OrdinalIgnoreCase));
        }
    }
    }   
