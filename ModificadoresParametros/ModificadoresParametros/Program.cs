using ModificadoresParametros;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("sem params");
        int teste1 = Calculadora.Soma(new int[] {3,7});
        Console.WriteLine(teste1);


        Console.WriteLine("=====================================");
        Console.WriteLine("com params");

        int teste2 = Calculadora.Soma2( 3, 2, 7, 8 );
        Console.WriteLine(teste2);


        //Objetivo desse codigo é resolver o problema de ter q fazer varios metodos de soma para determinadas quantidade de numeros de soma...
        // Para isso foi criado um metodo na classe Calculadora q recebe uma lista de numeros inteiros para aparti dela fazer a soma de todos os numeros
        
        //A utilização do params permite uma chamada menos rigorosa passando apenas os numeros de soma, sem ele temos q "instanciar" uma lista ...


    }
}
