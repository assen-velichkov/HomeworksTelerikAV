/*Problem 4. Print a Deck of 52 Cards
Write a program that generates and prints all possible cards from a 
standard deck of 52 cards (without the jokers). The cards should be 
printed using the classical notation (like 5 of spades, A of hearts, 
9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, 
hearts and spades. Use 2 nested for-loops and a switch-case statement.
output
2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
…  
K of spades, K of clubs, K of hearts, K of diamonds
A of spades, A of clubs, A of hearts, A of diamonds
Note: You may use the suit symbols instead of text.
*/

using System;

class PrintADeckOfCards
{
    static void Main()
    {
        for (int cards = 2; cards <= 14; cards++)
        {
            for (int suits = 1; suits <= 4; suits++)
            {
                switch (cards)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.Write(cards); break;
                    case 11: Console.Write("J"); break;
                    case 12: Console.Write("Q"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;
                }
                switch (suits)
                {
                    case 1: Console.Write(" of spades, "); break;
                    case 2: Console.Write(" of clubs, "); break;
                    case 3: Console.Write(" of hearts, "); break;
                    case 4: Console.Write(" of diamonds \n"); break;
                }
            }
        }
    }
}
