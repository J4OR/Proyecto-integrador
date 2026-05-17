using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repository
{
    internal class JsonRepository<T> where T : class
    {
        private string filePath;

        public JsonRepository(string filePath)
        {
            this.filePath = filePath;
        }

        public List<T> Leer()
        {
            List<T> lista = new List<T>();

            if (File.Exists(this.filePath))
            {

                using (StreamReader sr = new StreamReader(this.filePath))
                {
                    string json = sr.ReadToEnd();

                    if (json != String.Empty)
                    {
                        lista = JsonSerializer.Deserialize<List<T>>(json) ?? lista;
                    }
                }

            }

            return lista;
        }

        public void Guardar(List<T> lista)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                string json = JsonSerializer.Serialize<List<T>>(lista, opciones);
                sw.Write(json);
            }
        }
    }
}
