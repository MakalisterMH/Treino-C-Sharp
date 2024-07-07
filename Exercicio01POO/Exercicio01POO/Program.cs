using Exercicio01POO;

class Program
{
    static void Main(string[] args)
    {

        int qtdPessoa;


        Pessoa pessoa = new Pessoa();

        pessoa.idade = 0;

        Console.WriteLine("Digite quantas pessoa sera digitada: ");
        qtdPessoa = int.Parse(Console.ReadLine());


        for (int i = 1; i <= qtdPessoa; i++)
        {

            string nome;
            int idade;



            Console.WriteLine("Digite o nome da pessoa: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa: ");
            idade = int.Parse(Console.ReadLine());


            if (pessoa.idade < idade)
            {
                pessoa.nome = nome;
                pessoa.idade = idade;
            }
        }

        Console.WriteLine("Pessoa mais velha é: "+ pessoa.nome + " " + pessoa.idade);

    }
}