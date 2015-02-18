using System;
/* Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates 
and prints their sum. Note: You may need to use a for-loop.
Examples:

numbers	sum
3	90
20	
60	
10	
5	6.5
2	
-1	
-0.5	
4	
2	
1	1
1
*/

class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("Enter number for count: ");
        int count = int.Parse(Console.ReadLine());
        while (count < 1)
        {
            Console.WriteLine("No numbers to sum. Try again!");
            count = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter {0} more numbers: ", count);

        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }

        Console.Clear();
        Console.WriteLine("The sum is {0:F2}.", sum);
    }
}
