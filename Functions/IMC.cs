using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIndexar.NET.Functions
{
    internal class IMC
    {
        public static double CalculateBMI(double weight, double height)
        {
            return weight / ( height * height );
        }

        public static string BMICategory(double imc)
        {
            string category;
            if (imc < 18.0)
            {
                category = "Peso bajo";
            }
            else if (imc < 25.0)
            {
                category = "Normal";
            }
            else if (imc < 27.0)
            {
                category = "Sobrepeso";
            }
            else if (imc < 30.0)
            {
                category = "Obesidad Grado I";
            }
            else if (imc < 40)
            {
                category = "Obesidad Grado II";
            }
            else
            {
                category = "Obesidad Grado III, Extrema o Mórbida";
            }
            return category;
        }
    }
}
