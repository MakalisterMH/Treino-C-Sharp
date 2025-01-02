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

        public double SalarioLiquido(double imposto)
        {
            return salario - imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
           return salario += (porcentagem * salario) / 100; 
        }

        public double SalarioComImposto(double imposto, double porcentagem)
        {

            return salario -= AumentarSalario(porcentagem) - SalarioLiquido(imposto);
            
        }

    }
}
