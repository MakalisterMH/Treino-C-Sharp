using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaTrianguloPOO
{
    internal class Triangulo
    {

        double a, b, c, p, area;

        public Triangulo(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double CalcularPerimetro()
        {
            return p = (a + b + c) / 2;

        }

        public double CalcularArea()
        {
            return area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
