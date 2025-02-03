using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresRefOut
{
    internal class Calculadora
    {


        public void Dobro(ref int x)
        {
            x = x * 2;
        }



        public void Triplo(int numeroRecebido, out int resultado)
        {
            resultado = numeroRecebido * 3;
        }

        static int Quadruplicar(int numero) => numero * 4;




    }
}
