using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Models
{
    /// <summary>
    /// Representa un punto 3D del terreno (x, y, z) donde z es la altura.
    /// </summary>
    public class PuntoTerreno
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public PuntoTerreno(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
    }

    public class Terreno
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public List<PuntoTerreno> Puntos { get; set; }

        // Límites del área rectangular analizada
        public double XMin { get; set; }
        public double XMax { get; set; }
        public double YMin { get; set; }
        public double YMax { get; set; }

        // Nivel de corte (profundidad objetivo o nivel final deseado)
        public double NivelCorte { get; set; }
        public double volumen { get; set; }

        public Terreno()
        {
            Id = Guid.NewGuid().ToString();
            Puntos = new List<PuntoTerreno>();
        }
    }

    /// <summary>
    /// Calcula el volumen de material a remover usando integración numérica doble
    /// (Regla del Trapecio 2D / método de Simpson compuesto).
    /// </summary>
    public class CalculadoraVolumen
    {
        private readonly Terreno _terreno;
        private readonly int nPasos; // Divisiones de la cuadrícula

        public double VolumenCalculado { get; private set; }

        public CalculadoraVolumen(Terreno terreno, int nPasos = 100)
        {
            _terreno = terreno;
            _nPasos = nPasos;
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

            foreach (var p in _terreno.Puntos)
            {
                double dist = Math.Sqrt(Math.Pow(x - p.X, 2) + Math.Pow(y - p.Y, 2));
                if (dist < epsilon) return p.Z; // Coincide exactamente con un punto
                double peso = 1.0 / (dist * dist);
                sumaPeso += peso;
                sumaZPeso += peso * p.Z;
            }

            return sumaPeso > 0 ? sumaZPeso / sumaPeso : _terreno.NivelCorte;
        }

        /// <summary>
        /// Calcula el volumen usando integración doble numérica (método del trapecio).
        /// Integra f(x,y) = max(0, Z_terreno(x,y) - NivelCorte) sobre el área rectangular.
        /// </summary>
        public double Calcular()
        {
            if (_terreno.Puntos.Count == 0)
            {
                VolumenCalculado = 0;
                return 0;
            }

            double dx = (_terreno.XMax - _terreno.XMin) / _nPasos;
            double dy = (_terreno.YMax - _terreno.YMin) / _nPasos;

            double suma = 0;

            for (int i = 0; i <= _nPasos; i++)
            {
                double x = _terreno.XMin + i * dx;
                double wx = (i == 0 || i == _nPasos) ? 0.5 : 1.0; // Peso trapecio en X

                for (int j = 0; j <= _nPasos; j++)
                {
                    double y = _terreno.YMin + j * dy;
                    double wy = (j == 0 || j == _nPasos) ? 0.5 : 1.0; // Peso trapecio en Y

                    double z = InterpolarZ(x, y);
                    double altura = Math.Max(0, z - _terreno.NivelCorte);

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
            double dx = (_terreno.XMax - _terreno.XMin) / (resolucion - 1);
            double dy = (_terreno.YMax - _terreno.YMin) / (resolucion - 1);

            for (int i = 0; i < resolucion; i++)
                for (int j = 0; j < resolucion; j++)
                {
                    double x = _terreno.XMin + i * dx;
                    double y = _terreno.YMin + j * dy;
                    matriz[i, j] = Math.Max(0, InterpolarZ(x, y) - _terreno.NivelCorte);
                }

            return matriz;
        }
    }
}
