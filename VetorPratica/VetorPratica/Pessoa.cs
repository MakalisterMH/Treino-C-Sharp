using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorPratica
{
    class Pessoa
    {

        public string nome;
        public int idade;
        public double salario;

        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
        }

        public override string ToString()
        {
            return $"Nome: {nome}, Idade: {idade}, Salario: {salario}";
        }


    }
}
