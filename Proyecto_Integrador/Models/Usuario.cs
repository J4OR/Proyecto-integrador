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
        public Rol rol { get; set; } 
        public bool estado { get; set; }
        public string estadoTexto
        {
            get
            {
                return estado ? "Activo" : "Inactivo";
            }
        }
        [JsonConstructor]
        public Usuario(string identificacion, string nombre, string telefono, string correo, string userName, string password, Rol rol=Rol.Usuario, bool estado=true) : base(identificacion, nombre, telefono, correo)
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
