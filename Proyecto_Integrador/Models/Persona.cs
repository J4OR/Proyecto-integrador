using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string nit { get; set; }
        public string nombre { get; set; }

        [JsonConstructor]
        public Persona (string nit, string nombre)
        {
            this.Id += 1;
            this.nit = nit;
            this.nombre = nombre;
        }
    }
}
