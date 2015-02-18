using System;
/* Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
Examples:
a	b	greater
5	6	6
10	5	10
0	0	0
-5	-2	-2
1.5	1.6	1.6
*/

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers: ");
        Console.WriteLine("The greater one is " +
            Math.Max(
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine())));
    }
}
