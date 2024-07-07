using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesSintaxe
{
    internal class NumeroMaior
    {

        int n1, n2 ,n3;

        public int Maior(int n1, int n2, int n3)
        {
            int resultado;

            if (n1 > n2 & n1 > n3)
            {
                resultado = n1;
            }

            else if (n2 > n3)
            {
                resultado = n2;   // se n1 não é maior é so verificar c n3 é maior q n2, c n for o n2 é o Maior.
            }

            else
            {
                resultado = n3;
            }

            return resultado;

        }

    }
}
