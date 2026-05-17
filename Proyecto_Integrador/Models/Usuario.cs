using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    internal class Usuario : Persona
    {
        public string clave { get; set; }
        public string User { get; set; }
        public bool state { get; set; }

        [JsonConstructor]
        public Usuario(string clave, string user, bool state) : base(id, nit, nombre)
        {
            this.clave = clave;
            this.state = state;
            this.User = user;
        }
    }
}
