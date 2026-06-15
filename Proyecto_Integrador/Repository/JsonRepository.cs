using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Shapes;

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

            try
            {
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
            }
            catch (JsonException)
            {
                MessageBox.Show(
                    $"El archivo '{rutaCarpeta}' tiene un formato inválido (posiblemente fue editado manualmente).",
                    "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    $"No tienes permisos para acceder a '{rutaCarpeta}'.",
                    "Error de permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    $"No se pudo leer el archivo '{rutaCarpeta}'.\n{ex.Message}",
                    "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error inesperado al leer '{rutaCarpeta}'.\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public List<T> filtrar(Func<T, bool> criterio)
        {
            List<T> lista = Leer();
            return lista.Where(item => criterio(item)).ToList();

        }
    }
}
