/* Problem 11. Random Numbers in Given Range
Write a program that enters 3 integers n, min and max (min != max) 
and prints n random numbers in the range [min...max].
Examples:
n	min	max	random numbers
5	0	1	1 0 0 1 1
10	10	15	12 14 12 15 10 12 14 13 13 11
Note: The above output is just an example. Due to randomness, 
your program most probably will produce different results.
*/

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter count n: ");
        int n = int.Parse(Console.ReadLine());

        while (n <= 1)
        {
            Console.WriteLine("Count should be bigger than 1, try again: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter min: ");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        while (max <= min)
        {
            Console.WriteLine("max should be bigger than min, please try again: ");
            max = int.Parse(Console.ReadLine());
        }
        Random rand = new Random();
        int result = rand.Next(min, max);
        
        for (int i = 0; i <= n; i++)
        {
            Console.Write("{0} ", result);
            result = rand.Next(min, max);
        }
    }
}
