using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> listaNumeros = new List<int>();

        listaNumeros.Add(9);
        listaNumeros.Add(2);
        listaNumeros.Add(10);
        listaNumeros.Add(7);
        listaNumeros.Add(5);
        listaNumeros.Add(6);
        listaNumeros.Add(4);
        listaNumeros.Add(8);
        listaNumeros.Add(1);
        listaNumeros.Add(3);

        // Ordena a lista em ordem crescente
        listaNumeros.Sort();

        // Exibe os números ordenados
        Console.WriteLine("Ordenação crescente:");
        foreach (int numero in listaNumeros)
        {
            Console.WriteLine(numero);
        }





        //=====================================================================================================================================================================

        // Ordenando em ordem decrescente sem lambda
        listaNumeros.Sort(Compare);


        // Exibe os números ordenados em ordem decrescente
        Console.WriteLine("\nOrdenação decrescente:");
        foreach (int numero in listaNumeros)
        {
            Console.WriteLine(numero);
        }

        static int Compare(int x, int y)
        {
            return y.CompareTo(x); // Comparação invertida para ordem decrescente
        }

        //=====================================================================================================================================================================



        // Ordenando em ordem decrescente com uma expressão lambda
        listaNumeros.Sort((x, y) => x.CompareTo(y)); // Expressão lambda para crescente

        // Exibe os números ordenados em ordem decrescente
        Console.WriteLine("\nOrdenação decrescente:");
        foreach (int numero in listaNumeros)
        {
            Console.WriteLine(numero);
        }


        

    }
}




