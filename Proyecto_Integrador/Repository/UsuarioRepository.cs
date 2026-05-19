using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repository
{
    internal class UsuarioRepository
    {
        private static readonly string folder = "Data";
        public static readonly string filePath = Path.Combine(folder, "usuarios.json");

        public List<Usuario> leer()
        {
            List<Usuario> lista = new List<Usuario>();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string json = sr.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        lista = JsonSerializer.Deserialize<List<Usuario>>(json) ?? lista;
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(folder);
                File.WriteAllText(filePath, "[]");
            }
            return lista;
        }
        private void guardar(List<Usuario> lista)
        {

            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                string json = JsonSerializer.Serialize(lista, opciones);
                sw.Write(json);
            }
        }

        public void agregar(Usuario usuario)
        {
            List<Usuario> lista = this.leer();
            lista.Add(usuario);
            this.guardar(lista);
        }
    }
}
