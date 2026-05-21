using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Usuario : Persona
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Rol Rol { get; set; } = new Rol();
        public bool Estado { get; set; }
        [JsonConstructor]
        public Usuario(string username, string password, Rol rol, bool estado, int id, string identificacion, string nombre, string telefono, string correo) : base(id, identificacion, nombre, telefono, correo)
        {
            this.Username = username;
            this.Password = password;
            this.Rol = rol;
            this.Estado = estado;
        }
    }
    public enum Rol
    {
        Administrador,Usuario
    }
}
