using System;

class Program81_Print2DArray
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

        Console.WriteLine("2D Array Elements:");

        for (int i = 0; i < matrix.GetLength(0); i++) // Rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
