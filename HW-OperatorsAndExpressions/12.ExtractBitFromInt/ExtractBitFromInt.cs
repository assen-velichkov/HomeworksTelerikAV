using System;
/* Problem 12. Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p.
*/

class ExtractBitFromInt
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position to check (0-15):");
        int indexP = int.Parse(Console.ReadLine());
        while (indexP < 0 || indexP > 15)
        {
            Console.WriteLine("Enter a number between 0 and 15");
            indexP = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The #{0} bit of the number {1} is", indexP, n);
        Console.WriteLine((n >> indexP) & 1);
    }
}
