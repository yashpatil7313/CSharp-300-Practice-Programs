using System;

class Program95_LowerTriangleMatrixElements
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3},
                          {4, 5, 6},
                          {7, 8, 9} };

        Console.WriteLine("Lower Triangle Elements:");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i >= j)
                    Console.Write(matrix[i, j] + " ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }
}
