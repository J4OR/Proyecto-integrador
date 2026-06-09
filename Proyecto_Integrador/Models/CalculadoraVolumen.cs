using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Models
{
    /// <summary>
    /// Clase encargada de calcular el volumen de corte de un terreno.
    /// Usa el método numérico de Simpson 1/3 compuesto en dos dimensiones.
    /// </summary>
    public static class CalculadoraVolumen
    {
        /// <summary>
        /// Calcula el volumen de corte de un terreno usando sus cotas,
        /// la cota de corte y las distancias entre puntos en X y Y.
        /// </summary>
        /// <param name="terreno">
        /// Terreno que contiene la matriz de cotas, la cota de corte,
        /// la distancia dx y la distancia dy.
        /// </param>
        /// <returns>
        /// Volumen aproximado de material que está por encima de la cota de corte.
        /// </returns>
        public static double CalcularSimpson(Terreno terreno)
        {
            double[,] z = ConvertirAMatriz(terreno.cotas);

            return Simpson(
                z,
                terreno.alturaReferencia,
                terreno.dx,
                terreno.dy
            );
        }

        /// <summary>
        /// Convierte una matriz tipo double[][] en una matriz double[,].
        /// Esto permite guardar las cotas fácilmente en JSON y luego usarlas
        /// en el cálculo numérico.
        /// </summary>
        /// <param name="datos">Matriz de cotas en formato double[][].</param>
        /// <returns>Matriz de cotas en formato double[,].</returns>
        public static double[,] ConvertirAMatriz(double[][] datos)
        {
            int filas = datos.Length;
            int cols = datos[0].Length;

            double[,] matriz = new double[filas, cols];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matriz[i, j] = datos[i][j];
                }
            }

            return matriz;
        }

        /// <summary>
        /// Aplica el método de Simpson 1/3 compuesto en dos dimensiones
        /// para aproximar el volumen de corte del terreno.
        /// </summary>
        /// <param name="z">Matriz de cotas del terreno.</param>
        /// <param name="cotaCorte">Nivel o cota base hasta donde se desea cortar.</param>
        /// <param name="dx">Distancia entre puntos en la dirección X.</param>
        /// <param name="dy">Distancia entre puntos en la dirección Y.</param>
        /// <returns>Volumen aproximado de corte.</returns>
        private static double Simpson(double[,] z, double cotaCorte, double dx, double dy)
        {
            int filas = z.GetLength(0);
            int cols = z.GetLength(1);

            if (filas < 3 || cols < 3)
                throw new ArgumentException("Simpson 2D requiere mínimo 3x3 nodos.");

            int ni = filas % 2 == 1 ? filas : filas - 1;
            int nj = cols % 2 == 1 ? cols : cols - 1;

            double volumen = 0;

            for (int i = 0; i < ni; i++)
            {
                double wi = SimpsonPeso(i, ni);

                for (int j = 0; j < nj; j++)
                {
                    double profundidad =
                    Math.Max(cotaCorte - z[i, j], 0);

                    volumen += wi * SimpsonPeso(j, nj) * profundidad;
                    //double diferencia = z[i, j] - cotaCorte;

                    //if (diferencia > 0)
                    //{
                    //    volumen += wi * SimpsonPeso(j, nj) * diferencia;
                    //}
                }
            }

            return volumen * dx * dy / 9.0;
        }

        /// <summary>
        /// Devuelve el peso de Simpson 1/3 para un punto de la grilla.
        /// Los extremos tienen peso 1, los puntos impares peso 4
        /// y los puntos pares interiores peso 2.
        /// </summary>
        /// <param name="k">Índice del punto dentro de la grilla.</param>
        /// <param name="n">Cantidad total de puntos usados en esa dirección.</param>
        /// <returns>Peso correspondiente según Simpson 1/3.</returns>
        private static double SimpsonPeso(int k, int n)
        {
            if (k == 0 || k == n - 1) return 1.0;
            return k % 2 == 1 ? 4.0 : 2.0;
        }
    }
}