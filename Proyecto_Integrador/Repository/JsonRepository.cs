using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repository
{
    public class JsonRepository<T> where T : class
    {
        private readonly string carpeta;
        private readonly string rutaCarpeta;

        public JsonRepository(string carpeta, string rutaCarpeta)
        {
            this.carpeta = carpeta;
            this.rutaCarpeta = rutaCarpeta;
        }


        public List<T> Leer()
        {
            List<T> lista = new List<T>();

            if (File.Exists(this.rutaCarpeta))
            {
                using (StreamReader sr = new StreamReader(this.rutaCarpeta))
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
                Directory.CreateDirectory(carpeta);
                File.WriteAllText(rutaCarpeta, "[]");
            }

            return lista;
        }

        public void Guardar(List<T> lista)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using (StreamWriter sw = new StreamWriter(rutaCarpeta))
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
        public void Actualizar(Func<T, bool> criterio, Action<T> actualizar)
        {
            List<T> lista = Leer();

            T? item = lista.FirstOrDefault(x => criterio(x));

            if (item != null)
            {
                actualizar(item);
                Guardar(lista);
            }
        }
        public List<T> BuscarTodos(Func<T, bool> criterio)
        {
            List<T> lista = Leer();
            return lista.Where(item => criterio(item)).ToList();

        }
    }
   }
