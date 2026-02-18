using System;

class Program68_CountEvenAndOddInArray
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        int evenCount = 0;
        int oddCount = 0;

        // Loop through array
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine("Even Count = " + evenCount);
        Console.WriteLine("Odd Count = " + oddCount);
    }
}
