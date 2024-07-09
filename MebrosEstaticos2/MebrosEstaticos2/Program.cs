using MebrosEstaticos2;
using System.Globalization;

class Program
{


    static void Main(string[] args)
    {

       // Calculadora calculadora = new Calculadora();     NÃO PRECISO INSTANCIAR POR QUE OS METODOS SÃO ESTATICOS

        Console.WriteLine("Digite o valor do Raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double cirunferencia = Calculadora.Circunferencia(raio);
        double volume = Calculadora.Volume(raio);

        Console.WriteLine("Circunferencia: " + cirunferencia.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

    }



}