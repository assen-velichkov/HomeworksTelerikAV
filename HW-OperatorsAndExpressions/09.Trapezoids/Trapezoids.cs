using System;
/* Problem 9. Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("To calculate the area of a trapezoid, enter its 2 sides and height:");
        Console.Write("side a --> ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("side b --> ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("and height h --> ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("The area of a trapezoid with sides {0} and {1} and height {2} is {3}", a, b, h, area);
    }
}
