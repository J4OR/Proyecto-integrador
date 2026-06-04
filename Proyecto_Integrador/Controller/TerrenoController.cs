using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Controller
{
    public class TerrenoController
    {
        private Terreno terreno;

        public Terreno TerrenoActual => terreno;

        public double VolumenCalculado { get; private set; }
        public TerrenoController()
        {
            terreno = new Terreno();
        }

        public Terreno ObtenerTerreno()
        {
            return terreno;
        }

        public void AgregarPunto(double x, double y, double z)
        {
            terreno.puntos.Add(new PuntoTerreno(x, y, z));
        }

        public void SetNivelCorte(double nivel)
        {
            terreno.NivelCorte = nivel;
        }

        public (bool ok, double volumen, string mensaje) CalcularVolumen()
        {
            // Temporal para que compile
            VolumenCalculado = 0;

            return (
                true,
                VolumenCalculado,
                "Volumen calculado correctamente."
            );
        }
        public List<PuntoTerreno> ObtenerPuntos()
        {
            return terreno.puntos;
        }

        public void LimpiarPuntos()
        {
            terreno.puntos.Clear();
        }
    }
}
