/*
 
 * (Multiplicação)   / (divisao)   % (resto da divisão)   TEM PRECEDÊNCIA MAIOR QUE + E - 
 
*/

Console.WriteLine(17 % 3);   // Resto 2 da divisão



int n1 = 3 + 4 * 2;   // Multiplicação primeiro

Console.WriteLine(n1);


int n2 = (3 + 4) * 2;

Console.WriteLine(n2);  // Parentese primeiro


double n3 = (double) 10 / 8;   // quando o calculo so tem numero inteiro automaticamente o compilador entende q vc quer resultado inteiro ... para evitar de dar o resultado "1"
                               // podemos fazer casting para ter os decimais e obeter o resultado correto q seria 1,25
Console.WriteLine(n3);


n3 = 10.0 / 8;               // mesmo exemplo anterior ... se pelomenos 1 dos numero for flutuante o resultado ja volta com decimal
Console.WriteLine(n3);




// calcular Bascara



double a = 1.0, b = -3.0, c = -4.0;

double delta = Math.Pow(b ,2.0) - 4.0 * a * c;  // Calculo de Delta   /  função para potencia

Console.WriteLine("Delta = {0}",delta);


double x1 = (-b + Math.Sqrt(delta)) / (2 * a);    // Raiz quadrada de Delta

Console.WriteLine(x1);

double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine(x2);