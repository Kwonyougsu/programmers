int T = int.Parse(Console.ReadLine());

for(int i =1; i<= T; i++)
{
    String[] N = Console.ReadLine().Split(' ');
    int A = int.Parse(N[0]);
    int B = int.Parse(N[1]);
    int C = A+B;
    Console.WriteLine($"Case #{i}: {A} + {B} = {C}");
}