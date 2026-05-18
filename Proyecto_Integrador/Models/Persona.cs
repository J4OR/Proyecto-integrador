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

        [JsonConstructor]
        public Persona (string nit, string nombre)
        {
            this.id = contador++;
            this.nit = nit;
            this.nombre = nombre;
        }

        public static void actualizarContador(int valor)
        {
            contador = valor;
        }

    }
}
