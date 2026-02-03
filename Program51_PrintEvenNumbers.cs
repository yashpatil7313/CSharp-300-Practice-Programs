using System;

class Program51_PrintEvenNumbers
{
    static void Main()
    {
        // Loop from 1 to 20
        for (int i = 1; i <= 20; i++)
        {
            // Check if number is even
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
