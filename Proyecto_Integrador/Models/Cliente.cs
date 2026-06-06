using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Models
{
    public class Cliente : Persona
    {
        public Cliente(int id, string identificacion, string nombre, string telefono, string correo) 
        : base(id, identificacion, nombre, telefono, correo)
        {
        }
    }
}
