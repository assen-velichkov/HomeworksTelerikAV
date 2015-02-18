using System;

/*Problem 15.* Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 
25 and 26 of given 32-bit unsigned integer.
*/

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation input number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

        int lowPos = 3;
        int highPos = 24;
        while (lowPos >= 3 && lowPos <= 5)
        {
            uint exchengeLowPositionValue;
            uint exchengeHighPositionValue;

            uint checkLowPositionValue = (number >> lowPos) & 1;
            uint checkHighPositionValue = (number >> highPos) & 1;

            if (checkLowPositionValue == 1)
            {
                exchengeHighPositionValue = checkLowPositionValue << highPos;
                number = number | exchengeHighPositionValue;
            }
            else
            {
                exchengeHighPositionValue = (uint)~(1 << highPos);
                number = number & exchengeHighPositionValue;
            }
            if (checkHighPositionValue == 1)
            {
                exchengeLowPositionValue = checkHighPositionValue << lowPos;
                number = number | exchengeLowPositionValue;
            }
            else
            {
                exchengeLowPositionValue = (uint)~(1 << lowPos);
                number = number & exchengeLowPositionValue;
            }
            lowPos++;
            highPos++;
        }
        Console.WriteLine("Binary representation result is: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The result is --> {0}", number);
    }
}