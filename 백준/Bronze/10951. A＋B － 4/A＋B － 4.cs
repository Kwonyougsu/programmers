while(true)
{
    String N = Console.ReadLine();
    if(N == null)
        break;
    String[] NA = N.Split();
    int A = int.Parse(NA[0]);
    int B = int.Parse(NA[1]);
    int C = A+B;
    Console.WriteLine($"{C}");
}