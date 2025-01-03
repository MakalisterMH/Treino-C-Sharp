using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTreinamento2
{
    internal class Tarefa
    {
        string nome;
        string descricao;
        int prioridade;

        public Tarefa()
        {
        }

        public Tarefa(string nome,string descricao,int prioridade)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.prioridade = prioridade;
        }

        // Propriedade Nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Propriedade Descricao
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        // Propriedade Prioridade
        public int Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }


        public override string ToString()
        {
            return $"Nome: {nome}, Descrição: {descricao}, Prioridade: {prioridade}";
        }

    }
}
