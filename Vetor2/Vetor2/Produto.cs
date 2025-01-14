using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor2
{
    internal class Produto
    {

        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Valor = preco;
        }

        // Sobrescreve o método ToString para formatar a saída
        public override string ToString()
        {
            return $"Produto: {Nome}, Valor: R${Valor:F2}";
        }


       


    }



}
