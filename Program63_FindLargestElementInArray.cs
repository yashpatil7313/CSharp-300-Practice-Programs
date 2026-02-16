using System;

class Program63_FindLargestElementInArray
{
    static void Main()
    {
        int[] numbers = { 12, 45, 7, 89, 23 };

        int largest = numbers[0];

        // Find largest element
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine("Largest element = " + largest);
    }
}
