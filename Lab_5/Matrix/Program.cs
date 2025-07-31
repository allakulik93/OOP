using System;

class MatrixMultiply
{
    public static void Main()
    {
        int[,] a = new int[2, 2];
        int[,] b = new int[2, 2];
        Console.WriteLine("Enter 4 numbers from the first array");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter 4 numbers from the second array");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                b[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int[,] result = new int[2, 2];
        result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
        result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
        result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
        result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];

        Console.WriteLine("The result of matrix multiplication");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

