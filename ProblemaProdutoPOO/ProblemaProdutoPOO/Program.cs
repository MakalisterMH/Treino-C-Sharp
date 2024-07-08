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
            produto.nome = Console.ReadLine();


            Console.WriteLine("Digite o preço do produto: ");
            produto.preco = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite a quantidade do produto: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));




        }


            if (numeroUsuario == 2)
            {
                Console.WriteLine("Digite o nome do produto: ");
                produto.nome = Console.ReadLine();


                Console.WriteLine("Digite o preço do produto: ");
                produto.preco = double.Parse(Console.ReadLine());


                Console.WriteLine("Digite a quantidade do produto: ");
                produto.RemoverProdutos(int.Parse(Console.ReadLine()));



            }

            Console.WriteLine("Valor total no estoque é de: {0}", produto.ValorTotalEmEstoque());

        }

    }
}
