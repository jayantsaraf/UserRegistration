using System;
using System.Threading;

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
            bool check = p.ValidateFirstName(fName);
            if(check==false)
            {
                Console.WriteLine("Enter Valid First Name");
                goto RegStart1;
            }
            else
            {
                Console.WriteLine("First Name: " + fName);
            }
            RegStart2:
            Console.WriteLine("Enter Last Name(should start with capital letter and contain minimum 3 characters");
            string lName = Console.ReadLine();
            check = p.ValidateLastName(lName);
            if (check == false)
            {
                Console.WriteLine("Enter Valid First Name");
                goto RegStart2;
            }
            else
            {
                Console.WriteLine("Last Name: " + lName);
            }
            RegStart3:
            Console.WriteLine("Enter Email Address(should be in the format abc.xyz@bl.co.in where xyz and in are optional)");
            string email = Console.ReadLine();
            check = p.ValidateEmail(email);
            if (check == false)
            {
                Console.WriteLine("Enter Valid phone number");
                goto RegStart3;
            }
            else
            {
                Console.WriteLine("Email Address: " + email);
            }
            RegStart4:
            Console.WriteLine("Enter Mobile Number(should start with country pincode and contain 10 numbers)");
            string number = Console.ReadLine();
            check = p.ValidatePhone(number);
            if (check == false)
            {
                Console.WriteLine("Enter Valid phone number");
                goto RegStart4;
            }
            else
            {
                Console.WriteLine("Phone Number: " + number);
            }
            RegStart5:
            Console.WriteLine("Enter Password(should contain minimum 8 characters");
            string password = Console.ReadLine();
            check = p.ValidatePassword(password);
            if (check == false)
            {
                Console.WriteLine("Enter Valid password");
                goto RegStart5;
            }
            else
            {
                Console.WriteLine("Password: " + password);
            }
        }
    }
}
