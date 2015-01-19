using System;

/* Problem 12. Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

class nullValues
{
    static void Main()
    {
        int? intNumber = null;
        double? doubleNumber = null;

        Console.WriteLine("Nullable integer = {0}", intNumber);
        Console.WriteLine("Nullable double = {0}", doubleNumber);

        intNumber = intNumber + 5;
        doubleNumber = doubleNumber + 5;

        Console.WriteLine("New value of integer = {0}", intNumber);
        Console.WriteLine("New value of double = {0}", doubleNumber);
    }
}
