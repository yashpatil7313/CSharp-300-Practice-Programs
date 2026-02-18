using System;

class Program69_CopyArrayElements
{
    static void Main()
    {
        int[] original = { 10, 20, 30, 40 };
        int[] copy = new int[original.Length];

        // Copy elements
        for (int i = 0; i < original.Length; i++)
        {
            copy[i] = original[i];
        }

        Console.WriteLine("Copied Array:");
        for (int i = 0; i < copy.Length; i++)
        {
            Console.Write(copy[i] + " ");
        }
    }
}
