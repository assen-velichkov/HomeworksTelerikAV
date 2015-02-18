/* Problem 11. Binary search
Write a program that finds the index of given element in a 
sorted array of integers by using the Binary search algorithm.
 */

using System;

class BinarySearch
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
        Console.WriteLine("Enter a number to find its position in the array: ");
        int givenNumber = int.Parse(Console.ReadLine());
        Array.Sort(array);
        int indexToBeFound = 0;
        int minIndex = 0;
        int maxIndex = array.Length - 1;
        Console.Clear();
        Console.WriteLine(String.Join(", ", array));
        Console.WriteLine();
        while (minIndex <= maxIndex)
        {
            int middleIndex = (minIndex + maxIndex) / 2;
            if (givenNumber == array[middleIndex])
            {
                indexToBeFound = middleIndex;
                Console.WriteLine("Given number {0} has index {1} in the array", givenNumber, indexToBeFound);
                return;
            }
            else if (givenNumber < array[middleIndex])
            {
                maxIndex = middleIndex - 1;
            }
            else
            {
                minIndex = middleIndex + 1;
            }
        }
        Console.WriteLine("{0} was not found in [{1}]", givenNumber, String.Join(", ", array));
    }
}
