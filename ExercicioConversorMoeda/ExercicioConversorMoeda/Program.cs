using ExercicioConversorMoeda;

class Program{
    static void Main(string[] args)
    {


        

        Console.WriteLine("Qual é a cotação do dolar ? ");
        double cotacao = double.Parse(Console.ReadLine());


        Console.WriteLine("Qual é a quantidade de dolares que você quer comprar ? ");
        double quantidade = double.Parse(Console.ReadLine());


        Console.WriteLine("Valor a ser pago em reais: "+ ConversorDeMoeda.CotacaoDolar(cotacao, quantidade).ToString("F2"));

        


    }
}


