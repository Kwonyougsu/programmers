int[] chess = {1,1,2,2,2,8};

string input = Console.ReadLine();

string[] splitInput = input.Split(' ');

for (int i = 0; i < splitInput.Length; i++)
{
    chess[i] -= int.Parse(splitInput[i]);
}

Console.WriteLine(string.Join(" ",chess));