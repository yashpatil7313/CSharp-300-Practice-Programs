using System;

class Program96_SumOfUpperTriangle
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3},
                          {4, 5, 6},
                          {7, 8, 9} };

        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }

        Console.WriteLine("Sum of Upper Triangle = " + sum);
    }
}
