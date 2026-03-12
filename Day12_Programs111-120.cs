Program111_CopyArray.cs
using System;

class Program111_CopyArray
{
    static void Main()
    {
        int[] arr1 = {1,2,3,4,5};
        int[] arr2 = new int[arr1.Length];

        for(int i=0;i<arr1.Length;i++)
        {
            arr2[i] = arr1[i];
        }

        Console.WriteLine("Copied Array:");
        foreach(int num in arr2)
        {
            Console.Write(num + " ");
        }
    }
}


Program113_FindDuplicateElements.cs
using System;

class Program113_FindDuplicateElements
{
    static void Main()
    {
        int[] arr = {1,2,3,2,4,1};

        Console.WriteLine("Duplicate Elements:");

        for(int i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i] == arr[j])
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
        }
    }
}


}


Program114_RemoveDuplicateElements.cs
using System;
using System.Linq;

class Program114_RemoveDuplicateElements
{
    static void Main()
    {
        int[] arr = {1,2,3,2,4,1};

        int[] unique = arr.Distinct().ToArray();

        Console.WriteLine("Array without duplicates:");

        foreach(int num in unique)
            Console.Write(num + " ");
    }
}


Program115_CountFrequencyOfElement.cs
using System;

class Program115_CountFrequencyOfElement
{
    static void Main()
    {
        int[] arr = {1,2,2,3,3,3,4};

        Console.Write("Enter element to count: ");
        int element = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        foreach(int num in arr)
        {
            if(num == element)
                count++;
        }

        Console.WriteLine("Frequency: " + count);
    }
}


Program116_LeftRotateArray.cs
using System;

class Program116_LeftRotateArray
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};

        int first = arr[0];

        for(int i=0;i<arr.Length-1;i++)
        {
            arr[i] = arr[i+1];
        }

        arr[arr.Length-1] = first;

        Console.WriteLine("Left Rotated Array:");

        foreach(int num in arr)
            Console.Write(num + " ");
    }
}


Program117_RightRotateArray.cs
using System;

class Program117_RightRotateArray
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};

        int last = arr[arr.Length-1];

        for(int i=arr.Length-1;i>0;i--)
        {
            arr[i] = arr[i-1];
        }

        arr[0] = last;

        Console.WriteLine("Right Rotated Array:");

        foreach(int num in arr)
            Console.Write(num + " ");
    }
}

Program118_FindMissingNumber.cs
using System;

class Program118_FindMissingNumber
{
    static void Main()
    {
        int[] arr = {1,2,3,5};

        int n = arr.Length + 1;

        int expectedSum = n*(n+1)/2;
        int actualSum = 0;

        foreach(int num in arr)
            actualSum += num;

        Console.WriteLine("Missing Number: " + (expectedSum - actualSum));
    }
}


Program119_SumOfEvenNumbersArray.cs
using System;

class Program119_SumOfEvenNumbersArray
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5,6};

        int sum = 0;

        foreach(int num in arr)
        {
            if(num % 2 == 0)
                sum += num;
        }

        Console.WriteLine("Sum of Even Numbers: " + sum);
    }
}


Program120_SumOfOddNumbersArray.cs
using System;

class Program120_SumOfOddNumbersArray
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5,6};

        int sum = 0;

        foreach(int num in arr)
        {
            if(num % 2 != 0)
                sum += num;
        }

        Console.WriteLine("Sum of Odd Numbers: " + sum);
    }
}
