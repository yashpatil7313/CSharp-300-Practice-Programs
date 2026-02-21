using System;

class Program77_FindDuplicateElements
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 2, 4, 1 };

        Console.WriteLine("Duplicate Elements:");

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    Console.WriteLine(numbers[i]);
                    break;
                }
            }
        }
    }
}
