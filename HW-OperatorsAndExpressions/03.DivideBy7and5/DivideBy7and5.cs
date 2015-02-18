using System;
/* Problem 3. Divide by 7 and 5
Write a Boolean expression that checks for given integer if 
it can be divided (without remainder) by 7 and 5 at the same time.
*/

class DivideBy7and5
{
    static void Main()
    {
        Console.WriteLine("Type an integer to check if it can be divided by 7 and 5 at the same time without remainder:");
        int input = int.Parse(Console.ReadLine());
        bool check = (input % 5 == 0) && (input % 7 == 0);
        Console.WriteLine("Can {0} be divided by 7 and 5 at the same time without remainder --> {1}", input, check);
    }
}
