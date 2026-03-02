using System;

class Program92_FindLargestElementIn2DArray
{
    static void Main()
    {
        int[,] matrix = { {3, 8, 1},
                          {4, 6, 9},
                          {2, 7, 5} };

        int largest = matrix[0, 0];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > largest)
                    largest = matrix[i, j];
            }
        }

        Console.WriteLine("Largest Element = " + largest);
    }
}
