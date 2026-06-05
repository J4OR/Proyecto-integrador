using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Controller
{
    public class TerrenoController
    {
        private Terreno terreno;

        public double[,] MatrizVisualizacion { get; private set; }
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

            if (terreno.puntos.Count == 1)
            {
                terreno.XMin = terreno.XMax = x;
                terreno.YMin = terreno.YMax = y;
            }
            else
            {
                terreno.XMin = Math.Min(terreno.XMin, x);
                terreno.XMax = Math.Max(terreno.XMax, x);

                terreno.YMin = Math.Min(terreno.YMin, y);
                terreno.YMax = Math.Max(terreno.YMax, y);
            }
        }

        public void SetNivelCorte(double nivel)
        {
            terreno.NivelCorte = nivel;
        }

        public (bool ok, double volumen, string mensaje) CalcularVolumen()
        {
            if (TerrenoActual.puntos.Count < 3)
                return (false, 0, "Se necesitan al menos 3 puntos para calcular el volumen.");

            if (TerrenoActual.XMax <= TerrenoActual.XMin ||
                TerrenoActual.YMax <= TerrenoActual.YMin)
                return (false, 0, "Los puntos deben definir un área con extensión en X e Y.");

            CalculadoraVolumen calc = new CalculadoraVolumen(TerrenoActual, 50);

            VolumenCalculado = calc.Calcular();
            MatrizVisualizacion = calc.GenerarMatrizAlturas(20);

            return (
                true,
                VolumenCalculado,
                $"Volumen calculado: {VolumenCalculado:F4} m³"
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
