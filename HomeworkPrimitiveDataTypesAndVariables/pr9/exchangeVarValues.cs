﻿using System;

/* Problem 9. Exchange Variable Values
Declare two integer variables a and b and assign them with 
5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
*/

class exchangeVarValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
