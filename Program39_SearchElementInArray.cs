using System;

class Program
{
    static void Main()
    {
        // Declare array
        int[] arr = { 10, 20, 30, 40 };

        // Element to search
        int key = 30;

        // Flag variable
        bool found = false;

        // Search element
        foreach (int i in arr)
        {
            if (i == key)
            {
                found = true;
                break;
            }
        }

        // Print result
        Console.WriteLine(found ? "Element Found" : "Element Not Found");
    }
}
