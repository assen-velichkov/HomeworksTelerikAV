/* Problem 8. Catalan Numbers
In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
Examples:
n	Catalan(n)
0	1
5	42
10	16796
15	9694845
*/

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number n (0 <= n <= 100): ");
        int n = int.Parse(Console.ReadLine());

        while (n < 0 || n > 100)
        {
            Console.WriteLine("Wrong input, please enter number n (0 <= n <= 100): ");
            n = int.Parse(Console.ReadLine());
        }
        BigInteger Cn = 1;
        BigInteger factorial1 = 1;
        BigInteger factorial2 = 1;
        BigInteger factorial3 = 1;

        for (int i = 1; i <= 2*n; i++)
        {
            factorial1 *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            factorial2 *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            factorial3 *= i;
        }

        Cn = factorial1 / (factorial2 * factorial3);
        Console.WriteLine(Cn);
    }
}
