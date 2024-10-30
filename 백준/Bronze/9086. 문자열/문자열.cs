int A = int.Parse(Console.ReadLine());

for(int i =0; i < A; i++)
{
    String word = Console.ReadLine();
    Console.WriteLine($"{word[0]}{word[word.Length-1]}");
}

