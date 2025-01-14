using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       

        double[] vetor = new double[3];

        vetor[0] = double.Parse(Console.ReadLine());
        vetor[1] = double.Parse(Console.ReadLine());
        vetor[2] = double.Parse(Console.ReadLine());


        double resultado = 0;


        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine(vetor[i]);

            resultado += vetor[i];

        }

        Console.WriteLine((resultado/vetor.Length).ToString("F2", CultureInfo.InvariantCulture));




    }




}