using System;

class Program
{
    static void Main()
    {
        // Declare array
        int[] arr = { 5, 25, 15, 10 };

        // Assume first element is smallest
        int min = arr[0];

        // Compare each element
        foreach (int i in arr)
        {
            if (i < min)
                min = i;
        }

        // Print smallest element
        Console.WriteLine("Smallest = " + min);
    }
}
