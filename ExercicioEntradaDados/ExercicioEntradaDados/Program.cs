using System.Globalization;

string nomeCompleto;
int quartos;
double precoProduto;
string fraseSplit;


Console.WriteLine("Digite seu nome completo: ");
nomeCompleto = Console.ReadLine();


Console.WriteLine("Digite quantos quartos tem na sua casa: ");
quartos =  int.Parse(Console.ReadLine());


Console.WriteLine("Entre com o preço de um produto: ");
precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


Console.WriteLine("Entre com seu ultimo nome, idade e altura mesma linha: ");
string[] vetor = Console.ReadLine().Split(' ');

Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoProduto.ToString("F2",CultureInfo.InvariantCulture));

foreach (string item in vetor)
{
    Console.WriteLine(item);
}

