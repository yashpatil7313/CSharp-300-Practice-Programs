using System;

class Program100_DisplayMatrixInSpiralForm
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3},
                          {4, 5, 6},
                          {7, 8, 9} };

        int top = 0;
        int bottom = matrix.GetLength(0) - 1;
        int left = 0;
        int right = matrix.GetLength(1) - 1;

        Console.WriteLine("Spiral Order:");

        while (top <= bottom && left <= right)
        {
            // Left to Right
            for (int i = left; i <= right; i++)
                Console.Write(matrix[top, i] + " ");
            top++;

            // Top to Bottom
            for (int i = top; i <= bottom; i++)
                Console.Write(matrix[i, right] + " ");
            right--;

            // Right to Left
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    Console.Write(matrix[bottom, i] + " ");
                bottom--;
            }

            // Bottom to Top
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    Console.Write(matrix[i, left] + " ");
                left++;
            }
        }
    }
}
