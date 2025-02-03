using ModificadoresRefOut;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Calculadora c1 = new Calculadora();

        Console.WriteLine("===============");
        Console.WriteLine("Modificador ref");

        int a = 2;
        c1.Dobro(ref a);

        Console.WriteLine(a);


        // Ambos fazem o parametro ser uma referencia para variavel original ... porem o out n exige que a variavel original seja inicializada ...

        Console.WriteLine("===============");
        Console.WriteLine("Modificador out");

        int b = 2;
        int triple;
        c1.Triplo(b,out triple);

        Console.WriteLine(triple);


        Console.WriteLine("===============");
        Console.WriteLine("Alternativa com Lambda nao verdadeira");

        //Alternativa moderna para n utilizar esses modificadores ...

        int valor = 4;
        int Quadruplicar(int numero) => numero * 4;
        
        Console.WriteLine(Quadruplicar(valor)); // Saída: 16


        // Essa expressao lambda não verdadeira é equivalente á:
        /*

        int Quadruplicar(int numero)
        {
            return numero * 4;
        }


        */


    }
}
