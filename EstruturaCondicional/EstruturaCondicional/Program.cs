
int x = 10;

if (x > 9)
{
    Console.WriteLine("Bom dia");
}


if (x < 5)
{
Console.WriteLine("Boa tarde");
}



if (x == 10)
{
    Console.WriteLine("Boa noite");
}


Console.WriteLine("----------------------------------------------------------------------------------");  // exemplo com entrada de console


Console.WriteLine("Entre com um numero inteiro: ");
int numeroUsuario = int.Parse(Console.ReadLine());


if (numeroUsuario > 10)
{
    Console.WriteLine("O numero q vc digitou é maior q 10");
    Console.WriteLine("Numero digitado {0}",numeroUsuario);
}
else
{
    Console.WriteLine("O numero digitado não é maior que 10");
}

Console.WriteLine("----------------------------------------------------------------------------------");  // exemplo com entrada de console para numero par


Console.WriteLine("Entre com um numero inteiro para descobrir c é par: ");
int numeroPar = int.Parse(Console.ReadLine());


if (numeroPar % 2 == 0)
{
    Console.WriteLine("O numero q vc digitou é par");
    Console.WriteLine("Numero digitado {0}", numeroPar);
}
else
{
    Console.WriteLine("O numero que você digitou não é par");
}



Console.WriteLine("----------------------------------------------------------------------------------");  // Encadeamento


Console.WriteLine("Entre com um numero qualquer: ");
int numeroCorreto = int.Parse(Console.ReadLine());


if (numeroCorreto == 1)
{
    Console.WriteLine("O numero q vc digitou é 1");
}

else if (numeroCorreto == 2)
{
    Console.WriteLine("O numero q vc digitou é 1");
}

else if (numeroCorreto == 3)
{
    Console.WriteLine("O numero q vc digitou é 3");
}

else if (numeroCorreto == 4)
{
    Console.WriteLine("O numero q vc digitou é 4");
}

else
{
    Console.WriteLine("Não é nenhum numero de 1 a 4");
}

