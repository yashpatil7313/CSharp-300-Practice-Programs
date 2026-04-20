Day25_Programs241-250

---

Program241_LongestSubarrayWithSumK.cs

```csharp
using System;
using System.Collections.Generic;

class Program241_LongestSubarrayWithSumK
{
    static void Main()
    {
        int[] arr = {1,2,3,1,1,1,1};
        int k = 3;

        Dictionary<int,int> map = new Dictionary<int,int>();
        int sum = 0, maxLen = 0;

        for(int i=0;i<arr.Length;i++)
        {
            sum += arr[i];

            if(sum == k)
                maxLen = i + 1;

            if(map.ContainsKey(sum - k))
                maxLen = Math.Max(maxLen, i - map[sum - k]);

            if(!map.ContainsKey(sum))
                map[sum] = i;
        }

        Console.WriteLine("Max Length = " + maxLen);
    }
}
```

---

Program242_FirstNonRepeatingCharacter.cs

```csharp
using System;
using System.Collections.Generic;

class Program242_FirstNonRepeatingCharacter
{
    static void Main()
    {
        string str = "aabbcde";

        Dictionary<char,int> map = new Dictionary<char,int>();

        foreach(char c in str)
        {
            if(map.ContainsKey(c))
                map[c]++;
            else
                map[c] = 1;
        }

        foreach(char c in str)
        {
            if(map[c] == 1)
            {
                Console.WriteLine("First Non-Repeating = " + c);
                return;
            }
        }
    }
}
```

---

Program243_LongestCommonPrefix.cs

```csharp
using System;

class Program243_LongestCommonPrefix
{
    static void Main()
    {
        string[] arr = {"flower","flow","flight"};

        string prefix = arr[0];

        for(int i=1;i<arr.Length;i++)
        {
            while(!arr[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }

        Console.WriteLine("Prefix = " + prefix);
    }
}
```

---

Program244_ValidParentheses.cs

```csharp
using System;
using System.Collections.Generic;

class Program244_ValidParentheses
{
    static void Main()
    {
        string str = "{[()]}";
        Stack<char> stack = new Stack<char>();

        foreach(char c in str)
        {
            if(c=='('||c=='{'||c=='[')
                stack.Push(c);
            else
            {
                if(stack.Count==0)
                {
                    Console.WriteLine("Invalid");
                    return;
                }

                char top = stack.Pop();

                if((c==')' && top!='(') ||
                   (c=='}' && top!='{') ||
                   (c==']' && top!='['))
                {
                    Console.WriteLine("Invalid");
                    return;
                }
            }
        }

        Console.WriteLine(stack.Count==0 ? "Valid" : "Invalid");
    }
}
```

---

Program245_MergeIntervals.cs

```csharp
using System;
using System.Linq;

class Program245_MergeIntervals
{
    static void Main()
    {
        int[][] intervals = {
            new int[]{1,3},
            new int[]{2,6},
            new int[]{8,10}
        };

        var sorted = intervals.OrderBy(x => x[0]).ToArray();

        int start = sorted[0][0], end = sorted[0][1];

        foreach(var i in sorted)
        {
            if(i[0] <= end)
                end = Math.Max(end, i[1]);
            else
            {
                Console.WriteLine(start + "," + end);
                start = i[0];
                end = i[1];
            }
        }

        Console.WriteLine(start + "," + end);
    }
}
```

---

Program246_ProductExceptSelf.cs

```csharp
using System;

class Program246_ProductExceptSelf
{
    static void Main()
    {
        int[] arr = {1,2,3,4};
        int n = arr.Length;

        int[] result = new int[n];

        int left = 1;
        for(int i=0;i<n;i++)
        {
            result[i] = left;
            left *= arr[i];
        }

        int right = 1;
        for(int i=n-1;i>=0;i--)
        {
            result[i] *= right;
            right *= arr[i];
        }

        foreach(int num in result)
            Console.Write(num + " ");
    }
}
```

---

Program247_FindPeakElement.cs

```csharp
using System;

class Program247_FindPeakElement
{
    static void Main()
    {
        int[] arr = {1,2,3,1};

        for(int i=0;i<arr.Length;i++)
        {
            if((i==0 || arr[i]>arr[i-1]) &&
               (i==arr.Length-1 || arr[i]>arr[i+1]))
            {
                Console.WriteLine("Peak = " + arr[i]);
                return;
            }
        }
    }
}
```

---

Program248_SearchInRotatedArray.cs

```csharp
using System;

class Program248_SearchInRotatedArray
{
    static void Main()
    {
        int[] arr = {4,5,6,7,0,1,2};
        int target = 0;

        int left = 0, right = arr.Length-1;

        while(left <= right)
        {
            int mid = (left + right) / 2;

            if(arr[mid] == target)
            {
                Console.WriteLine("Found at " + mid);
                return;
            }

            if(arr[left] <= arr[mid])
            {
                if(target >= arr[left] && target < arr[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            else
            {
                if(target > arr[mid] && target <= arr[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        Console.WriteLine("Not Found");
    }
}
```

---

Program249_KthLargestElement.cs

```csharp
using System;
using System.Linq;

class Program249_KthLargestElement
{
    static void Main()
    {
        int[] arr = {3,2,1,5,6,4};
        int k = 2;

        var result = arr.OrderByDescending(x => x).ElementAt(k-1);

        Console.WriteLine("Kth Largest = " + result);
    }
}
```

---

Program250_MedianOfArray.cs

```csharp
using System;
using System.Linq;

class Program250_MedianOfArray
{
    static void Main()
    {
        int[] arr = {1,3,2,4};

        var sorted = arr.OrderBy(x => x).ToArray();

        double median;

        if(sorted.Length % 2 == 0)
        {
            median = (sorted[sorted.Length/2 - 1] + sorted[sorted.Length/2]) / 2.0;
        }
        else
        {
            median = sorted[sorted.Length/2];
        }

        Console.WriteLine("Median = " + median);
    }
}
```

---
