using System;

class Program
{
    static void Main()
    {
        // Declare array
        int[] arr = { 1, 2, 3, 4, 5 };

        // Loop from last index to first
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            // Print elements in reverse order
            Console.WriteLine(arr[i]);
        }
    }
}
