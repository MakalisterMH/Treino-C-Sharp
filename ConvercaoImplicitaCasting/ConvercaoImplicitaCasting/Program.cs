float x = 4.5f;
double y = x;

Console.WriteLine(x);
Console.WriteLine(y);


// Compilador n permite jogar double dentro de float, para isso fazemos casting

double a = 2.3;
float b = (float)a;

Console.WriteLine(b);


// Compilador n permite jogar double dentro de int, para isso fazemos casting

double c = 2.3;
int d = (int)c;

Console.WriteLine(d);  // nesse caso os valores decimais dps da " , " vão ser truncados ... vão perder



// Fazendo casting para n perder as casas decimais e dar 2,5

int m = 5;
int n = 2;

double resultado = (double) m / n;

Console.WriteLine(resultado);