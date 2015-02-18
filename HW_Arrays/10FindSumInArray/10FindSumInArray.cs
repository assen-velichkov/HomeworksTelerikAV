/* Problem 10. Find sum in array
Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:
array	S	result
4, 3, 1, 4, 2, 5, 8	11	4, 2, 5
*/

using System;

class FindSumInArray
{
    static void Main()
    {
        int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        int wantedSum = 11;
        int start = 0;
        int end = 0;
        int currentSum = 0;
        bool foundSum = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (foundSum == true)
            {
                break;
            }
            start = i;
            currentSum = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (currentSum < wantedSum)
                {
                    currentSum += array[j];
                    if (currentSum == wantedSum)
                    {
                        end = j;
                        foundSum = true;
                        break;
                    }
                }
                else
                {
                    currentSum = array[j];
                }
            }
            if (foundSum == true)
            {
                int[] sequence = new int[end - start + 1];
                Console.Clear();
                for (int h = 0; h < array.Length; h++)
                {
                    if (h < array.Length - 1)
                    {
                        Console.Write("{0}, ", array[h]);
                    }
                    else
                    {
                        Console.Write("{0}", array[h]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Result");
                for (int k = 0; k < sequence.Length; k++)
                {
                    sequence[k] = array[start + k];
                    if (k < sequence.Length - 1)
                    {
                        Console.Write("{0}, ", sequence[k]);
                    }
                    else
                    {
                        Console.Write("{0}", sequence[k]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
