/* Problem 3. Sequence n matrix
We are given a matrix of strings of size N x M. 
Sequences in the matrix we define as sets of several 
neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:
matrix:                 result:
ha	fifi ho	hi      ha, ha, ha
fo	  ha hi	xx
xxx	  ha ha	xx

matrix:             result:
s	qq	s           s, s, s
pp	pp	s
pp	qq	s
*/

using System;
using System.Linq;

class SequenceNMatrix
{
    static string[,] matrix;
    static string bestSequence = String.Empty;
    static void Main()
    {
        GetMatrix();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                CheckSequence(matrix, row, col);
            }
        }
        Console.WriteLine(bestSequence);
    }

    private static void GetMatrix()
    {
        Console.Write("Enter number for matrix rows: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter number for matrix cols: ");
        int col = int.Parse(Console.ReadLine());
        string[,] matrix = new string[row, col]; 
        
        for (row = 0; row < matrix.GetLength(0); row++)
        {
            for (col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter string [{0}] for row [{1}]: ", col, row);
                matrix[row, col] = Console.ReadLine();
            }
        }
        Console.Clear();
        PrintMatrix();
    }

    private static void PrintMatrix()
    {
        Console.WriteLine("Here is your matrix: ");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static int CheckHorizontal(string[,] matrix, int row, int col)
    {
        string sequence = matrix[row, col];
        int counter = 0;
        for (int i = col; i < matrix.GetLength(1); i++)
        {
            if (matrix[row, i] == sequence)
            {
                counter++;
            }
        }
        return counter;
    }

    private static int CheckVertical(string[,] matrix, int row, int col)
    {
        string sequence = matrix[row, col];
        int counter = 0;
        for (int i = row; i < matrix.GetLength(0); row++)
        {
            if (matrix[i, col] == sequence)
            {
                counter++;
            }
        }
        return counter;
    }

    private static int CheckDiagonal(string[,] matrix, int row, int col)
    {
        string sequence = matrix[row, col];
        int counter = 0;
        for (int i = row, j = col; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
        {
            if (matrix[i, j] == sequence)
            {
                counter++;
            }
        }
        return counter;
    }

    private static void CheckSequence(string[,] matrix, int row, int col)
    {
        
        int horizontal = CheckHorizontal(matrix, row, col);
        int vertical = CheckVertical(matrix, row, col);
        int diagonal = CheckDiagonal(matrix, row, col);

        if (horizontal - vertical > 0 && horizontal - diagonal > 0)
        {
            bestSequence = string.Join(", ", 
                    Enumerable
                    .Repeat(matrix[row, col], horizontal)
                    .ToArray());
        }
        else if (vertical - horizontal > 0 && vertical - diagonal > 0)
        {
            bestSequence = string.Join(", ", 
                    Enumerable
                    .Repeat(matrix[row, col], vertical)
                    .ToArray());
        }
        else
        {
            bestSequence = string.Join(", ", 
                    Enumerable
                    .Repeat(matrix[row, col], diagonal)
                    .ToArray());
        }
    }
}
