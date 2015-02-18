/* Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
Write a program that, for a given two integer numbers n and x, 
calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
Examples:
n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781
*/

using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Enter two integer numbers: ");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += (decimal)Factorial(i) / (decimal)Math.Pow(x, i);
        }

            Console.WriteLine("{0:0.00000}", sum);
    }
    private static BigInteger Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}
