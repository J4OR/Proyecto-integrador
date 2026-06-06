using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repository
{
    public class UsuarioRepository
    {
        private static readonly string carpeta = "Data";
        public static readonly string rutaCarpeta = Path.Combine(carpeta, "usuarios.json");

        JsonRepository<Usuario> jsonRepository = new JsonRepository<Usuario>(carpeta, rutaCarpeta);


        public int ObtenerSiguienteId(List<Usuario> lista)
        {
            if (lista.Count == 0)
                return 1;
            else
                return lista.Max(u => u.id) + 1;
        }

        public List<Usuario> Leer()
        {
            return jsonRepository.Leer();
        }
        
       
        public void Agregar(Usuario usuario)
        {
            List<Usuario> lista = jsonRepository.Leer();
            lista.Add(usuario);
            jsonRepository.Guardar(lista); 
        }


        public void Editar(Usuario nuevoUsuario, int id)
        {
            jsonRepository.Editar(nuevoUsuario, u => u.id == id);
        }

        public Usuario? Buscar(string userName)
        {
            return jsonRepository.Buscar(u => u.userName == userName);
        }
        public void CambiarEstadoUsuarioPorId(int id, bool nuevoEstado)
        {
            jsonRepository.Actualizar(
                usuario => usuario.id == id,
                usuario => usuario.estado = nuevoEstado
            );
        }
    }
}
