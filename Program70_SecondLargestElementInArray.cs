using System;

class Program70_SecondLargestElementInArray
{
    static void Main()
    {
        int[] numbers = { 12, 45, 7, 89, 23 };

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        // Find largest and second largest
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                secondLargest = largest;
                largest = numbers[i];
            }
            else if (numbers[i] > secondLargest && numbers[i] != largest)
            {
                secondLargest = numbers[i];
            }
        }

        Console.WriteLine("Second Largest Element = " + secondLargest);
    }
}
