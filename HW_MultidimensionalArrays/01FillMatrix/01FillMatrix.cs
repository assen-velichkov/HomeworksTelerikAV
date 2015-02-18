/* Problem 1. Fill the matrix
Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:
a)					b)					c)					d)*
1	5	9	13		1	8	9	16		7	11	14	16		1	12	11	10
2	6	10	14		2	7	10	15		4	8	12	15		2	13	16	9
3	7	11	15		3	6	11	14		2	5	9	13		3	14	15	8
4	8	12	16		4	5	12	13		1	3	6	10		4	5	6	7
 */

using System;

class FillMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter one number for matrix height and width: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a, b, c or d for matrix type: ");
        char type = char.Parse(Console.ReadLine());
        int [,] matrix = new int[n, n];
        switch (type)
        {
            case 'a': VerticalMatrixTypeA(matrix); break;
            case 'b': InvertedMatrixTypeB(matrix); break;
            case 'c': DiagonalMatrixTypeC(matrix); break;
            case 'd': SpiralMatrixTypeD(matrix); break;
        }
        PrintMatrix(matrix);
    }

    private static void VerticalMatrixTypeA (int[,] matrix)
    {
        int counter = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
			{
			    matrix[row, col] = counter;
                counter++;
			}
        }
    }

    private static void InvertedMatrixTypeB (int[,] matrix)
    {
        int counter = 1;
        int row = 0;
        int col = 0;
        for (col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (row = 0; row < matrix.GetLength(0); row++)
		        {
			        matrix[row, col] = counter;
                    counter++;
		        }
            }
            else
            {
                counter += matrix.GetLength(0) - 1;
                for (row = 0; row < matrix.GetLength(0); row++)
		        {
                    matrix[row, col] = counter;
                    counter--;
		        }
                counter += matrix.GetLength(0) + 1;
            }
        }
    }

    private static void DiagonalMatrixTypeC(int[,] matrix)
    {
        int counter = 1;
        int currentRow;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            currentRow = row;
            for (int col = 0; col < matrix.GetLength(1) - row; col++)
                {
                    matrix[currentRow, col] = counter;
                    currentRow++;
                    counter++;
                }
        }
        counter = matrix.GetLength(0) * matrix.GetLength(1);
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            currentRow = row;
            for (int col = matrix.GetLength(1) - 1; currentRow >= 0; col--)
            {
                matrix[currentRow, col] = counter;
                currentRow--;
                counter--;
            }
        }
    }

    private static void SpiralMatrixTypeD(int[,] matrix)
    {
        int[] rowArr = new int[] { 1, 0, -1, 0 };
        int[] colArr = new int[] { 0, 1, 0, -1 };
        int direction = 0;
        int counter = 1;
        int row = 0;
        int col = 0;
        int nextRow;
        int nextCol;

        while (counter <= matrix.GetLength(0) * matrix.GetLength(1))
        {
            matrix[row, col] = counter++;
            nextRow = row + rowArr[direction];
            nextCol = col + colArr[direction];

            if ((nextRow < 0 || nextRow >= matrix.GetLength(0)) ||
                (nextCol < 0 || nextCol >= matrix.GetLength(1)) ||
                matrix[nextRow, nextCol] != 0)
            {
                direction = (direction + 1) % 4;
            }

            row += rowArr[direction];
            col += colArr[direction];
        }
    }

    private static void PrintMatrix (int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
    }
}
