/* Problem 6. Maximal K sum
Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */
using System;
using System.Linq;

class MaxKsum
{
    static void Main()
    {
        Console.WriteLine("Enter an integer K: ");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer N: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter element [{0}] of an array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int largest = 0;
        int[] elements = new int[K];
        for (int q = 0; q < K; q++)
        {
            for (int j = 0; j < N; j++)
            {
                if (array[j] >= largest)
                {
                    largest = array[j];
                }
            }
            elements[q] = largest;
            array = array.Where(val => val != largest).ToArray();
            largest = 0;
            N--;
        }
        for (int l = 0; l < K; l++)
        {
            Console.Write("{0} ", elements[l]);
        }
    }
}
