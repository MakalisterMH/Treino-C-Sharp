using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Pessoa
    {
        private string nome;
        private int idade;


        public Pessoa(string nome,int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string GetNome()
        {
        return this.nome; 
        }

        public int GetIdade()
        {
         return this.idade;
        }


        public void SetNome(int idade)
        {
            this.idade = idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }









        public override string ToString()
        {
            return "Nome: "+ GetNome() + " Idade: " + GetIdade();
        }
    }
}
