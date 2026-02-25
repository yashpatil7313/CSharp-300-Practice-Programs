using System;

class Program82_SumOf2DArrayElements
{
    static void Main()
    {
        int[,] matrix = { {1, 2}, {3, 4} };
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }

        Console.WriteLine("Sum of 2D Array Elements = " + sum);
    }
}
