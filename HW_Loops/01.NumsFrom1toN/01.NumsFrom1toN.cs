/* Problem 1. Numbers from 1 to N
Write a program that enters from the console a positive 
integer n and prints all the numbers from 1 to n, on a 
single line, separated by a space.
Examples:
n	output
3	1 2 3
5	1 2 3 4 5
*/

using System;
class NumsFrom1toN
{
    static void Main()
    {
        Console.Write("Enter positive integer number n: ");
        int n = int.Parse(Console.ReadLine());
        while (n <= 0)
        {
            Console.WriteLine("Wrong input, try again: ");
            n = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

