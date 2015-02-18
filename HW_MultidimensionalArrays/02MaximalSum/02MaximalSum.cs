/* Problem 2. Maximal sum
Write a program that reads a rectangular matrix of size N x M 
and finds in it the square 3 x 3 that has maximal sum of its elements.
 */

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter number for matrix rows (> 3): ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number for matrix cols (> 3): ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        int bestSum, bestRow, bestCol;
        FillMatrix(matrix, rows, cols);
        PrintMatrix(matrix, rows, cols);
        FindMaxSum(out bestSum, matrix, out bestRow, out bestCol);
        PrintResult(matrix, bestRow, bestCol, bestSum);
    }

    private static void FillMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
			{
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Enter integer [{0}] for row [{1}]: ", j, i);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
			}
        Console.Clear();
    }

    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
        Console.WriteLine("Here is your matrix: ");
        for (rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0,4} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void FindMaxSum(out int bestSum, int[,] matrix, out int bestRow, out int bestCol)
    {
        bestSum = int.MinValue;
        bestRow = 0;
        bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
    }

    private static void PrintResult(int[,] matrix, int bestRow, int bestCol, int bestSum)
    {
        Console.WriteLine("Here is the 3x3 square with max sum: ");
        Console.WriteLine("{0,4}{1,4}{2,4}",
            matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0,4}{1,4}{2,4}",
            matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow +1, bestCol + 2]);
        Console.WriteLine("{0,4}{1,4}{2,4}",
            matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]); 
        Console.WriteLine("And the sum is {0,4}", bestSum);
    }
}
