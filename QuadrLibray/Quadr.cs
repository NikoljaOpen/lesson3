using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrLibray
{
    public class Quadr
    {
        double D = 0;
        double a; double b; double c;
        public Quadr(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            D = b * b - 4 * a * c;
        }

        public string get()
        {

            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                return $"Корней два - х1={x1} х2={x2}";
            }
            else if (D < 0)
            {
                return "Корней нет";
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                return $"Корень один - х1={x}";
            }

            return "";
        }
    }
}
