String A = Console.ReadLine();
int sum=0;
for(int i =0; i<A.Length; i++)
{
    if (char.IsLetter(A[i])) 
    {
        sum++;
    }  
}
Console.WriteLine(sum);
