using System;

class Program
{
    static void Main()
    {
        string str = "   Hello World   ";

        // Remove leading and trailing whitespaces
        string result = str.Trim();

        Console.WriteLine("String after Trim: '" + result + "'");
    }
}
