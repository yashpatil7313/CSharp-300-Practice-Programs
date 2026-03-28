Program131_MethodAddition.cs
using System;

class Program131_MethodAddition
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int result = Add(10, 20);
        Console.WriteLine("Sum = " + result);
    }
}


Program132_MethodFactorial.cs
using System;

class Program132_MethodFactorial
{
    static int Factorial(int n)
    {
        int fact = 1;
        for(int i=1; i<=n; i++)
            fact *= i;

        return fact;
    }

    static void Main()
    {
        Console.WriteLine("Factorial = " + Factorial(5));
    }
}


Program133_MethodPrimeCheck.cs
using System;

class Program133_MethodPrimeCheck
{
    static bool IsPrime(int num)
    {
        if(num <= 1) return false;

        for(int i=2; i<=num/2; i++)
        {
            if(num % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        int num = 7;

        if(IsPrime(num))
            Console.WriteLine("Prime");
        else
            Console.WriteLine("Not Prime");
    }
}


Program134_MethodFibonacci.cs
using System;

class Program134_MethodFibonacci
{
    static void Fibonacci(int n)
    {
        int a = 0, b = 1;

        for(int i=0; i<n; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }

    static void Main()
    {
        Fibonacci(10);
    }
}


Program135_MethodSwapNumbers.cs
using System;

class Program135_MethodSwapNumbers
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int x = 5, y = 10;

        Swap(ref x, ref y);

        Console.WriteLine("x = " + x + ", y = " + y);
    }
}


Program136_MethodAreaCircle.cs
using System;

class Program136_MethodAreaCircle
{
    static double Area(double r)
    {
        return Math.PI * r * r;
    }

    static void Main()
    {
        Console.WriteLine("Area = " + Area(5));
    }
}


Program137_MethodPowerNumber.cs
using System;

class Program137_MethodPowerNumber
{
    static int Power(int num, int pow)
    {
        int result = 1;

        for(int i=1; i<=pow; i++)
            result *= num;

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Power = " + Power(2, 3));
    }
}


Program138_MethodSumArray.cs
using System;

class Program138_MethodSumArray
{
    static int Sum(int[] arr)
    {
        int sum = 0;

        foreach(int num in arr)
            sum += num;

        return sum;
    }

    static void Main()
    {
        int[] arr = {1,2,3,4};
        Console.WriteLine("Sum = " + Sum(arr));
    }
}


Program139_MethodAverageArray.cs
using System;

class Program139_MethodAverageArray
{
    static double Average(int[] arr)
    {
        int sum = 0;

        foreach(int num in arr)
            sum += num;

        return (double)sum / arr.Length;
    }

    static void Main()
    {
        int[] arr = {10,20,30};
        Console.WriteLine("Average = " + Average(arr));
    }
}


Program140_MethodMaxNumber.cs
using System;

class Program140_MethodMaxNumber
{
    static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static void Main()
    {
        Console.WriteLine("Max = " + Max(10, 20));
    }
}
