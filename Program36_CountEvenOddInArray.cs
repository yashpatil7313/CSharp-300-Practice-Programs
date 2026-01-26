using System;

class Program
{
    static void Main()
    {
        // Declare array
        int[] arr = { 1, 2, 3, 4, 5 };

        // Variables to count even and odd numbers
        int even = 0, odd = 0;

        // Check each element
        foreach (int i in arr)
        {
            if (i % 2 == 0)
                even++;   // Increment even count
            else
                odd++;    // Increment odd count
        }

        // Print results
        Console.WriteLine("Even = " + even);
        Console.WriteLine("Odd = " + odd);
    }
}
