using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Persona
    {
        private static int contador = 1 ;
        public int id { get; set; }
        public string nit { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }

        [JsonConstructor]
        public Persona(int id, string nit, string nombre, string telefono, string correo)
        {
            this.id = id;
            this.nit = nit;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }

        public Persona (string nit, string nombre, string telefono, string correo)
        {
            this.id = contador++;
            this.nit = nit;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }

        public static void ActualizarContador(int valor)
        {
            contador = valor;
        }

    }
}
