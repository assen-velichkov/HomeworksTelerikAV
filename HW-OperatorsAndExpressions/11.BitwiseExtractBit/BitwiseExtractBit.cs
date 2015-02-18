using System;
/* Problem 11. Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding 
the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

class BitwiseExtractBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The #3 bit of this number is " + ((number >> 3) & 1));
    }
}
