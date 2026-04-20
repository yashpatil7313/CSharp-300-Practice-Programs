Day24_Programs231-240

---

Program231_MaxSubarraySum_Kadane.cs

```csharp
using System;

class Program231_MaxSubarraySum_Kadane
{
    static void Main()
    {
        int[] arr = {-2,1,-3,4,-1,2,1,-5,4};

        int maxSoFar = arr[0];
        int current = arr[0];

        for(int i=1;i<arr.Length;i++)
        {
            current = Math.Max(arr[i], current + arr[i]);
            maxSoFar = Math.Max(maxSoFar, current);
        }

        Console.WriteLine("Max Subarray Sum = " + maxSoFar);
    }
}
```

---

Program232_MoveZerosToEnd.cs

```csharp
using System;

class Program232_MoveZerosToEnd
{
    static void Main()
    {
        int[] arr = {0,1,0,3,12};

        int index = 0;

        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i] != 0)
            {
                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
                index++;
            }
        }

        foreach(int num in arr)
            Console.Write(num + " ");
    }
}
```

---

Program233_FindMissingMultiple.cs

```csharp
using System;
using System.Linq;

class Program233_FindMissingMultiple
{
    static void Main()
    {
        int[] arr = {1,2,4,6};

        int n = 6;
        var full = Enumerable.Range(1, n);

        var missing = full.Except(arr);

        foreach(var num in missing)
            Console.Write(num + " ");
    }
}
```

---

Program234_LongestWordInString.cs

```csharp
using System;

class Program234_LongestWordInString
{
    static void Main()
    {
        string str = "CSharp is very powerful language";
        string[] words = str.Split(' ');

        string longest = "";

        foreach(string word in words)
        {
            if(word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine("Longest Word = " + longest);
    }
}
```

---

Program235_CharacterFrequencyMap.cs

```csharp
using System;
using System.Collections.Generic;

class Program235_CharacterFrequencyMap
{
    static void Main()
    {
        string str = "aabbccc";

        Dictionary<char,int> map = new Dictionary<char,int>();

        foreach(char c in str)
        {
            if(map.ContainsKey(c))
                map[c]++;
            else
                map[c] = 1;
        }

        foreach(var item in map)
            Console.WriteLine(item.Key + " = " + item.Value);
    }
}
```

---

Program236_RemoveNthNodeFromEnd_List.cs

```csharp
using System;
using System.Collections.Generic;

class Program236_RemoveNthNodeFromEnd_List
{
    static void Main()
    {
        List<int> list = new List<int> {1,2,3,4,5};
        int n = 2;

        list.RemoveAt(list.Count - n);

        foreach(int num in list)
            Console.Write(num + " ");
    }
}
```

---

Program237_TwoSum.cs

```csharp
using System;
using System.Collections.Generic;

class Program237_TwoSum
{
    static void Main()
    {
        int[] arr = {2,7,11,15};
        int target = 9;

        Dictionary<int,int> map = new Dictionary<int,int>();

        for(int i=0;i<arr.Length;i++)
        {
            int diff = target - arr[i];

            if(map.ContainsKey(diff))
            {
                Console.WriteLine("Indices: " + map[diff] + ", " + i);
                return;
            }

            map[arr[i]] = i;
        }
    }
}
```

---

Program238_ReverseLinkedList_List.cs

```csharp
using System;
using System.Collections.Generic;

class Program238_ReverseLinkedList_List
{
    static void Main()
    {
        List<int> list = new List<int> {1,2,3,4};

        list.Reverse();

        foreach(int num in list)
            Console.Write(num + " ");
    }
}
```

---

Program239_ValidPalindromeIgnoreCase.cs

```csharp
using System;

class Program239_ValidPalindromeIgnoreCase
{
    static void Main()
    {
        string str = "Madam";
        str = str.ToLower();

        string rev = "";

        for(int i=str.Length-1;i>=0;i--)
            rev += str[i];

        Console.WriteLine(str == rev ? "Palindrome" : "Not Palindrome");
    }
}
```

---

Program240_PatternPyramid.cs

```csharp
using System;

class Program240_PatternPyramid
{
    static void Main()
    {
        int n = 5;

        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=n-i;j++)
                Console.Write(" ");

            for(int k=1;k<=i;k++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }
}
```

---
