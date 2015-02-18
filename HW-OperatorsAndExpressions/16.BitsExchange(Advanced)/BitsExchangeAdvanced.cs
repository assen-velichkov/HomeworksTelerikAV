using System;
/*Problem 16.** Bit Exchange (Advanced)
Write a program that exchanges bits {p, p+1, …, p+k-1} with 
bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.
 */

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter number: ");
        long number = long.Parse(Console.ReadLine());

        Console.Write("Enter first position: ");
        int firstPos = int.Parse(Console.ReadLine());
        Console.Write("Enter second position: ");
        int secondPos = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of bits that will be exchanged: ");
        int bitNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation input number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

        int tempCount = 0;
        if (firstPos < 0 || firstPos > 32 || firstPos + bitNumber > 32 ||
            secondPos < 0 || secondPos + bitNumber > 32 || secondPos > 32)
        {
            Console.WriteLine("Out of range");
        }
        else if (firstPos > secondPos && secondPos + bitNumber >= firstPos)
        {
            Console.WriteLine("Overlapping");
        }
        else if (secondPos > firstPos && firstPos + bitNumber >= secondPos)
        {
            Console.WriteLine("Overlapping");
        }
        else if (firstPos == secondPos)
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            while (tempCount < bitNumber)
            {
                long exchengeFirstPosValue;
                long exchengeSecondPosValue;

                long checkFirstPosValue = (number >> firstPos) & 1;
                long checkSecondPosValue = (number >> secondPos) & 1;

                if (checkFirstPosValue == 1)
                {
                    exchengeSecondPosValue = checkFirstPosValue << secondPos;
                    number = number | exchengeSecondPosValue;
                }
                else
                {
                    exchengeSecondPosValue = (long)~(1 << secondPos);
                    number = number & exchengeSecondPosValue;
                }

                if (checkSecondPosValue == 1)
                {
                    exchengeFirstPosValue = checkSecondPosValue << firstPos;
                    number = number | exchengeFirstPosValue;
                }
                else
                {
                    exchengeFirstPosValue = (long)~(1 << firstPos);
                    number = number & exchengeFirstPosValue;
                }
                tempCount++;
                firstPos++;
                secondPos++;
            }
            Console.WriteLine("Binary representation result is  : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("The result is --> {0}", number);
        }
    }
}