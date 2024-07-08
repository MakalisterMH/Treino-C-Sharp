using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRetanguloPOO
{
    public class Retangulo
    {

        public double Largura;
        public double Altura;


        public double CalcularArea()
        {
        return Largura * Altura; 
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

    }

}

