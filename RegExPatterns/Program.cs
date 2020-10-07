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
            RegStart:
            Console.WriteLine("Enter First Name(should start with capital letter and contain minimum 3 characters");
            string fName = Console.ReadLine();
            bool check = p.ValidateFirstName(fName);
            if(check==false)
            {
                Console.WriteLine("Enter Valid First Name");
                goto RegStart;
            }
            else
            {
                Console.WriteLine("First Name: " + fName);
            }
        }
    }
}
