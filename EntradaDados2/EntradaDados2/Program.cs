using System.Globalization;

int n1 = int.Parse(Console.ReadLine());
char sexo = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    // importancia desse CultureInfo é para ele aceitar entradas flutuantes com " . "


Console.WriteLine("Você digitou: {0}",n1);
Console.WriteLine("Você digitou: {0}", sexo);
Console.WriteLine("Você digitou: {0}", n2);


// Console.WriteLine("Você digitou: {0}", n2.ToString(CultureInfo.InvariantCulture));       c eu colocar só na formatação ele so imprime com o " . " em vez da " , "



string nome = Console.ReadLine();
char sx = char.Parse(Console.ReadLine());
int idade = int.Parse(Console.ReadLine());
double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


Console.WriteLine("Olá {0} , seu sexo é {1} e você possui a idade {2} anos com {3} de altura",nome,sx,idade,altura);


