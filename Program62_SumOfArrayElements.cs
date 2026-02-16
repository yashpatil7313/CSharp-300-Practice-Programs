using System;

class Program62_SumOfArrayElements
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20 };
        int sum = 0;

        // Calculate sum
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Sum of array elements = " + sum);
    }
}
