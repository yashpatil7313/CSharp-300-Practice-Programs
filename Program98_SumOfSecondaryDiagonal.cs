using System;

class Program98_SumOfSecondaryDiagonal
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3},
                          {4, 5, 6},
                          {7, 8, 9} };

        int size = matrix.GetLength(0);
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, size - i - 1];
        }

        Console.WriteLine("Sum of Secondary Diagonal = " + sum);
    }
}
