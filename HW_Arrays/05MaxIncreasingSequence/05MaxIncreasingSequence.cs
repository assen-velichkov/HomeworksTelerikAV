/* Problem 5. Maximal increasing sequence
Write a program that finds the maximal increasing sequence in an array.
Example:
input	result
3, 2, 3, 4, 2, 2, 4
*/

using System;
using System.Linq;

class MaxIncreasingSequence
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array legth > 1: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("Enter integer for array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int sequenceLength = 1;
        int currentElement = 0;
        for (int j = 1; j < arrayLength; j++)
        {
            if (array[j] == (array[j - 1] + 1))
            {
                currentElement = (array[j - 1] + 1);
                sequenceLength++;
            }
            else
            {
                continue;
            }
        }
        int lastInSequence = currentElement + 1;
        int firstInSequence = lastInSequence - sequenceLength;
        int[] maxIncreasingSequence = Enumerable.Range(firstInSequence, sequenceLength).ToArray();
        Console.WriteLine("Max increasing sequence is {0} numbers long", sequenceLength);
        for (int k = 0; k < sequenceLength; k++)
        {
            Console.Write("{0} ", maxIncreasingSequence[k]);
        }
        Console.WriteLine();
    }
}
