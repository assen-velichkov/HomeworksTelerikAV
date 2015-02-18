/* Problem 14. Quick sort
Write a program that sorts an array of integers using the Quick sort algorithm.
*/

using System;

class QuickSort
{
    static void Main(string[] args)
    {
        int[] unsortedArray = new int[] { 5, 2, 7, 11, 4, 3, 1, 0, 6, 9, 8, 10 };
        Console.WriteLine("Unsorted array: {0}", string.Join(", ", unsortedArray));
        Quicksort(unsortedArray, 0, unsortedArray.Length - 1);
        Console.WriteLine("Sorted array: {0}", string.Join(", ", unsortedArray));
    }

    public static void Quicksort(int[] intArray, int start, int end)
    {
        int i = start;
        int j = end;
        int pivot = (start + end) / 2;
        while (i <= j)
        {
            while (intArray[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (intArray[j].CompareTo(pivot) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                int tmp = intArray[i];
                intArray[i] = intArray[j];
                intArray[j] = tmp;
                i++;
                j--;
            }
        }

        if (start < j)
        {
            Quicksort(intArray, start, j);
        }

        if (i < end)
        {
            Quicksort(intArray, i, end);
        }
    }
}
