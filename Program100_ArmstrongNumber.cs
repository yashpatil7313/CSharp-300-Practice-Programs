using System;

class Program
{
    static void Main()
    {
        int num, temp, digit;
        double sum = 0;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        temp = num;

        for (; num > 0; num = num / 10)
        {
            digit = num % 10;
            sum = sum + Math.Pow(digit, 3);
        }

        if (sum == temp)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not Armstrong Number");
    }
}
