using System.Threading.Channels;
using Vetor2;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite o tamanho do vetor de produtos: ");
        int tamanho = int.Parse(Console.ReadLine());

        Produto[] produtos = new Produto[tamanho];
        

        for (int i = 0; i < produtos.Length; i++)
        {
         

            Console.WriteLine("Digite o nome do produto na posição "+i);
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do produto na posição " + i);
            double valor = double.Parse(Console.ReadLine());

            Produto produto = new Produto(nome,valor);

            produtos[i] = produto;
        }

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        for (int i = 0;i < produtos.Length; i++)
        {
            Console.WriteLine(produtos[i]);
        }


        


        double CalculoMedia(Produto[] produtos)
        {
            double resultado = 0;

            for (int i = 0; i < produtos.Length; i++)
            {
                
                resultado += produtos[i].Valor;
                
            }
            return resultado / produtos.Length;

        }

        Console.WriteLine("Media: "+ CalculoMedia(produtos));

    }

}
