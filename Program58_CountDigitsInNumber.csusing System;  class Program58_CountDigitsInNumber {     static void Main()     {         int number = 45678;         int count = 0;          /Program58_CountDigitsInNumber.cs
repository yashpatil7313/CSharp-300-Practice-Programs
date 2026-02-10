using System;

class Program58_CountDigitsInNumber
{
    static void Main()
    {
        int number = 45678;
        int count = 0;

        // Count digits
        while (number != 0)
        {
            count++;
            number /= 10;
        }

        Console.WriteLine("Number of digits = " + count);
    }
}
