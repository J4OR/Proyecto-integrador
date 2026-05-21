using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Models
{
    public class Usuario : Persona
    {
        public string userName { get; set; }
        public string password { get; set; }
        public Rol rol { get; set; } = new Rol();
        public bool estado { get; set; }
        [JsonConstructor]
        public Usuario(string userName, string password, Rol rol, bool estado, int id, string identificacion, string nombre, string telefono, string correo) : base(id, identificacion, nombre, telefono, correo)
        {
            this.userName = userName;
            this.password = password;
            this.rol = rol;
            this.estado = estado;
        }
    }
    public enum Rol
    {
        Administrador,Usuario
    }
}
