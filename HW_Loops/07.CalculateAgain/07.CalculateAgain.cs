/* Problem 7. Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose k different members 
out of a group of n different elements (also known as the number of 
combinations) is calculated by the following formula: formula For example,
there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) 
for given n and k (1 < k < n < 100). Try to use only two loops.
Examples:
n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10	6	210
52	5	2598960
*/

using System;

class CalculateAgain
{
    static void Main()
    {
        Console.WriteLine("Enter number n (2-100): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number k (1 < k < n): ");
        int k = int.Parse(Console.ReadLine());

        long nFaktorial = 1;
        long kFaktorial = 1;
        int nminusk = n - k;
        long nminuskFaktorial = 1;
        long result = 1;


        for (int i = 1; i <= n; i++)
        {
            nFaktorial *= i;
        }
        
        for (int i = 1; i <= k; i++)
		{
			 kFaktorial *= i;
		}

        for (int i = 1; i <= nminusk; i++)
		{
			 nminuskFaktorial *= i;
		}
        result = nFaktorial / (kFaktorial * nminuskFaktorial);
    
        Console.WriteLine(result);
        // Couldn't find my way to make it with only 2 loops and preffer not to copy paste it
    }
}
