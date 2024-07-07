using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritorio";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;


Console.WriteLine("Produtos: ");
Console.WriteLine("{0}, cujo o preço é $ {1}",produto1,preco1.ToString("F2"));
Console.WriteLine("{0}, cujo o preço é $ {1}", produto2, preco2.ToString("F2"));
Console.WriteLine("Registro: {0} anos de idade, código {1} e genêro {2}",idade,codigo,genero);


Console.WriteLine("Medida com oito casas decimais: {0}",medida.ToString("F8"));
Console.WriteLine("Medida com tres casas decimais: {0}", medida.ToString("F3"));
Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F2", CultureInfo.InvariantCulture));

