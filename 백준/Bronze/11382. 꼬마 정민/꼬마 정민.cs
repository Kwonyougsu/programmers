String a = Console.ReadLine();
String[] aInput = a.Split(' ');
long sum = 0;
for(int i =0; i < aInput.Length; i++)
{
    sum = sum + long.Parse(aInput[i]);
}
Console.WriteLine(sum);

