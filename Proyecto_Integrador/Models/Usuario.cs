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
        public int idPersona { get; set; }

        [JsonConstructor]
        public Usuario(string nit, string nombre, string password, string user) : base(nit, nombre)
        {
            this.password = password;
            this.state = true;
            this.User = user;
        }



    }
}
