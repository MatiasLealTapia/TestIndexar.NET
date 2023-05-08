using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIndexar.NET.Functions
{
    internal class EcuacionCuadratica
    {
        public static void CalculateQuadraticEquation(double a, double b, double c)
        {
            double discriminating = b * b - 4 * a * c;
            double x1, x2;

            if (discriminating > 0)
            {
                x1 = (-b + Math.Sqrt(discriminating)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminating)) / (2 * a);
                Console.WriteLine("\nLas raíces son: x1 = " + x1 + " y x2 = " + x2 + "\n");
            }
            else if (discriminating == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("\nLa raíz doble es: x1 = " + x1 + "\n");
            }
            else
            {
                Console.WriteLine("\nLa ecuación no tiene solución en los números reales.\n");
            }
        }
    }
}
