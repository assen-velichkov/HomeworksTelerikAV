using System;
/* Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
Examples:

a	b	c	d	e	biggest
5	2	2	4	1	5
-2	-22	1	0	0	1
-2	4	3	2	0	4
0	-2.5	0	5	5	5
-3	-0.5	-1.1	-2	-0.1	-0.1
 */

class BiggestOf5
{
    static void Main()
    {
        {
            Console.WriteLine("Please enter 5 numbers a, b, c, d and e: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine("The biggest number is {0}", a);
            }
            if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine("The biggest number is {0}", b);
            }
            if (c >= a && c >= b && c >= d && c >= e)
            {
                Console.WriteLine("The biggest number is {0}", c);
            }
            if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine("The biggest number is {0}", d);
            }
            if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine("The biggest number is {0}", e);
            }
        }
    }
}
