using System;

class Program93_FindSmallestElementIn2DArray
{
    static void Main()
    {
        int[,] matrix = { {3, 8, 1},
                          {4, 6, 9},
                          {2, 7, 5} };

        int smallest = matrix[0, 0];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < smallest)
                    smallest = matrix[i, j];
            }
        }

        Console.WriteLine("Smallest Element = " + smallest);
    }
}
