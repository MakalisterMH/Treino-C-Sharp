using System.Globalization;

class Program
{
    static double Pi = 3.14;

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do Raio: ");
        double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        double cirunferencia = Circunferencia(raio);
        double volume = Volume(raio);

        Console.WriteLine("Circunferencia: " + cirunferencia.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

    }

    static double Circunferencia(double raio)
    {
        return 2.0 * Pi * raio;
    }

    static double Volume(double raio)
    {
        return 4.0 /3 * Pi * Math.Pow(raio,3);
    }

}