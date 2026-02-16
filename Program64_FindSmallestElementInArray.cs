using System;

class Program64_FindSmallestElementInArray
{
    static void Main()
    {
        int[] numbers = { 12, 45, 7, 89, 23 };

        int smallest = numbers[0];

        // Find smallest element
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }

        Console.WriteLine("Smallest element = " + smallest);
    }
}
