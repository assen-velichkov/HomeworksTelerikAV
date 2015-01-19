using System;

/* Problem 13.* Comparing Floats
Write a program that safely compares floating-point 
numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be 
compared directly by a == b because of the nature of 
the floating-point arithmetic. Therefore, we assume two numbers 
are equal if they are more closely to each other than a fixed constant eps.
*/

class comparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        Console.WriteLine("Enter value for a = ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for b = ");
        double b = double.Parse(Console.ReadLine());
        bool compareAB = Math.Abs(a - b) < eps;
        Console.WriteLine("Are they equal?  {0}", compareAB);
    }
}
