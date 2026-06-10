using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Models
{
    public class Cliente : Persona
    {
        public Cliente( string identificacion, string nombre, string telefono, string correo) 
        : base(identificacion, nombre, telefono, correo)
        {
        }
    }
}
