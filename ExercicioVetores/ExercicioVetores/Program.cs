using ExercicioVetores;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {


        
        Estudantes[] estudantes = new Estudantes[9];

        Console.WriteLine("Digite a quantidade de estudantes que vao alugar quartos: ");

        int numeroEstudantes = int.Parse(Console.ReadLine());


        for (int i = 0; i < numeroEstudantes; i++)
        {
            Console.WriteLine("Digite o nome do Estudante: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o email do Estudante: ");
            string email = Console.ReadLine();

            Estudantes es = new Estudantes(nome,email);

            Console.WriteLine("=============================================");
            Console.WriteLine("Disponibilidade de quartos:");
            Console.WriteLine("=============================================");



            /*

            for (int a = 0; a < estudantes.Length; a++)
            {
                string status = estudantes[a] == null ? "Disponível" : "Ocupado";
                Console.WriteLine($"Quarto {a}: {status}");
            }

             */


            for (int a = 0; a < estudantes.Length; a++)
            {
                if (estudantes[a] != null)
                {
                    Console.WriteLine("Quarto " + a + ": " + estudantes[a]);
                }
                else
                {
                    Console.WriteLine("Quarto " + a + ": Disponível");
                }
            }


            Console.WriteLine("=============================================");

            Console.WriteLine("Qual quarto voce quer colocar esse estudante ?");
            int q = int.Parse(Console.ReadLine());

            estudantes[q] = es;


            int y = 0;
            foreach (Estudantes a in estudantes)
            {
                
                Console.WriteLine("Quarto: "+ y + " " + a);
                y += 1;
            }

        }










    }
}
