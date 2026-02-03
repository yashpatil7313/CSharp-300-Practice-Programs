using System;

class Program54_MultiplicationTable
{
    static void Main()
    {
        int number = 5;

        // Loop to print table
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
    }
}
