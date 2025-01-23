class Program
{
    static void Main(string[] args)
    {
        // double X = null;   Basicamente ele não aceita valores nulos, para isso usamos o Nullable para valores opcionais.


        // duas formas de usar o Nullable
        Nullable<double> X = null;
        double? Y = null;

        Console.WriteLine(Y);

        double? Z = 10;

        Console.WriteLine(Y.GetValueOrDefault());  // Essa operação vai pegar o valor q tem e caso for nulo vai pegar o valor padrao.
        Console.WriteLine(Z.GetValueOrDefault());

        Console.WriteLine(X.HasValue);  // Essa operação retorna falso caso n tenha valor e verdadeiro caso tenha.
        Console.WriteLine(Z.HasValue);


        //essa operação retorna o valor, caso n tenha nada ele vai dar erro ... por isso utilizamos o if para "tratar"

        if (X.HasValue)
        {
            Console.WriteLine(X.Value);
        }
        else
        {
            Console.WriteLine(Z.Value);
        }

        // Operador de coalescência nula

        double? M = null;

        double N = M ?? 7;  // N recebe M e caso M seja nulo ele vai receber "7"

        Console.WriteLine(N);
    }
}
