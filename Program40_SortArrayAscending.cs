using System;

class Program
{
    static void Main()
    {
        // Declare array
        int[] arr = { 40, 10, 30, 20 };

        // Sort array in ascending order
        Array.Sort(arr);

        // Print sorted array
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}
