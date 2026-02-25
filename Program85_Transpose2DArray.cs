using System;

class Program85_Transpose2DArray
{
    static void Main()
    {
        int[,] matrix = { {1, 2}, {3, 4}, {5, 6} };
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transpose = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        Console.WriteLine("Transpose of the matrix:");
        for (int i = 0; i < transpose.GetLength(0); i++)
        {
            for (int j = 0; j < transpose.GetLength(1); j++)
            {
                Console.Write(transpose[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
