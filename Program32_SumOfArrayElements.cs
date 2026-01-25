using System;

class Program
{
    static void Main()
    {
        // Declare array
        int[] arr = { 10, 20, 30 };

        // Variable to store sum
        int sum = 0;

        // Add each element to sum
        foreach (int i in arr)
        {
            sum += i;
        }

        // Print sum
        Console.WriteLine("Sum = " + sum);
    }
}
