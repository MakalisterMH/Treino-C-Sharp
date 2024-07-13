using ExercicioBanco;

class Program
{
    static void Main(string[] args)
    {

        Pessoa pessoa = new Pessoa();


        Console.WriteLine("Entre com o numero da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o nome do titular: ");
        string nome = Console.ReadLine();


        Console.WriteLine("Haverá deposito inicial ? (s/n)");

        char depositoInicial = char.Parse(Console.ReadLine());


        if (depositoInicial == 's' || depositoInicial == 'S' )
        {
            Console.WriteLine("Entre com o valor inicial: ");
            double saldo = double.Parse(Console.ReadLine());


            pessoa.numeroConta = numeroConta;
            pessoa.nome = nome;
            pessoa.acrescentarSaldo(saldo);


            Console.WriteLine(pessoa.ToString());
            

        }

        else if (depositoInicial == 'n' || depositoInicial == 'N')
        {


            pessoa.numeroConta = numeroConta;
            pessoa.nome = nome;

            Console.WriteLine(pessoa.ToString());
        }



        Console.WriteLine("Entre com um valor para depositar: ");
        double valorDeposito = double.Parse(Console.ReadLine());

        pessoa.acrescentarSaldo(valorDeposito);

        Console.WriteLine("Dados da conta atualizado: ");
        Console.WriteLine(pessoa.ToString());


        Console.WriteLine("Entre com um valor para saque: ");
        double valorSaque = double.Parse(Console.ReadLine());

        pessoa.decrementarSaldo(valorSaque);

        Console.WriteLine("Dados da conta atualizado: ");
        Console.WriteLine(pessoa.ToString());


    }
}
