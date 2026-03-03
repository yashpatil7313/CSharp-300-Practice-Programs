using System;

class Program99_CountTotalElementsIn2DArray
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3},
                          {4, 5, 6} };

        int totalElements = matrix.GetLength(0) * matrix.GetLength(1);

        Console.WriteLine("Total Elements = " + totalElements);
    }
}
