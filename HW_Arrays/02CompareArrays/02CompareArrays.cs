/*Problem 2. Compare arrays
Write a program that reads two integer arrays from the console and compares them element by element.
*/

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter array one index: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[n1];
        for (int i = 0; i < n1; i++)
        {
            Console.Write("Enter integer on position {0} of array one: ", i);
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter array two index: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] arrayTwo = new int[n2];
        for (int j = 0; j < n2; j++)
        {
            Console.Write("Enter integer on position {0} of array two: ", j);
            arrayTwo[j] = int.Parse(Console.ReadLine());
        }
        Console.Clear();
        Console.Write("Array one: ");
        for (int q = 0; q < n1; q++)
        {
            Console.Write("{0} ", arrayOne[q]);
        }
        Console.WriteLine();
        Console.Write("Array two: "); 
        for (int z = 0; z < n2; z++)
        {
            Console.Write("{0} ", arrayTwo[z]);
        }
        Console.WriteLine();
        Console.WriteLine();
        bool equal = false;
        if (n1 == n2)
        {
            for (int k = 0; k < n1; k++)
            {
                if (arrayOne[k] == arrayTwo[k])
                {
                    equal = true;
                }
                else
                {
                    equal = false;
                }
            }
            if (equal == true)
            {
                Console.WriteLine("Arrays one and two are equal");
            }
            else
            {
                Console.WriteLine("Arrays one and two are not equal");
            }
        }
        else
        {
            Console.WriteLine("Arrays one and two have different length and cannot be equal!");
        }
    }
}
