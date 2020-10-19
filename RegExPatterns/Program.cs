using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Transactions;
using UserRegistration;

namespace RegExPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");
            Patterns p = new Patterns();
            RegStart1:
            Console.WriteLine("Enter First Name(should start with capital letter and contain minimum 3 characters");
            string fName = Console.ReadLine();
            List<string> firstName = new List<string> { fName };
            bool check = p.ValidateFirstName(firstName);
            if (check==true)
            {
                Console.WriteLine("First Name: " + fName);
            }
            else
            {
                goto RegStart1;
            }

            RegStart2:
            Console.WriteLine("Enter Last Name(should start with capital letter and contain minimum 3 characters");
            string lName = Console.ReadLine();
            List<string> lastName = new List<string> { lName };
            check = p.ValidateLastName(lastName);
            if (check==true)
            {
                Console.WriteLine("Last Name: " + lName);
            }
            else
            {
                goto RegStart2;
            }
            RegStart3:
            Console.WriteLine("Enter Email Address(should be in the format abc.xyz@bl.co.in where xyz and in are optional)");
            string email = Console.ReadLine();
            List<string> emailAddress = new List<string> { email };
            check = p.ValidateEmail(emailAddress);
            if (check==true)
            {
                Console.WriteLine("Email Address: " + email);
            }
            else
            {               
                goto RegStart3;
            }
            RegStart4:
            Console.WriteLine("Enter Mobile Number(should start with country pincode and contain 10 numbers)");
            string number = Console.ReadLine();
            List<string> phoneNumber = new List<string> { number };
            check = p.ValidatePhone(phoneNumber);
            if (check==true)
            {
                Console.WriteLine("Phone Number: " + number);
            }
            else
            {
                goto RegStart4;
            }
            RegStart5:
            Console.WriteLine("Enter Password(should contain minimum 8 characters");
            string password = Console.ReadLine();
            List<string> passWord = new List<string> { password };
            check = p.ValidatePassword(passWord);
            if (check == true)
            {
                Console.WriteLine("Password: " + password);                
            }
            else
            {
                goto RegStart5;
            }
        }
    }
}
