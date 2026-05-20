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
        public Rol rol { get; set; }
        [JsonConstructor]
        public Usuario(string nit, string nombre, string telefono, string correo, string password, string user, Rol rol) : base(nit, nombre, telefono, correo)
        {
            this.password = password;
            this.state = true;
            this.rol = rol;
            this.user = user;
        }
    }
    public enum Rol
    {
        Administrador,Usuario
    }
}
