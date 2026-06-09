using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;

namespace Proyecto_Integrador.Controller
{
    public class TerrenoController
    {
        private TerrenoRepository TerrenoRepository;

        public TerrenoController()
        {
            this.TerrenoRepository = new TerrenoRepository();
        }

        public List<Terreno> ObtenerTerrenos()
        {
            return TerrenoRepository.Leer();
        }

        public void AgregarTerreno(Terreno terreno)
        {
            TerrenoRepository.Agregar(terreno);
        }

        public void EliminarTerreno(Guid id)
        {
            TerrenoRepository.Eliminar(id);
        }
        public List<Terreno> Buscador(string texto)
        {
            return TerrenoRepository.Buscador(texto);
        }
        public double CalcularVolumen(Terreno terreno)
        {
            return CalculadoraVolumen.Calcular(terreno);
        }
    }
}
