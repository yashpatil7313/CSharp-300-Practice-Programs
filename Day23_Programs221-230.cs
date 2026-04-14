Day23_Programs221-230

---

Program221_FindSecondSmallest.cs

```csharp
using System;

class Program221_FindSecondSmallest
{
    static void Main()
    {
        int[] arr = {10, 5, 8, 3, 15};

        int first = int.MaxValue;
        int second = int.MaxValue;

        foreach(int num in arr)
        {
            if(num < first)
            {
                second = first;
                first = num;
            }
            else if(num < second && num != first)
            {
                second = num;
            }
        }

        Console.WriteLine("Second Smallest = " + second);
    }
}
```

---

Program222_MergeSortedArrays.cs

```csharp
using System;

class Program222_MergeSortedArrays
{
    static void Main()
    {
        int[] a = {1,3,5};
        int[] b = {2,4,6};

        int[] result = new int[a.Length + b.Length];

        int i=0, j=0, k=0;

        while(i < a.Length && j < b.Length)
        {
            if(a[i] < b[j])
                result[k++] = a[i++];
            else
                result[k++] = b[j++];
        }

        while(i < a.Length)
            result[k++] = a[i++];

        while(j < b.Length)
            result[k++] = b[j++];

        foreach(int num in result)
            Console.Write(num + " ");
    }
}
```

---

Program223_CheckArraySorted.cs

```csharp
using System;

class Program223_CheckArraySorted
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};

        bool sorted = true;

        for(int i=0;i<arr.Length-1;i++)
        {
            if(arr[i] > arr[i+1])
            {
                sorted = false;
                break;
            }
        }

        Console.WriteLine(sorted ? "Sorted" : "Not Sorted");
    }
}
```

---

Program224_FindPairWithSum.cs

```csharp
using System;
using System.Collections.Generic;

class Program224_FindPairWithSum
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};
        int target = 6;

        HashSet<int> set = new HashSet<int>();

        foreach(int num in arr)
        {
            if(set.Contains(target - num))
            {
                Console.WriteLine("Pair Found: " + num + " " + (target - num));
                return;
            }
            set.Add(num);
        }

        Console.WriteLine("No Pair Found");
    }
}
```

---

Program225_RemoveDuplicatesArray.cs

```csharp
using System;
using System.Linq;

class Program225_RemoveDuplicatesArray
{
    static void Main()
    {
        int[] arr = {1,2,2,3,4,4};

        var result = arr.Distinct();

        foreach(var num in result)
            Console.Write(num + " ");
    }
}
```

---

Program226_FindIntersectionArrays.cs

```csharp
using System;
using System.Linq;

class Program226_FindIntersectionArrays
{
    static void Main()
    {
        int[] a = {1,2,3,4};
        int[] b = {3,4,5,6};

        var result = a.Intersect(b);

        foreach(var num in result)
            Console.Write(num + " ");
    }
}
```

---

Program227_FindUnionArrays.cs

```csharp
using System;
using System.Linq;

class Program227_FindUnionArrays
{
    static void Main()
    {
        int[] a = {1,2,3};
        int[] b = {3,4,5};

        var result = a.Union(b);

        foreach(var num in result)
            Console.Write(num + " ");
    }
}
```

---

Program228_RotateArrayKTimes.cs

```csharp
using System;

class Program228_RotateArrayKTimes
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};
        int k = 2;

        for(int r=0; r<k; r++)
        {
            int last = arr[arr.Length-1];

            for(int i=arr.Length-1;i>0;i--)
                arr[i] = arr[i-1];

            arr[0] = last;
        }

        foreach(int num in arr)
            Console.Write(num + " ");
    }
}
```

---

Program229_FindMajorityElement.cs

```csharp
using System;
using System.Linq;

class Program229_FindMajorityElement
{
    static void Main()
    {
        int[] arr = {1,2,3,2,2,2,5};

        var result = arr.GroupBy(x => x)
                        .OrderByDescending(g => g.Count())
                        .First();

        Console.WriteLine("Majority Element = " + result.Key);
    }
}
```

---

Program230_SubArraySum.cs

```csharp
using System;

class Program230_SubArraySum
{
    static void Main()
    {
        int[] arr = {1,2,3,7,5};
        int target = 12;

        for(int i=0;i<arr.Length;i++)
        {
            int sum = 0;

            for(int j=i;j<arr.Length;j++)
            {
                sum += arr[j];

                if(sum == target)
                {
                    Console.WriteLine("Subarray found from index " + i + " to " + j);
                    return;
                }
            }
        }

        Console.WriteLine("No Subarray Found");
    }
}
```

---
