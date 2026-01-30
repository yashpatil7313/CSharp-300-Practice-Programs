using System;

class Program
{
    static void Main()
    {
        string str = "CSharp";

        // Convert to uppercase
        string upper = str.ToUpper();

        // Convert to lowercase
        string lower = str.ToLower();

        Console.WriteLine("Uppercase: " + upper);
        Console.WriteLine("Lowercase: " + lower);
    }
}
