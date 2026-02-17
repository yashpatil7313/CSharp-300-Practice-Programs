using System;

class Program66_ReverseArray
{
    static void Main()
    {
        // Declare and initialize array
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Original Array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();

        // Reverse the array using loop
        Console.WriteLine("Reversed Array:");
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}
