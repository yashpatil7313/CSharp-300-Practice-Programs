Program201_BinarySearch.cs

```csharp id=z8bnrx
using System;

class Program201_BinarySearch
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5,6,7,8,9};
        int target = 5;

        int left = 0, right = arr.Length - 1;

        while(left = right)
        {
            int mid = (left + right)  2;

            if(arr[mid] == target)
            {
                Console.WriteLine(Found at index  + mid);
                return;
            }
            else if(arr[mid]  target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        Console.WriteLine(Not Found);
    }
}
```

---

Program202_LinearSearch.cs

```csharp id=jv95eo
using System;

class Program202_LinearSearch
{
    static void Main()
    {
        int[] arr = {10,20,30,40};
        int target = 30;

        for(int i=0;iarr.Length;i++)
        {
            if(arr[i] == target)
            {
                Console.WriteLine(Found at index  + i);
                return;
            }
        }

        Console.WriteLine(Not Found);
    }
}
```

---

Program203_BubbleSort.cs

```csharp id=v0v14l
using System;

class Program203_BubbleSort
{
    static void Main()
    {
        int[] arr = {5,3,8,4,2};

        for(int i=0;iarr.Length;i++)
        {
            for(int j=0;jarr.Length-1-i;j++)
            {
                if(arr[j]  arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }

        foreach(int num in arr)
            Console.Write(num +  );
    }
}
```

---

Program204_SelectionSort.cs

```csharp id=w65f70
using System;

class Program204_SelectionSort
{
    static void Main()
    {
        int[] arr = {64,25,12,22,11};

        for(int i=0;iarr.Length-1;i++)
        {
            int minIndex = i;

            for(int j=i+1;jarr.Length;j++)
            {
                if(arr[j]  arr[minIndex])
                    minIndex = j;
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }

        foreach(int num in arr)
            Console.Write(num +  );
    }
}
```

---

Program205_InsertionSort.cs

```csharp id=ikd1b3
using System;

class Program205_InsertionSort
{
    static void Main()
    {
        int[] arr = {12,11,13,5,6};

        for(int i=1;iarr.Length;i++)
        {
            int key = arr[i];
            int j = i - 1;

            while(j = 0 && arr[j]  key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }

        foreach(int num in arr)
            Console.Write(num +  );
    }
}
```

---

Program206_StackExample.cs

```csharp id=vsk0fc
using System;
using System.Collections.Generic;

class Program206_StackExample
{
    static void Main()
    {
        Stackint stack = new Stackint();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine(Top  + stack.Peek());

        while(stack.Count  0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
```

---

Program207_QueueExample.cs

```csharp id=4rkx3r
using System;
using System.Collections.Generic;

class Program207_QueueExample
{
    static void Main()
    {
        Queueint queue = new Queueint();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        while(queue.Count  0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
```

---

Program208_DictionaryExample.cs

```csharp id=b4nq51
using System;
using System.Collections.Generic;

class Program208_DictionaryExample
{
    static void Main()
    {
        Dictionaryint, string dict = new Dictionaryint, string();

        dict.Add(1, Aarti);
        dict.Add(2, Yash);

        foreach(var item in dict)
        {
            Console.WriteLine(item.Key +    + item.Value);
        }
    }
}
```

---

Program209_CheckBalancedParentheses.cs

```csharp id=a2l9ti
using System;
using System.Collections.Generic;

class Program209_CheckBalancedParentheses
{
    static void Main()
    {
        string str = (());
        Stackchar stack = new Stackchar();

        foreach(char ch in str)
        {
            if(ch == '(')
                stack.Push(ch);
            else if(ch == ')')
            {
                if(stack.Count == 0)
                {
                    Console.WriteLine(Not Balanced);
                    return;
                }
                stack.Pop();
            }
        }

        Console.WriteLine(stack.Count == 0  Balanced  Not Balanced);
    }
}
```

---

Program210_SimpleClassObject.cs

```csharp id=shw3tr
using System;

class Student
{
    public string Name;
    public int Age;

    public void Display()
    {
        Console.WriteLine(Name +   + Age);
    }
}

class Program210_SimpleClassObject
{
    static void Main()
    {
        Student s = new Student();
        s.Name = Aarti;
        s.Age = 20;

        s.Display();
    }
}
```

---
