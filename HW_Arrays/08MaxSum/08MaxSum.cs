/* Problem 8. Maximal sum
Write a program that finds the sequence of maximal sum in given array.
Example:
input	result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
Can you do it with only one loop (with single scan through the elements of the array)?
*/
using System;

class MaxSum
{
    static void Main()
    {
        int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int start = 0;
        int bestStart = 0;
        int bestEnd = 0;
        int currentSum = 0;
        int bestSum = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum <= 0)
            {
                start = i;
                currentSum = 0;
            }
            currentSum += array[i];
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestStart = start;
                bestEnd = i;
            }
        }
        for (int k = 0; k < array.Length; k++)
		{
            if (k < array.Length - 1)
            {
                Console.Write("{0,0}, ", array[k]);
            }
            else
            {
                Console.Write("{0,0}", array[k]);
            }
		}
        Console.WriteLine();
        for (int j = bestStart; j <= bestEnd; j++)
        {
            if (j < bestEnd)
            {
                Console.Write("{0,0}, ", array[j]);
            }
            else
            {
                Console.Write("{0,0}", array[j]);
            }
        }
        Console.WriteLine();
    }
}
