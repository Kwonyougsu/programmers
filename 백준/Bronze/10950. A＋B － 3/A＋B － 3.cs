int T = int.Parse(Console.ReadLine());

for(int i = 0; i< T; i++)
{
    String[] N = Console.ReadLine().Split(' ');
    int A = int.Parse(N[0]);
    int B = int.Parse(N[1]);
    Console.WriteLine($"{A+B}");
}