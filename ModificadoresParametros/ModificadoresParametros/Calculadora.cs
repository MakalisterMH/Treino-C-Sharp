﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresParametros
{
    internal class Calculadora
    {
        public static int Soma(int[] numeros)
        {
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }

        public static int Soma2(params int[] numeros)
        {
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }

    }
}
