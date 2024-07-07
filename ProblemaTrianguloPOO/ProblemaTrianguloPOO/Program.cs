using ProblemaTrianguloPOO;
using System;

class Program
{
    static  void Main(string[] args)
    {

        double a, b, c;

        Console.WriteLine("Olá vamos calcular o perimetro e a area de um triangulo.");

        Console.WriteLine("Por favor insira o valor do lado A:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Por favor insira o valor do lado B:");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Por favor insira o valor do lado C:");
        c = double.Parse(Console.ReadLine());


        Triangulo triangulo = new Triangulo(a,b,c);



        Console.WriteLine(triangulo.CalcularPerimetro());
        Console.WriteLine(triangulo.CalcularArea());


    }

}
