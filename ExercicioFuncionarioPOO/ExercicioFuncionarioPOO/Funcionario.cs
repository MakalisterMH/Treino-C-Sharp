using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFuncionarioPOO
{
    internal class Funcionario
    {
        public string nome;
        public double salario;
        public double imposto;

        public double SalarioLiquido()
        {
            return salario -= imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salario += (porcentagem * salario) / 100; 
        }

    }
}
