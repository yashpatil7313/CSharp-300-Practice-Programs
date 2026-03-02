using System;

class Program91_CheckSymmetricMatrix
{
    static void Main()
    {
        int[,] matrix = { {1, 2, 3},
                          {2, 4, 5},
                          {3, 5, 6} };

        bool isSymmetric = true;
        int size = matrix.GetLength(0);

        // Check if matrix[i,j] == matrix[j,i]
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (matrix[i, j] != matrix[j, i])
                {
                    isSymmetric = false;
                    break;
                }
            }
        }

        if (isSymmetric)
            Console.WriteLine("Symmetric Matrix");
        else
            Console.WriteLine("Not a Symmetric Matrix");
    }
}
