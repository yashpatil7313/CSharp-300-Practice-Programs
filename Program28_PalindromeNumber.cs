using System;

class Program
{
    static void Main()
    {
        int num = 121;
        int temp = num;
        int rev = 0;

        while (num != 0)
        {
            int digit = num % 10;
            rev = rev * 10 + digit;
            num /= 10;
        }

        if (temp == rev)
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not a Palindrome Number");
    }
}
