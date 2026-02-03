using System;

class Program55_Factorial
{
    static void Main()
    {
        int number = 5;
        int factorial = 1;

        // Loop to calculate factorial
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        // Print result
        Console.WriteLine("Factorial = " + factorial);
    }
}
