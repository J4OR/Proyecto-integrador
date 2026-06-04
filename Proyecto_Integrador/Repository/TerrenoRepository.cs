using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;

namespace Proyecto_Integrador.Repository
{
    internal class TerrenoRepository
    {
        private TerrenoController repository;

        public Terreno TerrenoActual { get; private set; }
        public double VolumenCalculado { get; private set; }
        public double[,] MatrizVisualizacion { get; private set; }

        public TerrenoRepository()
        {
            repository = new TerrenoController();
            TerrenoActual = repository.ObtenerTerreno();
        }

        public (bool ok, string mensaje) AgregarPunto(double x, double y, double z)
        {
            repository.AgregarPunto(new PuntoTerreno(x, y, z));

            ActualizarLimites();

            return (
                true,
                $"Punto ({x}, {y}, {z}) agregado. Total: {TerrenoActual.puntos.Count} puntos."
            );
        }

        public void LimpiarPuntos()
        {
            repository.LimpiarPuntos();
            VolumenCalculado = 0;
            MatrizVisualizacion = null;
        }

        private void ActualizarLimites()
        {
            if (TerrenoActual.puntos.Count == 0)
                return;

            double xMin = TerrenoActual.puntos[0].x;
            double xMax = TerrenoActual.puntos[0].x;
            double yMin = TerrenoActual.puntos[0].y;
            double yMax = TerrenoActual.puntos[0].y;

            foreach (PuntoTerreno p in TerrenoActual.puntos)
            {
                if (p.x < xMin) xMin = p.x;
                if (p.x > xMax) xMax = p.x;

                if (p.y < yMin) yMin = p.y;
                if (p.y > yMax) yMax = p.y;
            }

            TerrenoActual.XMin = xMin;
            TerrenoActual.XMax = xMax;
            TerrenoActual.YMin = yMin;
            TerrenoActual.YMax = yMax;
        }

        public void SetNivelCorte(double nivel)
        {
            TerrenoActual.NivelCorte = nivel;
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

        public double[,] ObtenerMatrizGrafica()
        {
            return MatrizVisualizacion;
        }

        public List<PuntoTerreno> ObtenerPuntos()
        {
            return repository.ObtenerPuntos();
        }
    }
}
