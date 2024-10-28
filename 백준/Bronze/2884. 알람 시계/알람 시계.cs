string[] a = Console.ReadLine().Split(' ');
int H = int.Parse(a[0]);
int M = int.Parse(a[1]);

if (H < 0 || M < 0 || H > 23 || M > 59) return;

if (M >= 45)
{
    Console.WriteLine($"{H} {M - 45}");
}
else
{
    H--; 
    if (H < 0)
    {
        H = 23;
    }
    Console.WriteLine($"{H} {M + 15}");
}
