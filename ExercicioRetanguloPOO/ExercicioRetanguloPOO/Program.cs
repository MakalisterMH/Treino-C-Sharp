using ExercicioRetanguloPOO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();

        Console.WriteLine("Digite a Lagura do retangulo: ");
        retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Console.WriteLine("Digite a Altura do retangulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        double area,perimetro,diagonal;

        area = retangulo.CalcularArea();
        perimetro = retangulo.CalcularPerimetro();
        diagonal = retangulo.CalcularDiagonal();

        Console.WriteLine(" ");

        Console.WriteLine("Area do retangulo: {0}",area.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("Perimetro do retangulo: {0}", perimetro.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("Diagonal do retangulo: {0}", diagonal.ToString("F2", CultureInfo.InvariantCulture));

    }
}