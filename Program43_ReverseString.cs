using System;

class Program
{
    static void Main()
    {
        string str = "CSharp";
        string rev = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            rev += str[i];
        }

        Console.WriteLine("Reversed String = " + rev);
    }
}
