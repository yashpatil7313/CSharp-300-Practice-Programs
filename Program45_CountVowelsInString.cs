using System;

class Program
{
    static void Main()
    {
        string str = "education";
        int count = 0;

        foreach (char ch in str)
        {
            if (ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u'||
                ch=='A'||ch=='E'||ch=='I'||ch=='O'||ch=='U')
            {
                count++;
            }
        }

        Console.WriteLine("Number of vowels = " + count);
    }
}
