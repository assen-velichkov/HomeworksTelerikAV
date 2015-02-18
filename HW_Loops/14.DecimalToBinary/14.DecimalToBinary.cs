/* Problem 14. Decimal to Binary Number
Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Examples:
decimal	binary
0	0
3	11
43691	1010101010101011
236476736	1110000110000101100101000000
*/

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        long input = long.Parse(Console.ReadLine());
        string binary = "";
        while (input < 0)
        {
            Console.WriteLine("The number should be positive, try again: ");
        }
        if (input == 0)
        {
            Console.WriteLine("Binary: "+ input.ToString());
            return;
        }
        while (input > 0)
        {
            binary += input % 2;
            input /= 2;
        }

        Console.Write("Binary: ");

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            Console.Write(binary[i]);
        }
        Console.WriteLine();
    }
}
