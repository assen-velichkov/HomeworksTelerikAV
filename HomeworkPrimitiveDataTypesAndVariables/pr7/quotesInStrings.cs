using System;

/* Problem 7. Quotes in Strings
Declare two string variables and assign them with following value: 
The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.
*/

class quotesInStrings
{
    static void Main()
    {
        string escapeQuotes = "The \"use\" of quotations causes difficulties.";
        string doubleQuotes = @"The ""use"" of quotations causes difficulties.";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(escapeQuotes);
        Console.WriteLine(doubleQuotes);
    }
}