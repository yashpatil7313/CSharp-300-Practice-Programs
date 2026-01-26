using System;

class Program
{
    static void Main()
    {
        // Declare array
        int[] arr = { 5, 25, 15, 10 };

        // Assume first element is largest
        int max = arr[0];

        // Compare each element
        foreach (int i in arr)
        {
            if (i > max)
                max = i;
        }

        // Print largest element
        Console.WriteLine("Largest = " + max);
    }
}
