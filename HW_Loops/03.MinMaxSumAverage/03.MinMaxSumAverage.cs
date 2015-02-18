/* Problem 3. Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns 
the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
Example 1:
input	output
3 
2 
5 
1	min = 1 
max = 5 
sum = 8 
avg = 2.67
Example 2:
input	output
2 
-1 
4	min = -1 
max = 4 
sum = 3 
avg = 1.50
*/

using System;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.WriteLine("Enter count: ");
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        long sum = 0;
        double average = 0;
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter integer {0}: ", i+1);
            number = int.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            sum += number;
        }
        average = (double)sum / n;
        Console.Clear();
        Console.WriteLine("Max: {0}\nMin: {1}\nSum: {2}\nAverage: {3:0.00}", max, min, sum, average);
    }
}
