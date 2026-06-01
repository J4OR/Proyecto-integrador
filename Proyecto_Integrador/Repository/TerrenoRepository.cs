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

            return (true,
                $"Punto ({x}, {y}, {z}) agregado. Total: {TerrenoActual.Puntos.Count} puntos.");
        }

        public void LimpiarPuntos()
        {
            repository.LimpiarPuntos();
            VolumenCalculado = 0;
            MatrizVisualizacion = null;
        }

        private void ActualizarLimites()
        {
            if (TerrenoActual.Puntos.Count == 0)
                return;

            double xMin = TerrenoActual.Puntos[0].X;
            double xMax = TerrenoActual.Puntos[0].X;
            double yMin = TerrenoActual.Puntos[0].Y;
            double yMax = TerrenoActual.Puntos[0].Y;

            foreach (PuntoTerreno p in TerrenoActual.Puntos)
            {
                if (p.X < xMin) xMin = p.X;
                if (p.X > xMax) xMax = p.X;
                if (p.Y < yMin) yMin = p.Y;
                if (p.Y > yMax) yMax = p.Y;
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
            if (TerrenoActual.Puntos.Count < 3)
                return (false, 0, "Se necesitan al menos 3 puntos para calcular el volumen.");

            if (TerrenoActual.XMax <= TerrenoActual.XMin ||
                TerrenoActual.YMax <= TerrenoActual.YMin)
                return (false, 0, "Los puntos deben definir un área con extensión en X e Y.");

             CalculadoraVolumen calc = new CalculadoraVolumen(TerrenoActual, 50);

            VolumenCalculado = calc.Calcular();
            MatrizVisualizacion = calc.GenerarMatrizAlturas(20);

            return (true,
                    VolumenCalculado,
                    $"Volumen calculado: {VolumenCalculado:F4} m³");
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
