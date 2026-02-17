using System;

class Program67_SearchElementInArray
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20, 25 };
        int search = 15;
        bool found = false;

        // Loop to search element
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == search)
            {
                found = true;
                break;
            }
        }

        // Display result
        if (found)
            Console.WriteLine("Element Found");
        else
            Console.WriteLine("Element Not Found");
    }
}
