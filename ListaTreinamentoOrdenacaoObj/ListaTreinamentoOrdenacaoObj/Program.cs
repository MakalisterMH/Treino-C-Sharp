namespace ListaTreinamentoOrdenacaoObj { 
class Program
    {
        static void Main()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>
        {
            new Pessoa("Ana", 25),
            new Pessoa("João", 32),
            new Pessoa("Carlos", 18),
            new Pessoa("Maria", 27)
        };

            // Ordenando por Idade (crescente)
            listaPessoas.Sort((x, y) => x.Idade.CompareTo(y.Idade));

            // Exibindo a lista ordenada
            foreach (var pessoa in listaPessoas)
            {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine(" ");

            Console.WriteLine("sem lambda ========================================================================================");

            Console.WriteLine(" ");



            // Ordenando a lista usando o comparador
            listaPessoas.Sort(Compare);

            // Exibindo a lista ordenada
            foreach (var pessoa in listaPessoas)
            {
                Console.WriteLine(pessoa);
            }


            static int Compare(Pessoa x, Pessoa y)
            {
                // Comparando as idades
                return x.Idade.CompareTo(y.Idade);
            }


        }
    }
}

