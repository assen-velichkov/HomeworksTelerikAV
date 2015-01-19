using System;
/* Problem 11. Bank Account Data
A bank account has a holder name (first name, middle name and last name), 
available amount of money (balance), bank name, IBAN, 
3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank 
account using the appropriate data types and descriptive names.
*/

class bankAccountData
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        double balance = -23456.55;
        double visaBalance = -1000.43;
        double amexBalance = -205.11;
        double masterBalance = 3450.00;
        string bankName = "Korporate Trade Bank";
        string IBAN = "BG11BGSF1111111111";
        string userIBAN;
        long visa = 2222222222;
        long masterCard = 3333333333;
        long americanExpress = 4444444444;
        long userCard;
        Console.WriteLine("First name:");
        firstName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Middle name:");
        middleName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Last name:");
        lastName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("IBAN:");
        userIBAN = Convert.ToString(Console.ReadLine());
        while (userIBAN!=IBAN)
        {
            Console.WriteLine("Wrong number. Try again.");
            userIBAN = Convert.ToString(Console.ReadLine());
        }
        Console.WriteLine("Dear {0} {1} {2}, welcome to {3}.", firstName, middleName, lastName, bankName); 
        Console.WriteLine("Your current account balance is {0}", balance);
        Console.WriteLine("To check your credit balance, enter your VISA card number:");
        userCard = Convert.ToInt64(Console.ReadLine());
        while (userCard!=visa)
        {
            Console.WriteLine("Wrong number. Try again.");
            userCard = Convert.ToInt64(Console.ReadLine());
        }
        Console.WriteLine("The current balance of your Visa card is {0}", visaBalance);
        Console.WriteLine("Enter your Master Card number:");
        userCard = Convert.ToInt64(Console.ReadLine());
        while (userCard != masterCard)
        {
            Console.WriteLine("Wrong number. Try again.");
            userCard = Convert.ToInt64(Console.ReadLine());
        }
        Console.WriteLine("The current balance of your Master card is {0}", masterBalance);
        Console.WriteLine("Enter your American Express card number:");
        userCard = Convert.ToInt64(Console.ReadLine());
        while (userCard != americanExpress)
        {
            Console.WriteLine("Wrong number. Try again.");
            userCard = Convert.ToInt64(Console.ReadLine());
        }
        Console.WriteLine("The current balance of your American Express card is {0}", amexBalance);
    }
}
