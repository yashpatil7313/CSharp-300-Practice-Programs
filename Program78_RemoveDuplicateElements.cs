using System;

class Program78_RemoveDuplicateElements
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 2, 4, 1 };

        Console.WriteLine("Array without duplicates:");

        for (int i = 0; i < numbers.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
                Console.Write(numbers[i] + " ");
        }
    }
}
