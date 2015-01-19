using System;

/* Problem 8. Isosceles Triangle
Write a program that prints an isosceles triangle of 9 copyright symbols ©, 
something like this:
   ©

  © ©

 ©   ©

© © © ©

*/

class isoscelesTriangle
{
    static void Main()
    {
        char copyrightSymbol = '©';
        Console.OutputEncoding = System.Text.Encoding.UTF8; // set Command propt font to Lucida console
        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}\n", copyrightSymbol);
    }
}