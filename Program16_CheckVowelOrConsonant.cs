using System;

class Program
{
    static void Main()
    {
        char ch = 'a';

        if (ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u'||
            ch=='A'||ch=='E'||ch=='I'||ch=='O'||ch=='U')
            Console.WriteLine("Vowel");
        else
            Console.WriteLine("Consonant");
    }
}
