class Program
{

    static void Main()
    {


        List<string> ClientesAviso = new List<string>();  // declaração de lista


        ClientesAviso.Add("Makalister");
        ClientesAviso.Add("Jackson");
        ClientesAviso.Add("Marcos");
        ClientesAviso.Add("Markin");
        ClientesAviso.Add("Gustavo");



        Console.WriteLine("Imprimindo com for: ");

        for (int i = 0; i < ClientesAviso.Count; i++)
        {
            Console.WriteLine(ClientesAviso[i]);
        }

        Console.WriteLine(" ");
        Console.WriteLine("Imprimindo com foreach: ");

        foreach (var cliente in ClientesAviso)
        {
            Console.WriteLine(cliente);
        }

    }
}




