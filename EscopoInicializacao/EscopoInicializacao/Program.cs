// qualquer variavel tem q ser inicializada para você poder utilizar.       

// declaração de variaveis dentro de uma estrutura so pertence ao escopo daquela estrutura.


double preco = double.Parse(Console.ReadLine());
double desconto = 0.0;                           // inicialização da variavel

if (preco > 100.0)
{
    desconto = preco * 0.1;                     // c a variavel tivesse declarada dentro do escopo do if eu n  poderia utilizala para imprimir ela fora.
}

Console.WriteLine(desconto);
