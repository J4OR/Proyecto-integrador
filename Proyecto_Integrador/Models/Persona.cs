using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        [JsonConstructor]
        public Persona(int id, string identificacion, string nombre, string telefono, string correo)
        {
            this.Id = id;
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Correo = correo;
        }

    }
}
