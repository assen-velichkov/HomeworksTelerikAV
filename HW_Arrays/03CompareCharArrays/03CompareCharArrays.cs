/* Problem 3. Compare char arrays
Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter some chars for array one: ");
        string input1 = Console.ReadLine();
        char[] arrayOne = input1.ToCharArray();
        Console.WriteLine("Enter some chars for array two: ");
        string input2 = Console.ReadLine();
        char[] arrayTwo = input2.ToCharArray();
        bool equal = false;
        if (input1.Length == input2.Length)
        {
            for (int i = 0; i < input1.Length; i++)
			{
			    if (arrayOne[i] == arrayTwo[i])
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
                Console.WriteLine("Arrays one and two are equal!");
            }
            else
            {
                Console.WriteLine("Arrays one and two are not equal!");
            }
        }
        else
        {
            Console.WriteLine("Arrays one and two have different length and cannot be equal!");
        }
        /* Another logic comparing element by element and showing bigger/smaller
        int counter = 0;
        if (input1.Length >= input2.Length)
        {
            counter = input2.Length;
        }
        else
        {
            counter = input1.Length;
        }
        for (int k = 0; k < counter; k++)
        {
            if (arrayOne[k] == arrayTwo[k])
            {
                Console.WriteLine("Array one [{0}] is equal to array two [{0}]\n---> {1} = {2}", k, arrayOne[k], arrayTwo[k]);
            }
            else if (arrayOne[k] > arrayTwo[k])
            {
                Console.WriteLine("Array one [{0}] is bigger than array two [{0}]\n---> {1} > {2}", k, arrayOne[k], arrayTwo[k]);
            }
            else
            {
                Console.WriteLine("Array one[{0}] is smaller than array two [{0}]\n---> {1} < {2}", k, arrayOne[k], arrayTwo[k]);
            }
        }*/
    }
}
