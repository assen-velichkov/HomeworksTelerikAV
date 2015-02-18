using System;

/* Problem 8. Prime Number Check
Write an expression that checks if given positive 
integer number n (n = 100) is prime (i.e. it is 
divisible without remainder only to itself and 1).
*/

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Write a positive integer (0-100):");
        int number = int.Parse(Console.ReadLine());
        bool isTrue = true;
        Console.Write("Is the number prime --> ");
        if (number > 1 && number <= 100)
        {
            for (int i = 2; i < 10; i++)
            {
                if (number != i)
                {
                    if (number % i == 0)
                    {
                        isTrue = false;
                    }
                }
            }
            Console.WriteLine(isTrue);
        }
        else
        {
            Console.WriteLine(isTrue = false);
        }
    }
}
