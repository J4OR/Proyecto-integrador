using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Usuario : Persona
    {
        public string password { get; set; }
        public string user { get; set; }
        public bool state { get; set; }

        [JsonConstructor]
        public Usuario(Persona persona, string password, string user) : base(persona.nit, persona.nombre, persona.telefono, persona.correo)
        {
            this.password = password;
            this.state = true;
            this.user = user;
        }



    }
}
