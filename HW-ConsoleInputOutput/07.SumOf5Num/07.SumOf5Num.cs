using System;

/* Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
Examples:

numbers	sum
1 2 3 4 5	15
10 10 10 10 10	50
1.5 3.14 8.2 -1 0	11.84
*/

class SumOf5Num
{
    static void Main()
    {
        Console.Write("Please enter 5 numbers separated by a space: ");
        string input = Console.ReadLine();
        string number = "";
        Console.WriteLine(number);
        double sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                number += input[i];
                if (i == input.Length - 1)
                {
                    sum += double.Parse(number);
                }
            }
            else
            {
                sum += double.Parse(number);
                number = "";
            }
        }
        Console.WriteLine("The sum of these numbers is {0}", sum);
    }
}
