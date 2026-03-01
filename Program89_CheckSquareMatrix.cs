using System;

class Program89_CheckSquareMatrix
{
    static void Main()
    {
        int[,] matrix = { {1, 2}, {3, 4} };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Square matrix check
        if (rows == cols)
            Console.WriteLine("It is a Square Matrix");
        else
            Console.WriteLine("Not a Square Matrix");
    }
}
