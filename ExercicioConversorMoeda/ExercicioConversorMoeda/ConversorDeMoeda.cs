using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConversorMoeda
{
    internal class ConversorDeMoeda
    {

        double cotacao;
        double quantidade;


        public static double CotacaoDolar(double cotacao,double quantidade)
        {
            double resultado = cotacao * quantidade;
            return resultado += resultado * 6 / 100;
        }



    }
}
