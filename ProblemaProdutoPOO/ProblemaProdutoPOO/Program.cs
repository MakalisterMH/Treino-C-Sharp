using ProblemaProdutoPOO;

class Program
{
    static void Main(string[] args)
    {
        int numeroUsuario = -1;

        Produto produto = new Produto();

        while (numeroUsuario != 0)
        {


            Console.WriteLine("Digite 1 para adicionar produtos ou 2 para remover, se desejar sair do programa digite 0.");
            numeroUsuario = int.Parse(Console.ReadLine());



            if (numeroUsuario == 1)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();


                Console.WriteLine("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());


                Console.WriteLine("Digite a quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto.AdicionarProdutos(nome,preco,quantidade);

            }

            
            if (numeroUsuario == 2)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();


                Produto.RemoverProduto(nome);

            }


            double resultado = Produto.ValorTotalEmEstoque();

            Console.WriteLine("O valor total dos produtos em estoque é {0}", resultado);

        }
    }
}

