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



        public double ValorTotalEmEstoque()
        {

            return quantidade * preco;

        }

        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.quantidade -= quantidade;
        }


    }

    }

