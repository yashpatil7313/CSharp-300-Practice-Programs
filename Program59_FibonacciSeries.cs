using System;

class Program59_FibonacciSeries
{
    static void Main()
    {
        int n = 10;
        int a = 0, b = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }
}
