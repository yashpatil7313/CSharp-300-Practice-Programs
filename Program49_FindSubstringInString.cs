using System;

class Program
{
    static void Main()
    {
        string str = "Hello CSharp";

        // Check if substring exists
        if (str.Contains("CSharp"))
            Console.WriteLine("Substring Found");
        else
            Console.WriteLine("Substring Not Found");
    }
}
