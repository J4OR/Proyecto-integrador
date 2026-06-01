using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Controller
{
    public class TerrenoController
    {
        private Terreno terreno;

        public TerrenoController()
        {
            terreno = new Terreno();
        }

        public Terreno ObtenerTerreno()
        {
            return terreno;
        }

        public void AgregarPunto(PuntoTerreno punto)
        {
            terreno.Puntos.Add(punto);
        }

        public void LimpiarPuntos()
        {
            terreno.Puntos.Clear();
        }

        public List<PuntoTerreno> ObtenerPuntos()
        {
            return terreno.Puntos;
        }
    }
}
