Console.WriteLine("Quantos numeros vc vai digitar ? ");

int numeroUsuario = int.Parse(Console.ReadLine());

for (int i = 1; i <= numeroUsuario; i++)
{
    Console.WriteLine("Digite o numero {0}:",i);

    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine("Numero {0} = {1}",i,numero);
}