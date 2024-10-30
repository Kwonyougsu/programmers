        int N = int.Parse(Console.ReadLine());

        string[] inputNumbers = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(inputNumbers, int.Parse); 

        int v = int.Parse(Console.ReadLine());

        int count = 0;

        foreach (int number in numbers)
        {
            if (number == v)
            {
                count++;
            }
        }
        Console.WriteLine(count);