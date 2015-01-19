using System;

/* Problem 10. Employee Data
A marketing company wants to keep record of its employees. 
Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single 
employee using appropriate primitive data types. Use descriptive names. 
Print the data at the console.
*/

class employeeData
{
    static void Main()
    {
        Console.WriteLine("First name:"); 
        string firstName = Console.ReadLine();
        
        Console.WriteLine("Last name:");
        string lastName = Console.ReadLine();
        
        Console.WriteLine("Age (0-100):");
        short age;
        age = Convert.ToInt16(Console.ReadLine()); 
        while (age < 0 || age > 100)
        {
            Console.WriteLine("Try again");
            age = Convert.ToInt16(Console.ReadLine());
        }
        string gen;
        do
            {
                Console.WriteLine("Gender(m/f)?");
                gen = Console.ReadLine();
            }
        while (gen != "m" && gen != "f");

        Console.WriteLine("Personal ID number:");
        long personalID = long.Parse(Console.ReadLine());
        
        Console.WriteLine("Press Enter to receive your unique employee number:");
        Console.ReadLine();
        Random randomNumber = new Random();
        int employeeNumber = randomNumber.Next(27560000, 27569999);
       
        Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n",firstName,lastName,age,gen,personalID);
        Console.WriteLine("Your Unique Employee Number is: {0}", employeeNumber);
    }
}
