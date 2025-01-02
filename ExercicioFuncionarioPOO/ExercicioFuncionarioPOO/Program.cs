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


        Console.WriteLine("Digite o valor do imposto");
        funcionario.imposto = double.Parse(Console.ReadLine());


        Console.WriteLine("Digite a porcentagem de aumento do salario desse funcionario");
        double porcentagem = double.Parse(Console.ReadLine());






        Console.WriteLine($"salario antigo: {salario:F2}");
        Console.WriteLine($"Salário antigo líquido: {funcionario.SalarioLiquido(funcionario.imposto):F2}");  // Chama o método SalarioLiquido


        Console.WriteLine($"Salário com aumento: {funcionario.AumentarSalario(porcentagem):F2}");  // Chama o método AumentarSalario
        Console.WriteLine($"Salário novo liquido: {funcionario.SalarioComImposto(funcionario.imposto,porcentagem):F2}");  // Chama o método SalarioComImposto



    }
}
