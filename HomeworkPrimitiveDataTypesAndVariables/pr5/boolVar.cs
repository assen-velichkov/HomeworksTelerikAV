using System;

/* Problem 5. Boolean Variable
Declare a Boolean variable called isFemale and assign 
an appropriate value corresponding to your gender.
Print it on the console. 
*/

class boolVar
{
    static void Main()
    {
        bool isFemale = false;
        bool isMale = true;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Am i female? {0}", isFemale);
        Console.WriteLine("Am i male? {0}", isMale);
    }
}
