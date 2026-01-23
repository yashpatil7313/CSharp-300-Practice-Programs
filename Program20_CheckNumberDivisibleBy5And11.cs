using System;

class Program
{
    static void Main()
    {
        int num = 55;

        if (num % 5 == 0 && num % 11 == 0)
            Console.WriteLine("Divisible by 5 and 11");
        else
            Console.WriteLine("Not Divisible by 5 and 11");
    }
}
