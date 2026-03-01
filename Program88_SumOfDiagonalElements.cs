using System;

class Program88_SumOfDiagonalElements
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        int sum = 0;

        // Sum of main diagonal
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine("Sum of Diagonal Elements = " + sum);
    }
}
