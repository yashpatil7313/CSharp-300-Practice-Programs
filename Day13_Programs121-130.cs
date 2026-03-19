Program121_StringLength
using System;

class Program121_StringLength
{
    static void Main()
    {
        string str = "Hello World";
        Console.WriteLine("Length = " + str.Length);
    }
}


Program122_ReverseString.cs
using System;

class Program122_ReverseString
{
    static void Main()
    {
        string str = "CSharp";
        string rev = "";

        for(int i = str.Length - 1; i >= 0; i--)
        {
            rev += str[i];
        }

        Console.WriteLine("Reversed String = " + rev);
    }
}


Program123_CheckPalindromeString.cs
using System;

class Program123_CheckPalindromeString
{
    static void Main()
    {
        string str = "madam";
        string rev = "";

        for(int i = str.Length - 1; i >= 0; i--)
        {
            rev += str[i];
        }

        if(str == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}


Program124_CountVowels.cs
using System;

class Program124_CountVowels
{
    static void Main()
    {
        string str = "education";
        int count = 0;

        foreach(char ch in str)
        {
            if("aeiouAEIOU".Contains(ch))
                count++;
        }

        Console.WriteLine("Vowels = " + count);
    }
}


Program125_CountWords.cs
using System;

class Program125_CountWords
{
    static void Main()
    {
        string str = "Hello World from CSharp";

        int count = str.Split(' ').Length;

        Console.WriteLine("Word Count = " + count);
    }
}


Program126_RemoveSpaces.cs
using System;

class Program126_RemoveSpaces
{
    static void Main()
    {
        string str = "Hello World";

        string result = str.Replace(" ", "");

        Console.WriteLine("Without Spaces: " + result);
    }
}


Program127_ToUpperCase.cs
using System;

class Program127_ToUpperCase
{
    static void Main()
    {
        string str = "hello";

        Console.WriteLine(str.ToUpper());
    }
}


Program128_ToLowerCase.cs
using System;

class Program128_ToLowerCase
{
    static void Main()
    {
        string str = "HELLO";

        Console.WriteLine(str.ToLower());
    }
}


Program129_CompareStrings.cs
using System;

class Program129_CompareStrings
{
    static void Main()
    {
        string str1 = "abc";
        string str2 = "abc";

        if(str1 == str2)
            Console.WriteLine("Strings are Equal");
        else
            Console.WriteLine("Strings are Not Equal");
    }
}


Program130_ConcatenateStrings.cs
using System;

class Program130_ConcatenateStrings
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";

        string result = str1 + " " + str2;

        Console.WriteLine(result);
    }
}
