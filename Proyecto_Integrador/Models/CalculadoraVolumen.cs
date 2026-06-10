using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Models
{
    ///// <summary>
    ///// Aplica el método de Simpson 1/3 compuesto en dos dimensiones
    ///// para aproximar el volumen de corte del terreno.
    ///// </summary>
    ///// <param name="z">Matriz de cotas del terreno.</param>
    ///// <param name="cotaCorte">Nivel o cota base hasta donde se desea cortar.</param>
    ///// <param name="dx">Distancia entre puntos en la dirección X.</param>
    ///// <param name="dy">Distancia entre puntos en la dirección Y.</param>
    ///// <returns>Volumen aproximado de corte.</returns>
    public static class CalculadoraVolumen
    {
        public static double Calcular(Terreno terreno)
        {
            if (terreno.operacion == TipoOperacion.Remover)
                return CalcularCorte(terreno);

            if (terreno.operacion == TipoOperacion.Rellenar || terreno.operacion == TipoOperacion.Excavar)
                return CalcularRelleno(terreno);

            return CalcularCorte(terreno) + CalcularRelleno(terreno);
        }

        public static double CalcularCorte(Terreno terreno)
        {
            return Simpson(terreno.cotas, terreno.alturaReferencia, terreno.dx, terreno.dy, TipoOperacion.Remover);
        }

        public static double CalcularRelleno(Terreno terreno)
        {
            return Simpson(terreno.cotas, terreno.alturaReferencia, terreno.dx, terreno.dy, TipoOperacion.Rellenar);
        }

        private static double Simpson(double[][] z, double cotaReferencia, double dx, double dy, TipoOperacion tipo)
        {
            int filas = z.Length;
            int cols = z[0].Length;

            if (filas < 3 || cols < 3)
                throw new ArgumentException("Simpson 2D requiere mínimo 3x3 nodos.");

            int ni = filas % 2 == 1 ? filas : filas - 1;
            int nj = cols % 2 == 1 ? cols : cols - 1;

            double acum = 0;

            for (int i = 0; i < ni; i++)
            {
                double wi = SimpsonPeso(i, ni);
                for (int j = 0; j < nj; j++)
                {
                    double wj = SimpsonPeso(j, nj);
                    double d = z[i][j] - cotaReferencia;

                    if (tipo == TipoOperacion.Remover && d > 0)
                    {
                        acum += wi * wj * d;
                    }
                    if (tipo == TipoOperacion.Rellenar && d < 0)
                    {
                        acum += wi * wj * (-d);
                    }
                }
            }

            return acum * dx * dy / 9.0;
        }
        ///// <summary>
        ///// Devuelve el peso de Simpson 1/3 para un punto de la grilla.
        ///// Los extremos tienen peso 1, los puntos impares peso 4
        ///// y los puntos pares interiores peso 2.
        ///// </summary>
        ///// <param name="k">Índice del punto dentro de la grilla.</param>
        ///// <param name="n">Cantidad total de puntos usados en esa dirección.</param>
        ///// <returns>Peso correspondiente según Simpson 1/3.</returns>
        //private static double SimpsonPeso(int k, int n)
        private static double SimpsonPeso(int k, int n)
        {
            if (k == 0 || k == n - 1) return 1.0;
            return k % 2 == 1 ? 4.0 : 2.0;
        }
    }
    
}