using System;

class Program
{
    static void Main()
    {
        int num = 4567;
        int count = 0;

        while (num != 0)
        {
            count++;
            num /= 10;
        }

        Console.WriteLine("Number of digits = " + count);
    }
}
