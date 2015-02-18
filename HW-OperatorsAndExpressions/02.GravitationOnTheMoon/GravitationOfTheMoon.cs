using System;

/* Problem 2. Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/

class GravitationOnTheMoon
{
    static void Main()
    {
        double manOnTheEarth;
        double manOnTheMoon;
        double moonGravity = 0.17;
        Console.WriteLine("Enter your weight in kilos:");
        manOnTheEarth = double.Parse(Console.ReadLine());
        manOnTheMoon = manOnTheEarth * moonGravity;
        Console.WriteLine("If you go to the Moon, your weight will be {0} kilos", manOnTheMoon);
    }
}
