string[] S = Console.ReadLine().Split(' ');
int N = int.Parse(S[0]);
int X = int.Parse(S[1]);
int[] A = new int[N]; 

string[] inputs = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    A[i] = int.Parse(inputs[i]);
    if (A[i] < 1 || A[i] > 10000)
    {
        return;
    }
}

for (int i = 0; i < N; i++)
{
    if (A[i] < X)
    {
        Console.Write(A[i] + " ");
    }
}
