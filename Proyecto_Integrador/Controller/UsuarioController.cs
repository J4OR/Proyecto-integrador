using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;

namespace Proyecto_Integrador.Controller
{
    internal class UsuarioController
    {
        private UsuarioRepository repository;

        public UsuarioController()
        {
            repository = new UsuarioRepository();
        }

        // Obtener todos los usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            return repository.leer();
        }

        // Agregar usuario
        public void AgregarUsuario(Usuario usuario)
        {
            repository.agregar(usuario);
        }

        // Editar usuario
        public void EditarUsuario(Usuario usuario)
        {
            repository.editar(usuario);
        }

        // Buscar usuario por user
        public Usuario BuscarPorUser(string user)
        {
            List<Usuario> lista = repository.leer();

            return lista.Find(u => u.user == user);
        }
    }
}
