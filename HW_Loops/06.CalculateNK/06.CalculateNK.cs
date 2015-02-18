/* Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
Examples:

n	k	n! / k!
5	2	60
6	5	6
8	3	6720
*/

using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {
        Console.WriteLine("Enter number n (2-100): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number k (1 < k < n): ");
        int k = int.Parse(Console.ReadLine());

        int result = 1; 

        while (n - k >= 1)
        {
            result *= n;
            n--;
        }
        Console.WriteLine(result);
    }
}
