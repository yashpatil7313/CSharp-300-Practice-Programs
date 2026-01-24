using System;

class Program
{
    static void Main()
    {
        int num = 1234;
        int rev = 0;

        while (num != 0)
        {
            int digit = num % 10;
            rev = rev * 10 + digit;
            num /= 10;
        }

        Console.WriteLine("Reverse = " + rev);
    }
}
