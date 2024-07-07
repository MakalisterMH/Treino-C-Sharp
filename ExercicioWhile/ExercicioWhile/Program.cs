

Console.WriteLine("Digite um numero: ");

int numeroDigitado = int.Parse(Console.ReadLine());


while (numeroDigitado <= 50)
{
    Console.WriteLine(Math.Sqrt(numeroDigitado));

    Console.WriteLine("Digite outro numero: ");

    numeroDigitado = int.Parse(Console.ReadLine());

}

Console.WriteLine("Numero maior que 50.");

