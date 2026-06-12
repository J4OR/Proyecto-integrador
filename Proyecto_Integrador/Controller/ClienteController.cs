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

        public void EditarCliente(Cliente cliente, Guid id)
        {
            clienteRepository.Editar(cliente, id);
        }

        public Cliente Buscar(string identificacion)
        {
            return clienteRepository.buscar(identificacion);
        }

        public List<Cliente> Buscador(string texto)
        {
            return clienteRepository.Buscador(texto);
        }

        public bool ExisteCliente(string identificacion)
        {
            List<Cliente> lista = clienteRepository.Leer();
            return lista.Exists(c => c.identificacion == identificacion);
        }
        public void EliminarCliente(Guid id)
        {
            clienteRepository.Eliminar(id);
        }

    }
}
