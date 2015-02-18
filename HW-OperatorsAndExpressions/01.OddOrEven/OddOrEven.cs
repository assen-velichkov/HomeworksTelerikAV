using System;

/* Problem 1. Odd or Even Integers
Write an expression that checks if given integer is odd or even.
*/

class oddOrEvenInt
{
    static void Main()
    {
        int number;
        Console.WriteLine("Type a number to check if it is odd:");
        number = int.Parse(Console.ReadLine());
        bool odd = (number % 2) == 0;
        Console.WriteLine("Is {0} odd number --> {1}", number, odd);
    }
}
