string[] a = Console.ReadLine().Split(' ');
int A = int.Parse(a[0]);
int B = int.Parse(a[1]);
int C = int.Parse(a[2]);
int sum = 0;

    if (A == B && B == C) 
    {
        sum = 10000 + (A * 1000);
    }
    else if (A == B)
    {
        sum = (1000 + A * 100);
    }
    else if (A == C)
    {
        sum = (1000 + A * 100);
    }
    else if (B == C)
    {
        sum = (1000 + B * 100);
    }
    else
    {
        if (A > B && A > C)
        {
            sum = (100 * A);
        }
        else if(B > C)
        {
            sum = (100 * B);
        }
        else
        {
            sum = (100 * C);
        }
     }
Console.WriteLine(sum);