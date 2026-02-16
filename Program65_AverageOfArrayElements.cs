using System;

class Program65_AverageOfArrayElements
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40 };
        int sum = 0;

        // Calculate sum
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        // Calculate average
        double average = (double)sum / numbers.Length;

        Console.WriteLine("Average = " + average);
    }
}
