/* Problem 9. Matrix of Numbers
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
and prints a matrix like in the examples below. Use two nested loops.
Examples:

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
*/

using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number (1 <= n <= 20): ");
        int n = int.Parse(Console.ReadLine());
        int rows = 0;
        int nums = 0;

        while (n < 1 || n > 20)
        {
            Console.WriteLine("The number must be between 1 and 20, please try again: ");
            n = int.Parse(Console.ReadLine());
        }
        Console.Clear();

        for (rows = 1; rows <= n; rows++)
        {
            for (nums = rows; nums < rows + n; nums++)
            {
                Console.Write("{0,-4}", nums);
            }
            Console.WriteLine();
        }
    }
}
