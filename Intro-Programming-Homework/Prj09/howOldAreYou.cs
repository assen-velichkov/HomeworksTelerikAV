using System;

/* Problem 15.* Age after 10 Years
Write a program to read your birthday from 
the console and print how old you are now 
and how old you will be after 10 years.
 */

namespace Prj09
{
    class howOldAreYou
    {
        static void Main()
        {           
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Enter your birthdate in the format yyyy/mm/dd");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            DateTime dateToday = DateTime.Now;

            int age = dateToday.Year - dateOfBirth.Year;

            if (dateToday.Month < dateOfBirth.Month ||
               (dateToday.Month == dateOfBirth.Month && dateToday.Day < dateOfBirth.Day))
            {
                age--;
            }

            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("In 10 years you will be " + (age + 10) + " years old.");
        }
    }
}
