/* Problem 15. Hexadecimal to Decimal Number
Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Examples:

hexadecimal	decimal
FE	254
1AE3	6883
4ED528CBB4	338583669684
*/
using System;

class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string input = Console.ReadLine();
        long output = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            switch (input[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    output += (long.Parse(input[i].ToString())) * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'A':
                    output += 10 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'B':
                    output += 11 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'C':
                    output += 12 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'D':
                    output += 13 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'E':
                    output += 14 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'F':
                    output += 15 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
            }
        }
        Console.WriteLine("Decimal: {0}", output);
    }
}
