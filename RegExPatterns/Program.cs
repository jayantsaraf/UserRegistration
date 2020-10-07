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
                Console.WriteLine("Last Name: " + fName);
            }
        }
    }
}
