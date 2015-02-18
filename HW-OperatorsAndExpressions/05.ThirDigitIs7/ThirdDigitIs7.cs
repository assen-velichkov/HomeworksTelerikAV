using System;
/* Problem 5. Third Digit is 7?
Write an expression that checks for given integer 
if its third digit from right-to-left is 7.
*/

class ThirDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Write a number with more than 3 digits");
        long input = long.Parse(Console.ReadLine());
        while (input < 100)
        {
            Console.WriteLine("Try again");
            input = long.Parse(Console.ReadLine());
        }
        bool number = (input / 100) % 10 == 7;
        Console.WriteLine("Has the number {0} seven as a third digit (right-to-left) --> {1}", input, number);
    }
}
