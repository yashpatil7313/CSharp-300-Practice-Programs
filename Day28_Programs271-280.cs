Day28_Programs271-280
Program271_LargestInMatrix.cs
using System;

class Program271_LargestInMatrix
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {9, 5, 6},
            {7, 8, 4}
        };

        int max = matrix[0,0];

        foreach(int num in matrix)
        {
            if(num > max)
                max = num;
        }

        Console.WriteLine("Max = " + max);
    }
}
Program272_SumOfMatrixElements.cs
using System;

class Program272_SumOfMatrixElements
{
    static void Main()
    {
        int[,] matrix = {
            {1,2,3},
            {4,5,6}
        };

        int sum = 0;

        foreach(int num in matrix)
            sum += num;

        Console.WriteLine("Sum = " + sum);
    }
}
Program273_TransposeMatrix.cs
using System;

class Program273_TransposeMatrix
{
    static void Main()
    {
        int[,] matrix = {
            {1,2},
            {3,4}
        };

        for(int i=0;i<2;i++)
        {
            for(int j=0;j<2;j++)
            {
                Console.Write(matrix[j,i] + " ");
            }
            Console.WriteLine();
        }
    }
}
Program274_MatrixMultiplication.cs
using System;

class Program274_MatrixMultiplication
{
    static void Main()
    {
        int[,] a = { {1,2}, {3,4} };
        int[,] b = { {5,6}, {7,8} };
        int[,] result = new int[2,2];

        for(int i=0;i<2;i++)
        {
            for(int j=0;j<2;j++)
            {
                for(int k=0;k<2;k++)
                {
                    result[i,j] += a[i,k] * b[k,j];
                }

                Console.Write(result[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
Program275_SparseMatrixCheck.cs
using System;

class Program275_SparseMatrixCheck
{
    static void Main()
    {
        int[,] matrix = {
            {0,0,3},
            {0,0,0},
            {1,0,0}
        };

        int zero = 0;
        int total = 9;

        foreach(int num in matrix)
        {
            if(num == 0)
                zero++;
        }

        Console.WriteLine(zero > total/2 ? "Sparse Matrix" : "Not Sparse");
    }
}
Program276_StringCompression.cs
using System;

class Program276_StringCompression
{
    static void Main()
    {
        string str = "aabbccc";
        int count = 1;

        for(int i=0;i<str.Length;i++)
        {
            if(i+1 < str.Length && str[i] == str[i+1])
            {
                count++;
            }
            else
            {
                Console.Write(str[i] + "" + count);
                count = 1;
            }
        }
    }
}
Program277_CharacterReplacement.cs
using System;

class Program277_CharacterReplacement
{
    static void Main()
    {
        string str = "hello";
        string result = "";

        foreach(char c in str)
        {
            if("aeiou".Contains(c))
                result += '*';
            else
                result += c;
        }

        Console.WriteLine(result);
    }
}
Program278_StringRotationCheck.cs
using System;

class Program278_StringRotationCheck
{
    static void Main()
    {
        string s1 = "abcde";
        string s2 = "cdeab";

        string temp = s1 + s1;

        Console.WriteLine(temp.Contains(s2) ? "Rotation" : "Not Rotation");
    }
}
Program279_SubstringSearch.cs
using System;

class Program279_SubstringSearch
{
    static void Main()
    {
        string text = "hello world";
        string pattern = "world";

        Console.WriteLine(text.Contains(pattern) ? "Found" : "Not Found");
    }
}
Program280_LongestSubstringNoRepeat.cs
using System;
using System.Collections.Generic;

class Program280_LongestSubstringNoRepeat
{
    static void Main()
    {
        string str = "abcabcbb";

        HashSet<char> set = new HashSet<char>();

        int left = 0;
        int maxLen = 0;

        for(int right=0; right<str.Length; right++)
        {
            while(set.Contains(str[right]))
            {
                set.Remove(str[left]);
                left++;
            }

            set.Add(str[right]);
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        Console.WriteLine("Max Length = " + maxLen);
    }
}