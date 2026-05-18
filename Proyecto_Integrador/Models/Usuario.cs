using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Usuario : Persona
    {
        public string password { get; set; }
        public string User { get; set; }
        public bool state { get; set; }
        int idPersona { get; set; }

        [JsonConstructor]
        public Usuario(int id, string nit, string nombre, string password, string user, bool state) : base(id, nit, nombre)
        {
            this.password = password;
            this.state = state;
            this.User = user;
        }
    }
}
