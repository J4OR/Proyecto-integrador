using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Persona
    {
        public int id { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }

        [JsonConstructor]
        public Persona(int id, string identificacion, string nombre, string telefono, string correo)
        {
            this.id = id;
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }

    }
}
