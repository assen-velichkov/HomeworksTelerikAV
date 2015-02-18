using System;
/* Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Write the width of a rectangle to check its perimeter and area:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Write the height of a rectangle to check its perimeter and area:");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (width * 2) + (height * 2);
        double area = width * height;
        Console.WriteLine("The perimeter of a rectangle with width {0} and height {1} is {2}, and the area is {3}", height, width, perimeter, area);
    }
}
