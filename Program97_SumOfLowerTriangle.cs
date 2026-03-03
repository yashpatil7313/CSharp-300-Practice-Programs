using System;

class Program97_SumOfLowerTriangle
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3},
                          {4, 5, 6},
                          {7, 8, 9} };

        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= i; j++)
            {
                sum += matrix[i, j];
            }
        }

        Console.WriteLine("Sum of Lower Triangle = " + sum);
    }
}
