using System;
/* Problem 1. Sum of 3 Numbers
Write a program that reads 3 real numbers from the console and prints their sum.
Examples:

a	b	c	sum
3	4	11	18
-2	0	3	1
5.5	4.5	20.1	30.1
*/

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter first real number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second real number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third real number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("The sum of {0}, {1} and {2} is {3}", firstNumber, secondNumber, thirdNumber, sum);
    }
}
