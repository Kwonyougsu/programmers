string[] s = Console.ReadLine().Split();
if (int.Parse(s[0]) != 0 && int.Parse(s[1]) != 0)
{
    Console.WriteLine(double.Parse(s[0]) / double.Parse(s[1]));
}