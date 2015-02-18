using System;
/* Problem 10. Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it 
is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

class PointInsideOutside
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers coordinates of a point:");
        Console.Write("X --> ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y --> ");
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        bool withinCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= Math.Pow(r, 2);
        bool outsideRect = ((x < -1) || (x > 5) || (y > 1) || (y < -1));
        bool check = withinCircle && outsideRect;
        Console.WriteLine("Point with coordinates {0} and {1} is within circle K and outside the rectangle R --> {2}", x, y, check);
    }
}
