using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Controller
{
    internal class PersonaController
    {
        private PersonaRepository personaRepository;

        public PersonaController() 
        {
            this.personaRepository = new PersonaRepository();
        }

        public List<Persona> obtenerPersonas()
        {
            return personaRepository.leer();
        }

        public void agregarPersona(Persona persona)
        {
            personaRepository.agregar(persona);
        }
        
    }
}

