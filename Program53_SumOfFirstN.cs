using System;

class Program53_SumOfFirstN
{
    static void Main()
    {
        int n = 10;
        int sum = 0;

        // Loop to calculate sum
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        // Print result
        Console.WriteLine("Sum = " + sum);
    }
}
