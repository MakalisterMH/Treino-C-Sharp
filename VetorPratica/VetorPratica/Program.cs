using VetorPratica;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Vetor de Inteiros");


        int[] inteiros = new int[10];


        Console.WriteLine("Impressao com for");

        for (int i = 0; i < inteiros.Length; i++)
        {
            Console.WriteLine(inteiros[i]);
        }

        Console.WriteLine("Impressao com foreach");

        foreach (int numero in inteiros)
        {
            Console.WriteLine(numero);
        }


        // obs: caso o objeto é nulo é preciso fazer um "if" para conseguir imprimir corretamente.

         /*
         * Os tipos básicos têm valores padrão porque são estruturas de dados fixas que ocupam um espaço definido na memória. 
         * Já os objetos são tipos de referência, e o array contém apenas referências que inicialmente apontam para null até que 
         * sejam atribuídas a instâncias de objetos.
         */


        Console.WriteLine("Vetor de Objetos");

        Pessoa[] pessoas = new Pessoa[10];


        Console.WriteLine("Impressao com for");

        for (int i = 0;i < pessoas.Length; i++)
        {
            Console.WriteLine(pessoas[i]?.ToString() ?? "NULL");
        }

        Console.WriteLine("Impressao com foreach");

        foreach (Pessoa pessoa in pessoas)
        {
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
            }
            else
            {
                Console.WriteLine("Objeto nulo");
            }

            Console.WriteLine(pessoa?.ToString() ?? "NULL");

        }

    }
}
