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

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarioRepository.Leer();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarioRepository.Agregar(usuario);
        }

        public void EditarUsuario(Usuario usuario, Guid id)
        {
            usuarioRepository.Editar(usuario, id);
        }

        public Usuario BuscarPorUserName(string userName)
        {
            return usuarioRepository.Buscar(userName);
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
        public void CambiarEstadoUsuario(Guid id, bool nuevoEstado)
        {
            usuarioRepository.CambiarEstadoUsuarioPorId(id, nuevoEstado);

        }
        public List<Usuario> Buscador(string texto)
        {
            return usuarioRepository.buscador(texto);
        }
    }
}
