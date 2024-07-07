using System.Globalization;

string nome;
int idade;
string email;
char sexo;
double salario;


Console.Write("Olá"); // Sem quebra de Linha
Console.WriteLine(" Mundo");  // Com quebra de Linha



Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite seu email");
email = Console.ReadLine();

Console.WriteLine("Digite seu sexo, 'M' para Masculino e 'F' para feminino.");
sexo = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Digite seu salario");
salario = Convert.ToDouble(Console.ReadLine());



Console.WriteLine("Olá {0}, você tem {1} anos e possui o sexo {2}, seu email para contato é: {3} e você possui um salario de {4}",
nome,idade,sexo,email,salario.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos e possui o sexo " + sexo +", seu email para contato é: " + email + 
" e você possui um salário de " + salario.ToString("F2", CultureInfo.InvariantCulture));

 
Console.WriteLine($"{salario:F2}");  // Interpolação para casas decimais