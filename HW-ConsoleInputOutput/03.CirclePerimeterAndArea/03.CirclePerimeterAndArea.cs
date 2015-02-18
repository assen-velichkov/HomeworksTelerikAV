using System;
/* Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and 
area formatted with 2 digits after the decimal point.
Examples:

r	perimeter	area
2	12.57	12.57
3.5	21.99	38.48
*/

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter radius r of a circle: ");
        double radius = double.Parse(Console.ReadLine());

        double pi = 3.14159265359;
        double per = (radius + radius) * pi;
        double area = (radius * radius) * pi;

        Console.WriteLine("The circle with radius = {0} has perimeter = {1:0.00} and area = {2:0.00}", radius, per, area);
    }
}
