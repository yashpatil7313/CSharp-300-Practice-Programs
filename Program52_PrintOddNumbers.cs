using System;

class Program52_PrintOddNumbers
{
    static void Main()
    {
        // Loop from 1 to 20
        for (int i = 1; i <= 20; i++)
        {
            // Check if number is odd
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
