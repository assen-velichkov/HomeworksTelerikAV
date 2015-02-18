using System;
/* Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
Examples:

a	b	c	result
5	2	2	+
-2	-2	1	+
-2	4	3	-
0	-2.5	4	0
-1	-0.5	-5.1	-
*/

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 real numbers a, b and c: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product of a*b*c = 0");
        }
        else if ((a > 0 && b > 0 && c > 0) ||
                 (a > 0 && b < 0 && c < 0) ||
                 (a < 0 && b > 0 && c < 0) ||
                 (a < 0 && b < 0 && c > 0))
        {
            Console.WriteLine("The product of a*b*c has a sign +");
        }
        else
        {
            Console.WriteLine("The product of a*b*c has a sign -");
        }
    }
}
