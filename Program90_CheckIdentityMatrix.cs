using System;

class Program90_CheckIdentityMatrix
{
    static void Main()
    {
        int[,] matrix = { {1, 0, 0}, {0, 1, 0}, {0, 0, 1} };
        bool isIdentity = true;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if ((i == j && matrix[i, j] != 1) ||
                    (i != j && matrix[i, j] != 0))
                {
                    isIdentity = false;
                    break;
                }
            }
        }

        if (isIdentity)
            Console.WriteLine("Identity Matrix");
        else
            Console.WriteLine("Not an Identity Matrix");
    }
}
