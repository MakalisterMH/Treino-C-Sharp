using FuncoesSintaxe;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite 3 numeros: ");

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        NumeroMaior numeroMaior = new NumeroMaior();


        double resultado = numeroMaior.Maior(n1, n2, n3);

        Console.WriteLine("numero maior utilizando a funcao é: {0}." ,resultado);

    }

}
