using System;

class Program84_ColumnWiseSumOf2DArray
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3}, {4, 5, 6} };

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int colSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                colSum += matrix[i, j];
            }
            Console.WriteLine("Sum of column " + j + " = " + colSum);
        }
    }
}
