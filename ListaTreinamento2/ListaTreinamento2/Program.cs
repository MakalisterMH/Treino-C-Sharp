using ListaTreinamento2;

class Program
{
    static void Main()
    {

        List<Tarefa> listaTarefas = new List<Tarefa>();
        

        while (true)
        {


            Console.WriteLine("Digite 1 para inserir tarefa na lista, 2 para deletar tarefa da lista e 3 para imprimir todas as tarefas");
            int usuarioNumero = int.Parse(Console.ReadLine());

            if (usuarioNumero == 1)
            {
                Console.WriteLine("Digite o nome que deseja inserir na tarefa: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a descrição que deseja inserir na tarefa: ");
                string descricao = Console.ReadLine();

                Console.WriteLine("Digite a prioridade que deseja inserir na tarefa: 1 para alta, 2 para media e 3 para baixa.");
                int prioridade = int.Parse(Console.ReadLine());

                Tarefa tarefa = new Tarefa(nome,descricao,prioridade);
                listaTarefas.Add(tarefa);

            }

            else if (usuarioNumero == 2)
            {
                

                Console.WriteLine("Digite o nome da tarefa que deseja remover na lista: ");
                string nome = Console.ReadLine();



                foreach (Tarefa tarefa in listaTarefas)
                {
                    if (tarefa.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                    {
                        listaTarefas.Remove(tarefa);

                        break; // Encontramos a tarefa e removemos, podemos sair do loop
                    }
                }

            }


            else if (usuarioNumero == 3)
            {
                foreach (Tarefa tarefa in listaTarefas)
                {
                    Console.WriteLine(tarefa);
                }
            }
        }




    }
}
