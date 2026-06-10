using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Persona
    {
        public Guid id { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }


        [JsonConstructor]
        public Persona(string identificacion, string nombre, string telefono, string correo)
        {
            this.id = Guid.NewGuid();
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }

    }
}
