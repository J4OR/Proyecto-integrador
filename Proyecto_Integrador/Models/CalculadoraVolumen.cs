using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Models
{
    /// <summary>
    /// Calcula el volumen de material a remover usando integración numérica doble
    /// (Regla del Trapecio 2D / método de Simpson compuesto).
    /// </summary>

    public class CalculadoraVolumen
    {
        private readonly Terreno terreno;
        private readonly int nPasos; // Divisiones de la cuadrícula

        public double VolumenCalculado { get; set; }

        public CalculadoraVolumen(Terreno terreno, int nPasos = 100)
        {
            this.terreno = terreno; 
            this.nPasos = nPasos;
        }

        /// <summary>
        /// Interpola la altura Z para un punto (x, y) usando los puntos de terreno conocidos
        /// mediante distancia inversa ponderada (IDW).
        /// </summary>
        private double InterpolarZ(double x, double y)
        {
            double sumaPeso = 0;
            double sumaZPeso = 0;
            double epsilon = 1e-10;

            foreach (var p in terreno.puntos)
            {
                double dist = Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
                if (dist < epsilon) return p.z; // Coincide exactamente con un punto
                double peso = 1.0 / (dist * dist);
                sumaPeso += peso;
                sumaZPeso += peso * p.z;
            }

            return sumaPeso > 0 ? sumaZPeso / sumaPeso : terreno.NivelCorte;
        }

        /// <summary>
        /// Calcula el volumen usando integración doble numérica (método del trapecio).
        /// Integra f(x,y) = max(0, Z_terreno(x,y) - NivelCorte) sobre el área rectangular.
        /// </summary>
        public double Calcular()
        {
            if (terreno.puntos.Count == 0)
            {
                VolumenCalculado = 0;
                return 0;
            }

            double dx = (terreno.XMax - terreno.XMin) / nPasos;
            double dy = (terreno.YMax - terreno.YMin) / nPasos;

            double suma = 0;

            for (int i = 0; i <= nPasos; i++)
            {
                double x = terreno.XMin + i * dx;
                double wx = (i == 0 || i == nPasos) ? 0.5 : 1.0; // Peso trapecio en X

                for (int j = 0; j <= nPasos; j++)
                {
                    double y = terreno.YMin + j * dy;
                    double wy = (j == 0 || j == nPasos) ? 0.5 : 1.0; // Peso trapecio en Y

                    double z = InterpolarZ(x, y);
                    double altura = Math.Max(0, z - terreno.NivelCorte);

                    suma += wx * wy * altura;
                }
            }

            VolumenCalculado = suma * dx * dy;
            return VolumenCalculado;
        }

        /// <summary>
        /// Genera una matriz de alturas para visualización gráfica.
        /// </summary>
        public double[,] GenerarMatrizAlturas(int resolucion = 20)
        {
            var matriz = new double[resolucion, resolucion];
            double dx = (terreno.XMax - terreno.XMin) / (resolucion - 1);
            double dy = (terreno.YMax - terreno.YMin) / (resolucion - 1);

            for (int i = 0; i < resolucion; i++)
                for (int j = 0; j < resolucion; j++)
                {
                    double x = terreno.XMin + i * dx;
                    double y = terreno.YMin + j * dy;
                    matriz[i, j] = Math.Max(0, InterpolarZ(x, y) - terreno.NivelCorte);
                }

            return matriz;
        }
    }
}
