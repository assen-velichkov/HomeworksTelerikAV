using System;

/* Problem 10. Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members 
of the Fibonacci sequence (at a single line, separated by comma and space - ,)
: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.
Examples:
n	comments
1	0
3	0 1 1
10	0 1 1 2 3 5 8 13 21 34
*/

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write(@"Please enter a number to specify how many members from 
the beginning of the Fibonacci sequence to print: ");
        int n = int.Parse(Console.ReadLine());

        int first = 0;
        int second = 1;
        int next;

        for (int i = 0; i < n; i++)
        {
            if (i <= 1)
                next = i;

            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine(next);
        }
    }
}
