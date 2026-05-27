using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;

namespace Proyecto_Integrador.Controller
{
    public class UsuarioController
    {
        private UsuarioRepository usuarioRepository;

        public UsuarioController()
        {
           this.usuarioRepository = new UsuarioRepository();
        }

        public int ObtenerSiguienteId()
        {
            List<Usuario> lista = usuarioRepository.Leer();
            return usuarioRepository.ObtenerSiguienteId(lista);
        }

        // Obtener todos los usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            return usuarioRepository.Leer();
        }

        // Agregar usuario
        public void AgregarUsuario(Usuario usuario)
        {
            usuarioRepository.Agregar(usuario);
        }

        // Editar usuario
        public void EditarUsuario(Usuario usuario, int id)
        {
            usuarioRepository.Editar(usuario, id);
        }

        // Buscar usuario por user
        public Usuario BuscarPorUser(string userName)
        {
            List<Usuario> lista = usuarioRepository.Leer();

            return lista.Find(u => u.userName == userName);
        }

        public bool ExisteUsuario(string userName)
        {
            List<Usuario> lista = usuarioRepository.Leer();
            return lista.Any(u => u.userName == userName);
        }

        public bool ExisteDocumento(string documento)
        {
            List<Usuario> lista = usuarioRepository.Leer();
            return lista.Any(u => u.identificacion == documento);
        }
    }
}
