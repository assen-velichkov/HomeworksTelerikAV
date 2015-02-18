using System;
/* Problem 6. Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
*/

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter a 4 digit number and don't start with 0");
        int number = int.Parse(Console.ReadLine());
        while (number < 1000 || number > 9999 || number < 1)
        {
            Console.WriteLine("Try again with a 4 digit number and don't start with 0");
            number = int.Parse(Console.ReadLine());
        }
        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10;
        int a = (number / 1000) % 10;
        Console.WriteLine("Sum --> " + (a + b + c + d));
        Console.WriteLine("Reversed --> {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit first --> {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged --> {0}{1}{2}{3}", a, c, b, d);

    }
}
