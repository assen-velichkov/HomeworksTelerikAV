/* Problem 9. Frequent number
Write a program that finds the most frequent number in an array.
Example:
input	result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)
*/

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("Enter number for array[{0}]", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int mostFrequent = array[0];
        int currentCount = 1;
        int maxCount = 1;
        for (int k = 0; k < arrayLength; k++)
        {
            currentCount = 1;
            for (int j = k + 1; j < arrayLength; j++)
            {
                if (array[j] == array[k])
                {
                    currentCount++;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    mostFrequent = array[j];
                }
            }
        }
        Console.WriteLine("{0} ({1} times)", mostFrequent, maxCount);
    }
}
