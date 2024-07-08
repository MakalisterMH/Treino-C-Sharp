using ExercicioFuncionarioPOO;

class Program
{
    static void Main(string[] args)
    {

        Funcionario funcionario = new Funcionario();

        Console.WriteLine("Digite o nome do funcionario");
        funcionario.nome = Console.ReadLine();
        string nome = funcionario.nome;


        Console.WriteLine("Digite o salario do funcionario");
        funcionario.salario = double.Parse(Console.ReadLine());
        double salario = funcionario.salario;

        Console.WriteLine("Digite a porcentagem de aumento do salario desse funcionario");
        double porcentagem = double.Parse(Console.ReadLine());

        funcionario.AumentarSalario(porcentagem);

        Console.WriteLine("Considerando o aumento de {0}% sobre o salario de {1} $, o salario atualizado fica: {2} $.",porcentagem,salario,funcionario.salario);
    }
}
