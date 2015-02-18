/* Problem 7. Selection sort
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
smallest from the rest, move it at the second position, etc.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
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

        for (int j = 0; j < arrayLength - 1; j++)
        {
            int min = j;
            for (int k = j+1; k < arrayLength; k++)
            {
		        if (array[k] < array[min])
                {
                    min = k;
                }
            }
            if (min != j)
            {
                int temp = array[j];
                array[j] = array[min];
                array[min] = temp;
            }
        }
        for (int s = 0; s < arrayLength; s++)
        {
            Console.Write(array[s]);
        }
    }
}
