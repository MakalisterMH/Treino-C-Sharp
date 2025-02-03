class Program
{
    static void Main(string[] args)
    {

        int x = 10;


        Object obj = x;   // Processo de fazer um objeto do tipo valor virar referencia ...

        Console.WriteLine(obj);


        int y = (int)obj;   // Processo de fazer um objeto do tipo referencia virar um tipo valor compativel...

        Console.WriteLine(y);

    }
}