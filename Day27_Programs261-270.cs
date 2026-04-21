Day27_Programs261-270

---

Program261_ReverseArrayInPlace.cs

```csharp id="v7m9qp"
using System;

class Program261_ReverseArrayInPlace
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};

        int left = 0, right = arr.Length - 1;

        while(left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }

        foreach(int num in arr)
            Console.Write(num + " ");
    }
}
```

---

Program262_SecondLargestElement.cs

```csharp id="q2k8lw"
using System;

class Program262_SecondLargestElement
{
    static void Main()
    {
        int[] arr = {10, 20, 5, 8, 25};

        int first = int.MinValue;
        int second = int.MinValue;

        foreach(int num in arr)
        {
            if(num > first)
            {
                second = first;
                first = num;
            }
            else if(num > second && num != first)
            {
                second = num;
            }
        }

        Console.WriteLine("Second Largest = " + second);
    }
}
```

---

Program263_MoveNegativesToLeft.cs

```csharp id="n3x9rt"
using System;

class Program263_MoveNegativesToLeft
{
    static void Main()
    {
        int[] arr = {1,-2,3,-4,5,-6};

        int index = 0;

        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i] < 0)
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

Program264_FindMissingNumber.cs

```csharp id="8m1v6y"
using System;

class Program264_FindMissingNumber
{
    static void Main()
    {
        int[] arr = {1,2,3,5,6};
        int n = 6;

        int sum = n * (n + 1) / 2;
        int actual = 0;

        foreach(int num in arr)
            actual += num;

        Console.WriteLine("Missing Number = " + (sum - actual));
    }
}
```

---

Program265_CheckPalindromeArray.cs

```csharp id="c8q4ld"
using System;

class Program265_CheckPalindromeArray
{
    static void Main()
    {
        int[] arr = {1,2,3,2,1};

        bool isPalindrome = true;

        for(int i=0;i<arr.Length/2;i++)
        {
            if(arr[i] != arr[arr.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        Console.WriteLine(isPalindrome ? "Palindrome Array" : "Not Palindrome");
    }
}
```

---

Program266_FindCommonElements3Arrays.cs

```csharp id="p1z6xw"
using System;
using System.Linq;

class Program266_FindCommonElements3Arrays
{
    static void Main()
    {
        int[] a = {1,2,3,4};
        int[] b = {2,3,5};
        int[] c = {2,3,6};

        var result = a.Intersect(b).Intersect(c);

        foreach(int num in result)
            Console.Write(num + " ");
    }
}
```

---

Program267_FrequencyOfArrayElements.cs

```csharp id="t6n8ck"
using System;
using System.Collections.Generic;

class Program267_FrequencyOfArrayElements
{
    static void Main()
    {
        int[] arr = {1,2,2,3,3,3};

        Dictionary<int,int> map = new Dictionary<int,int>();

        foreach(int num in arr)
        {
            if(map.ContainsKey(num))
                map[num]++;
            else
                map[num] = 1;
        }

        foreach(var item in map)
            Console.WriteLine(item.Key + " = " + item.Value);
    }
}
```

---

Program268_SumOfDigits.cs

```csharp id="x4r9pf"
using System;

class Program268_SumOfDigits
{
    static void Main()
    {
        int n = 12345;
        int sum = 0;

        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}
```

---

Program269_ArmstrongNumber.cs

```csharp id="h2d8jw"
using System;

class Program269_ArmstrongNumber
{
    static void Main()
    {
        int n = 153;
        int temp = n, sum = 0;

        while(temp > 0)
        {
            int digit = temp % 10;
            sum += digit * digit * digit;
            temp /= 10;
        }

        Console.WriteLine(sum == n ? "Armstrong" : "Not Armstrong");
    }
}
```

---

Program270_PowerOfNumber.cs

```csharp id="k9v3qs"
using System;

class Program270_PowerOfNumber
{
    static void Main()
    {
        int baseNum = 2;
        int exp = 5;
        int result = 1;

        for(int i=1;i<=exp;i++)
            result *= baseNum;

        Console.WriteLine("Power = " + result);
    }
}
```

---
