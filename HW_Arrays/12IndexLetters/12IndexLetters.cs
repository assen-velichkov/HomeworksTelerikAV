/*Problem 12. Index of letters
Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
*/

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 65);
        }
        Console.WriteLine("Enter a word, using only capital letters: ");
        string word = Console.ReadLine();
        Console.WriteLine("The indeces of this word in the array alphabet are: ");
        for (int j = 0; j < word.Length; j++)
        {
            for (int k = 0; k < alphabet.Length; k++)
            {
                if (word[j] == alphabet[k])
                {
                    if (j < word.Length - 1)
                    {
                        Console.Write("{0}, ", k);
                    }
                    else
                    {
                        Console.Write("{0}", k);
                    }
                }
            }
        }
        Console.WriteLine();
    }
}
