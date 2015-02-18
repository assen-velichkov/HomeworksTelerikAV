using System;

/* Problem 7. Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
*/

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers coordinates of a point:");
        Console.Write("X --> ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y --> ");
        double y = double.Parse(Console.ReadLine());
        Console.Write("Point is in the circle K({0, 0}, 2) --> ");
        if (((x * x) + (y * y)) <= (2 * 2))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
