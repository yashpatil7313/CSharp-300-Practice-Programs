using System;

class Program57_CheckPalindromeNumber
{
    static void Main()
    {
        int number = 121;
        int original = number;
        int reverse = 0;

        // Reverse the number
        while (number != 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number /= 10;
        }

        // Check palindrome
        if (original == reverse)
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not a Palindrome Number");
    }
}
