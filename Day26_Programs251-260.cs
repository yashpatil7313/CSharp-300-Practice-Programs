Day26_Programs251-260

---

Program251_FindDuplicateInArray.cs

```csharp id="q8w2kp"
using System;
using System.Collections.Generic;

class Program251_FindDuplicateInArray
{
    static void Main()
    {
        int[] arr = {1,2,3,2,4,5,1};

        HashSet<int> set = new HashSet<int>();

        foreach(int num in arr)
        {
            if(set.Contains(num))
                Console.WriteLine("Duplicate = " + num);
            else
                set.Add(num);
        }
    }
}
```

---

Program252_ReverseNumber.cs

```csharp id="w2k9sl"
using System;

class Program252_ReverseNumber
{
    static void Main()
    {
        int n = 12345;
        int rev = 0;

        while(n > 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }

        Console.WriteLine("Reversed = " + rev);
    }
}
```

---

Program253_SwapWithoutTemp.cs

```csharp id="k8x1md"
using System;

class Program253_SwapWithoutTemp
{
    static void Main()
    {
        int a = 10, b = 20;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = " + a + ", b = " + b);
    }
}
```

---

Program254_CountVowelsConsonants.cs

```csharp id="p3n7vq"
using System;

class Program254_CountVowelsConsonants
{
    static void Main()
    {
        string str = "hello world";
        int vowels = 0, consonants = 0;

        foreach(char c in str)
        {
            if("aeiouAEIOU".Contains(c))
                vowels++;
            else if(char.IsLetter(c))
                consonants++;
        }

        Console.WriteLine("Vowels = " + vowels);
        Console.WriteLine("Consonants = " + consonants);
    }
}
```

---

Program255_FibonacciSeries.cs

```csharp id="r4t6lp"
using System;

class Program255_FibonacciSeries
{
    static void Main()
    {
        int n = 10;
        int a = 0, b = 1;

        for(int i=1;i<=n;i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
    }
}
```

---

Program256_CheckPowerOfTwo.cs

```csharp id="x7b2qw"
using System;

class Program256_CheckPowerOfTwo
{
    static void Main()
    {
        int n = 16;

        bool isPower = (n > 0) && ((n & (n - 1)) == 0);

        Console.WriteLine(isPower ? "Power of 2" : "Not Power of 2");
    }
}
```

---

Program257_FindGCD.cs

```csharp id="m9v4zk"
using System;

class Program257_FindGCD
{
    static void Main()
    {
        int a = 36, b = 60;

        while(b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine("GCD = " + a);
    }
}
```

---

Program258_FindLCM.cs

```csharp id="n2c8jh"
using System;

class Program258_FindLCM
{
    static void Main()
    {
        int a = 12, b = 15;
        int gcd = 1;

        int x = a, y = b;

        while(y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }

        gcd = x;

        int lcm = (a * b) / gcd;

        Console.WriteLine("LCM = " + lcm);
    }
}
```

---

Program259_CheckArmstrongRange.cs

```csharp id="c6m1xz"
using System;

class Program259_CheckArmstrongRange
{
    static void Main()
    {
        for(int i=1;i<=500;i++)
        {
            int temp = i, sum = 0;

            while(temp > 0)
            {
                int d = temp % 10;
                sum += d * d * d;
                temp /= 10;
            }

            if(sum == i)
                Console.Write(i + " ");
        }
    }
}
```

---

Program260_PatternNumberTriangle.cs

```csharp id="v1k9sd"
using System;

class Program260_PatternNumberTriangle
{
    static void Main()
    {
        int n = 5;

        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
```

---
