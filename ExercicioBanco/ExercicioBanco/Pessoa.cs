using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    internal class Pessoa
    {

        public int numeroConta {  get; set; }
        public string nome { get; set; }
        public double saldo { get; private set; }


        public Pessoa()
        {
        }

        public Pessoa(int numeroConta, string nome, double saldo)
        {
            this.numeroConta = numeroConta;
            this.nome = nome;
            this.saldo = saldo;
        }

        public Pessoa(int numeroConta, string nome)
        {
            this.numeroConta = numeroConta;
            this.nome = nome;
        }

        public void acrescentarSaldo(double valor)
        {
            this.saldo += valor;
        }

        public void decrementarSaldo(double valor)
        {
            this.saldo -= valor;
        }


        public override string ToString()
        {
            return string.Format("Dados: Conta: {0}, Titular: {1}, Saldo: {2:C}", this.numeroConta, this.nome, this.saldo);
        }


    }
}
