using System;

class Program60_CheckPrimeNumber
{
    static void Main()
    {
        int number = 7;
        bool isPrime = true;

        if (number <= 1)
            isPrime = false;

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not a Prime Number");
    }
}
