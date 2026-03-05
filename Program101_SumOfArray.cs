using System;

class Program
{
    static void Main()
    {
        int[] arr = {10, 20, 30, 40, 50};
        int sum = 0;

        foreach (int num in arr)
        {
            sum += num;
        }

        Console.WriteLine("Sum of array elements = " + sum);
    }
}
