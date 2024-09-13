using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaProdutoPOO
{
    internal class Produto
    {

        public string nome;
        public double preco;
        public int quantidade;
        static double  total = 0;



        public Produto()
        { }



        public Produto(string nome, int quantidade)
        {
            this.nome = nome;
            this.quantidade = quantidade;
        }


        public Produto(string nome,double preco,int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }






        private static List<Produto> produtos = new List<Produto>();


        public static double ValorTotalEmEstoque()
        {
            total = 0;
            foreach (var produto in produtos)
            {

                total += produto.preco * produto.quantidade;
            }
            return total;
        }



        public static void AdicionarProdutos(string nome, double preco, int quantidade)
        {
            Produto produto = new Produto(nome,preco,quantidade);
            produtos.Add(produto);



        }

        public static void RemoverProduto(string nome)
        {
            // Encontrar o produto na lista
            Produto produto = produtos.Find(p => p.nome == nome);

            // Verificar se o produto foi encontrado
            if (produto != null)
            {
                // Remover o produto da lista
                produtos.Remove(produto);
                Console.WriteLine("Produto removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }



    }
  
}

    

    

