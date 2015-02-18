using System;
/* Problem 1. Exchange If Greater
Write an if-statement that takes two double variables a and b and 
exchanges their values if the first one is greater than the second one. 
As a result print the values a and b, separated by a space.
Examples:
a	b	result
5	2	2 5
3	4	3 4
5.5	4.5	4.5 5.5
*/

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers a and b: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double i;
        if (a > b)
        {
            i = a;
            a = b;
            b = i;
            Console.WriteLine(a + " " + b);
            // or we can just change positions with: Console.WriteLine(b + " " + a);
        }
        else
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
