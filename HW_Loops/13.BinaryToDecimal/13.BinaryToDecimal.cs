/* Problem 13. Binary to Decimal Number
Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Examples:
binary	decimal
0	0
11	3
1010101010101011	43691
1110000110000101100101000000	236476736
*/

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number: ");
        string input = Console.ReadLine();

        long output = 0;
        for (int bit = 0; bit < input.Length; bit++)
        {
            output *= 2;
            output += long.Parse(input[bit].ToString());
        }
        Console.WriteLine(output);
    }
}
