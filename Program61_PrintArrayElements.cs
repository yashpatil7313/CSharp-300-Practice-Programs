using System;

class Program61_PrintArrayElements
{
    static void Main()
    {
        // Declare and initialize array
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Loop through array
        Console.WriteLine("Array Elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
