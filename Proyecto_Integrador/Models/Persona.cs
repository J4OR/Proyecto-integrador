using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    internal class Persona
    {
        public int Id { get; set; }
        public string nit { get; set; }
        public string nombre { get; set; }

        [JsonConstructor]
        public Persona(int id, string nit, string nombre)
        {
            this.Id = id;
            this.nit = nit;
            this.nombre = nombre;
        }
    }
}
