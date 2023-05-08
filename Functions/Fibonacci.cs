using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIndexar.NET.Functions
{
    internal class Fibonacci
    {
        public static List<int> ListSerie(int serieLength)
        {
            int x = 0;
            int y = 1;
            int z = 0;
            List<int> serie = new List<int> { 0, 1 };

            for (int i = 0; i < serieLength; i++)
            {
                z = x + y;
                serie.Add(z);
                x = y;
                y = z;
            }
            return serie;
        }
    }
}
