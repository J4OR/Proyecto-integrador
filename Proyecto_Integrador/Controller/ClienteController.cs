using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Controller
{
    public class ClienteController
    {
        private ClienteRepository clienteRepository;

        public ClienteController()
        {
            this.clienteRepository = new ClienteRepository();
        }

        public List<Cliente> ObtenerClientes()
        {
            return clienteRepository.Leer();
        }

        public void AgregarCliente(Cliente cliente)
        {
            clienteRepository.Agregar(cliente);
        }
        public void EditarCliente(Cliente cliente, int id)
        {
            clienteRepository.Editar(cliente, id);
        }
        
        public Cliente BuscarPorNombre(string nombre)
        {
            List<Cliente> lista = clienteRepository.Leer();
            return lista.Find(c => c.nombre == nombre);
        }

        public int ObtenerSiguienteId()
        {
            List<Cliente> lista = clienteRepository.Leer();
            return clienteRepository.ObtenerSiguienteId(lista);
        }
    }
}
