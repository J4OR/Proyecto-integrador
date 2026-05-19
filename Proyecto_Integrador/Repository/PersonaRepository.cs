using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repository
{
    internal class PersonaRepository
    {
        private static readonly string folder = "Data";
        public static readonly string filePath = Path.Combine(folder, "personas.json");


        private void sincronizarContador(List<Persona> lista)
        {
            if (lista.Count > 0)
            {
                Persona.ActualizarContador(lista.Max(p => p.id) + 1);
            }
        }

        public List<Persona> leer()
        {
            List<Persona> lista = new List<Persona>();
            if (File.Exists(filePath)) 
            {
                using (StreamReader sr = new StreamReader(filePath))
                    {
                    string json = sr.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        lista = JsonSerializer.Deserialize<List<Persona>>(json) ?? lista;
                    }
                }
                sincronizarContador (lista);
            }
            else
            {
                Directory.CreateDirectory(folder);
                File.WriteAllText(filePath, "[]");
            }
            return lista;
        }
        private void guardar(List<Persona> lista)
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

        public void agregar(Persona persona)
        {
            List<Persona> lista = this.leer();
            lista.Add(persona);
            this.guardar(lista);
        }
    }
}
