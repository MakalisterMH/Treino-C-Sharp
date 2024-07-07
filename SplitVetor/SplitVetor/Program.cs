string s = Console.ReadLine();

string[] vetor = s.Split(' ');


// ou =       string[] vetor =  Console.ReadLine().Split(' ');


// impressao com for

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine(vetor[i]);
}

// impressao com foreach

foreach (string fruta in vetor)
{
    Console.WriteLine(fruta);
}