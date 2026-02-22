using System;

class Program80_InsertElementInArray
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40 };
        int newElement = 25;
        int position = 2; // Insert at index 2

        int[] newArray = new int[numbers.Length + 1];

        for (int i = 0; i < newArray.Length; i++)
        {
            if (i < position)
                newArray[i] = numbers[i];
            else if (i == position)
                newArray[i] = newElement;
            else
                newArray[i] = numbers[i - 1];
        }

        Console.WriteLine("Array after insertion:");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write(newArray[i] + " ");
        }
    }
}
