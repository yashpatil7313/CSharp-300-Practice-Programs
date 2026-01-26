using System;

class Program
{
    static void Main()
    {
        // Source array
        int[] arr1 = { 1, 2, 3 };

        // Destination array with same size
        int[] arr2 = new int[arr1.Length];

        // Copy elements from arr1 to arr2
        for (int i = 0; i < arr1.Length; i++)
        {
            arr2[i] = arr1[i];
        }

        // Print copied array
        foreach (int i in arr2)
        {
            Console.WriteLine(i);
        }
    }
}
