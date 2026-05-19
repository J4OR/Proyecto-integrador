using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repository
{
    internal class AdminRepository
    {
        private static readonly string folder = "Data";
        public static readonly string filePath = Path.Combine(folder, "Admin.json");

        public List<Admin> leer()
        {
            List<Admin> lista = new List<Admin>();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string json = sr.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        lista = JsonSerializer.Deserialize<List<Admin>>(json) ?? lista;
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
        private void guardar(List<Admin> lista)
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

        public void agregar(Admin admin)
        {
            List<Admin> lista = this.leer();
            lista.Add(admin);
            this.guardar(lista);
        }

        public void editar(Admin admin)
        {
            List<Admin> lista = this.leer();
            int index = lista.FindIndex(u => u.id == admin.id);
            if (index != -1)
            {
                lista[index] = admin;
                this.guardar(lista);
            }
        }
    }
}
