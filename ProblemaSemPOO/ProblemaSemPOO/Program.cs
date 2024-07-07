using System.Globalization;

double a, b, c, p, area;



Console.WriteLine("Digite o lado A do triangulo: ");
a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


Console.WriteLine("Digite o lado B do triangulo: ");
b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Digite o lado C do triangulo: ");
c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


p = (a + b + c) / 2;

area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));


Console.WriteLine("O perimetro do triangulo é: {0}",area.ToString("F4",CultureInfo.InvariantCulture));