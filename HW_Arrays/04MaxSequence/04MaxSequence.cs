/*Problem 4. Maximal sequence
Write a program that finds the maximal sequence of equal elements in an array.
Example:
input	result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1
*/

using System;
using System.Collections.Generic;

class MacimalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter array legth > 1: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("Enter integer for array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int maxSequenceLength = 1;
        int sum = 0;
        for (int j = 1; j < arrayLength; j++)
        {
            if (array[j] == array[j - 1])
            {
                sum = array[j] + array[j - 1];
                maxSequenceLength++;
            }
            else
            {
                continue;
            }
        }
        int element = sum / maxSequenceLength;
        Console.WriteLine("Max sequence is {0} numbers long", maxSequenceLength);
        for (int k = 0; k < maxSequenceLength; k++)
        {
            Console.Write("{0} ", element);
        }
    }
}
