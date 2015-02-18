using System;
/* Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p 
(counting from 0, starting from the right) in given integer number n, has value of 1.
*/


class CheckBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter bit position (0-15):");
        int p = int.Parse(Console.ReadLine());
        if (p < 0 || p > 15)
        {
            Console.WriteLine("Bit position shoud be a number between 0 and 16, try again:");
            p = int.Parse(Console.ReadLine());
        }
        bool check = ((n >> p) & 1) == 1;
        Console.WriteLine("The bit position " + p + " of the integer " + n + " is 1 --> " + check);
    }
}
