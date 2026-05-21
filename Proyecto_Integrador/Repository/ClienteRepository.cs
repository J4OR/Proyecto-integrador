using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Repository
{
    public class ClienteRepository
    {
        private static readonly string folder = "Data";
        private static readonly string filePath = Path.Combine(folder, "clientes.json");

        JsonRepository<Cliente> jsonRepository = new JsonRepository<Cliente>(folder, filePath);

        public int ObtenerSiguienteId(List<Cliente> lista)
        {
            if (lista.Count == 0)
                return 1;
            else
                return lista.Max(c => c.Id) + 1;
        }

        public List<Cliente> Leer()
        {
            return jsonRepository.Leer();
        }

        public void Agregar(Cliente cliente)
        {
            List<Cliente> lista = jsonRepository.Leer();
            cliente.Id = ObtenerSiguienteId(lista);
            lista.Add(cliente);
            jsonRepository.Guardar(lista); ;
        }


        public void Editar(Cliente nuevoCliente, int id)
        {
            jsonRepository.Editar(nuevoCliente, u => u.Id == id);
        }

        public Cliente? Buscar(string nombre)
        {
            return jsonRepository.Buscar(c => c.Nombre == nombre);
        }
    }
}
