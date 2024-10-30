using System.Text;

int N = int.Parse(Console.ReadLine());     
 
if (N > 0 && N <= 100000)
{
    StringBuilder output = new StringBuilder();
    for (int i = 1; i <= N; i++)
    {
        output.AppendLine(i.ToString());
    }
    
    Console.Write(output.ToString());
}