using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Multiplier
    {
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Multiply(double x, double y, double z)
        {
            return x * y * z;
        }
        public static double Multiply(double[] x)
        {
            int n = x.Length;
            double wynik = 1;
            for (int i = 0; i < n; i++)
                wynik = wynik * x[i];
            return wynik;
        }
    }
}
