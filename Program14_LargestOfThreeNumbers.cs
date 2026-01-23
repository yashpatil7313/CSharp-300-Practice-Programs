using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 25, c = 15;

        if (a > b && a > c)
            Console.WriteLine("A is greatest");
        else if (b > a && b > c)
            Console.WriteLine("B is greatest");
        else
            Console.WriteLine("C is greatest");
    }
}
