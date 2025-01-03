class Program
{
    static void Main()
    {

        /* 
        Desafio: Gerenciar uma Lista de Nomes
        Você vai criar um programa que permite ao usuário gerenciar uma lista de nomes. O programa deve ter as seguintes funcionalidades:

        1 Adicionar nomes à lista.
        2 Remover um nome específico.
        3 Exibir todos os nomes da lista.
        
        */


        List<string> nomes = new List<string>();

        while (true)
        {


            Console.WriteLine("Digite 1 para inserir nome na lista, 2 para deletar nome da lista e 3 para imprimir toda a lista");
            int usuarioNumero = int.Parse(Console.ReadLine());

            if (usuarioNumero == 1)
            {
                Console.WriteLine("Digite o nome que deseja inserir na lista: ");
                string nome = Console.ReadLine();
                nomes.Add(nome);
            }
            else if (usuarioNumero == 2)
            {
                Console.WriteLine("Digite o nome que deseja remover na lista: ");
                string nome = Console.ReadLine();
                nomes.Remove(nome);
            }
            else if (usuarioNumero == 3)
            {
                foreach (string nome in nomes)
                {
                    Console.WriteLine(nome);
                }
            }
        }

    }
}

