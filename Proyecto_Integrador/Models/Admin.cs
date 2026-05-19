using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Admin : Persona
    {
        public string password { get; set; }
        public string User { get; set; }

        [JsonConstructor]
        public Admin(string nit, string nombre, string telefono, string correo, string password, string user) : base(nit, nombre)
        {
            this.password = password;
            this.User = user;
        }
    }
}
