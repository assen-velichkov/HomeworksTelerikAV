/* Problem 10. Odd and Even Product
You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is 
equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
Examples:
numbers	result
2 1 1 6 3	yes
product = 6	
3 10 4 6 5 1	yes
product = 60	
4 3 2 5 2	no
odd_product = 16	
even_product = 15
*/

using System;

class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter some integers, separated by space: ");
        string line = Console.ReadLine();
        string number = "";
        int count = 0;
        long productEven = 1;
        long productOdd = 1;
        
        for (int i = 0; i < line.Length; i++)
        {
            number = "";
            while (line[i] != ' ' && i < line.Length)
            {
                number += line[i];
                if (i < line.Length - 1)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            count++;
            if (count % 2 == 0)
            {
                productEven *= int.Parse(number);
            }
            else
            {
                productOdd *= int.Parse(number);
            }
        }
        if (productEven == productOdd)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}