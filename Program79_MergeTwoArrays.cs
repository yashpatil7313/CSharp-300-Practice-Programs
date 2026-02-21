using System;

class Program79_MergeTwoArrays
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };

        int[] merged = new int[array1.Length + array2.Length];

        // Copy first array
        for (int i = 0; i < array1.Length; i++)
        {
            merged[i] = array1[i];
        }

        // Copy second array
        for (int i = 0; i < array2.Length; i++)
        {
            merged[array1.Length + i] = array2[i];
        }

        Console.WriteLine("Merged Array:");
        for (int i = 0; i < merged.Length; i++)
        {
            Console.Write(merged[i] + " ");
        }
    }
}
