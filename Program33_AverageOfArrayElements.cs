using System;

class Program
{
    static void Main()
    {
        // Declare array
        int[] arr = { 10, 20, 30 };
        int sum = 0;

        // Calculate sum of elements
        foreach (int i in arr)
        {
            sum += i;
        }

        // Calculate and print average
        Console.WriteLine("Average = " + (sum / arr.Length));
    }
}
