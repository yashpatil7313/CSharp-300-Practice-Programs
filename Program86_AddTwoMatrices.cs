using System;

class Program86_AddTwoMatrices
{
    static void Main()
    {
        int[,] matrix1 = { {1, 2}, {3, 4} };
        int[,] matrix2 = { {5, 6}, {7, 8} };
        int[,] sum = new int[2, 2];

        // Adding two matrices
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Sum of Matrices:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
