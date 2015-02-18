using System;
/* Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
Example input:

program	user
Company name:	Telerik Academy
Company address:	31 Al. Malinov, Sofia
Phone number:	+359 888 55 55 555
Fax number:	2
Web site:	http://telerikacademy.com/
Manager first name:	Nikolay
Manager last name:	Kostov
Manager age:	25
Manager phone:	+359 2 981 981
*/

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter phone number: ");
        string companyPhoneNum = Console.ReadLine();

        Console.Write("Enter company fax number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Enter company website: ");
        string companyWebsite = Console.ReadLine();

        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Enter manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        while (managerAge < 10 || managerAge > 100)
        {
            Console.WriteLine("Seriously?! This guy is either genious kid, or dead. Please try again!");
            managerAge = byte.Parse(Console.ReadLine());
        }
        Console.Write("Enter manager phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0,-30} {1,-20}", "Company name: ", companyName);
        Console.WriteLine("{0,-30} {1,-20}", "Company address: ", companyAddress);
        Console.WriteLine("{0,-30} {1,-20}", "Company phone: ", companyPhoneNum);
        Console.WriteLine("{0,-30} {1,-20}", "Company fax: ", companyFaxNumber);
        Console.WriteLine("{0,-30} {1,-20}", "Company website: ", companyWebsite);
        Console.WriteLine("{0,-30} {1,-20}", "Manager name: ", managerFirstName + " " + managerLastName);
        Console.WriteLine("{0,-30} {1,-20}", "Manager age: ", managerAge);
        Console.WriteLine("{0,-30} {1,-20}", "Manager phone: ", managerPhone);
    }
}
