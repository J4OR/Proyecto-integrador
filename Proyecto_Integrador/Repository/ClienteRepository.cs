using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace Proyecto_Integrador.Repository
{
    public class ClienteRepository
    {
        private static readonly string carpeta = "Data";
        private static readonly string rutaCarpeta = Path.Combine(carpeta, "clientes.json");

        JsonRepository<Cliente> jsonRepository = new JsonRepository<Cliente>(carpeta, rutaCarpeta);


        public List<Cliente> Leer()
        {
            return jsonRepository.Leer();
        }

        public void Agregar(Cliente cliente)
        {
            List<Cliente> lista = jsonRepository.Leer();
            lista.Add(cliente);
            jsonRepository.Guardar(lista); ;
        }
        public List<Cliente> Buscador(string texto)
        {
            return jsonRepository.filtrar(c => c.nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
            c.identificacion.Contains(texto, StringComparison.OrdinalIgnoreCase));
        }
        public Cliente buscar (string identificacion)
        {
            return jsonRepository.Buscar(c=> c.identificacion == identificacion);
        }
        public void Editar(Cliente nuevoCliente, Guid id)
        {
            jsonRepository.Editar(nuevoCliente, u => u.id == id);
        }

        public void Eliminar(Guid id)
        {
            jsonRepository.Eliminar(u => u.id == id);
        }
    }
}
