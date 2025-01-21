using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores
{
    class Estudantes
    {
        string Nome;
        string Email;

        public Estudantes(string nome,string email)
        {
            Nome = nome;
            Email = email;
        }

        // Sobrescreve o método ToString() para fornecer uma representação legível do objeto
        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}";
        }

    }
}
