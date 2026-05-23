using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repository
{
    public class JsonRepository<T> where T : class
    {
        private readonly string filePath;
        private readonly string folder;

        public JsonRepository(string folder, string filePath)
        {
            this.folder = folder;
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
            else
            {
                Directory.CreateDirectory(folder);
                File.WriteAllText(filePath, "[]");
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

        public void Editar(T nuevoItem, Func<T, bool> criterio)
        {
            List<T> lista = Leer();
            int index = lista.FindIndex(item => criterio(item));
            if (index != -1)
            {
                lista[index] = nuevoItem;
                Guardar(lista);
            }
        }

        public void Eliminar(Func<T, bool> criterio)
        {
            List<T> lista = Leer();
            lista.RemoveAll(item => criterio(item));
            Guardar(lista);
        }

        public T? Buscar(Func<T, bool> criterio)
        {
            List<T> lista = Leer();
            return lista.FirstOrDefault(item => criterio(item));
        }
    }
}
