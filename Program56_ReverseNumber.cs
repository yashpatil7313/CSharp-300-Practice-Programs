using System;

class Program56_ReverseNumber
{
    static void Main()
    {
        int number = 1234;
        int reverse = 0;

        // Loop until number becomes 0
        while (number != 0)
        {
            int digit = number % 10;   // Get last digit
            reverse = reverse * 10 + digit;
            number = number / 10;      // Remove last digit
        }

        Console.WriteLine("Reversed Number = " + reverse);
    }
}
