Program102_MaxElementArray.cs
using System;

class Program
{
    static void Main()
    {
        int[] arr = {10, 50, 30, 90, 20};

        int max = arr[0];

        foreach(int num in arr)
        {
            if(num > max)
            {
                max = num;
            }
        }

        Console.WriteLine("Maximum element: " + max);
    }
}


Program103_MinElementArray.cs
using System;

class Program
{
    static void Main()
    {
        int[] arr = {10, 50, 30, 5, 20};

        int min = arr[0];

        foreach(int num in arr)
        {
            if(num < min)
            {
                min = num;
            }
        }

        Console.WriteLine("Minimum element: " + min);
    }
}


Program104_ReverseArray.cs
using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};

        Console.WriteLine("Reversed Array:");

        for(int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}


Program105_CountEvenOdd.cs
using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5,6,7,8};

        int even = 0;
        int odd = 0;

        foreach(int num in arr)
        {
            if(num % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even numbers: " + even);
        Console.WriteLine("Odd numbers: " + odd);
    }
}


Program106_SecondLargest.cs
using System;

class Program
{
    static void Main()
    {
        int[] arr = {10, 20, 50, 40, 30};

        int largest = int.MinValue;
        int second = int.MinValue;

        foreach(int num in arr)
        {
            if(num > largest)
            {
                second = largest;
                largest = num;
            }
            else if(num > second && num != largest)
            {
                second = num;
            }
        }

        Console.WriteLine("Second largest number: " + second);
    }
}


Program107_LinearSearch.cs
using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};

        Console.Write("Enter number to search: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach(int n in arr)
        {
            if(n == num)
            {
                found = true;
                break;
            }
        }

        if(found)
            Console.WriteLine("Element Found");
        else
            Console.WriteLine("Element Not Found");
    }
}


Program108_BinarySearch.cs
using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};

        Console.Write("Enter number to search: ");
        int key = Convert.ToInt32(Console.ReadLine());

        int left = 0;
        int right = arr.Length - 1;

        while(left <= right)
        {
            int mid = (left + right) / 2;

            if(arr[mid] == key)
            {
                Console.WriteLine("Element Found");
                return;
            }
            else if(arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }

        Console.WriteLine("Element Not Found");
    }
}


Program109_BubbleSort.cs
using System;

class Program
{
    static void Main()
    {
        int[] arr = {5,3,8,1,2};

        for(int i=0;i<arr.Length;i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array:");

        foreach(int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}


Program110_ArrayAverage.cs
using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};

        int sum = 0;

        foreach(int num in arr)
        {
            sum += num;
        }

        double avg = (double)sum / arr.Length;

        Console.WriteLine("Average: " + avg);
    }
}



