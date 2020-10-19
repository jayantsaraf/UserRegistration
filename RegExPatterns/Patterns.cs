using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UserRegistration;

namespace RegExPatterns
{
    public class Patterns
    {
        public bool ValidateFirstName(List<string> firstName)
        {
            if (firstName.TrueForAll(a => a.Contains("^[A-Z][a-z]{3,}?")))
            {
                return true;
            }
            else
            {
                try
                {
                    if (firstName.Exists(a => a.Equals(null)))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.NULL_MESSAGE, "First Name cannot be null");
                    }
                    else if (firstName.Exists(a => a.Equals("")))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.EMPTY_MESSAGE, "Please enter a value");
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid First Name");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception : {0}", ex.Message);
                }
            }
            return false;
        }
        public bool ValidateLastName(List<string> lastName)
        {
            if (lastName.TrueForAll(a => a.Contains("^[A-Z][a-z]{3,}?")))
            {
                return true;
            }
            else
            {
                try
                {
                    if (lastName.Exists(a => a.Equals(null)))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.NULL_MESSAGE, "Last Name cannot be null");
                    }
                    else if (lastName.Exists(a => a.Equals("")))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.EMPTY_MESSAGE, "Please enter a value");
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Last Name");
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Exception : {0}", ex.Message);
                }
            }
            return false;
        }
        public bool ValidateEmail(List<string> emailAddress)
        {
            if (emailAddress.TrueForAll(a => a.Contains("^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$")))
            {
                return true;
            }
            else
            {
                try
                {
                    if (emailAddress.Exists(a => a.Equals(null)))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.NULL_MESSAGE, "Email cannot be null");
                    }
                    else if (emailAddress.Exists(a => a.Equals("")))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.EMPTY_MESSAGE, "Please enter a value");
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid email address");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception : {0}", ex.Message);
                }               
            }
            return false;
        }
        public bool ValidatePhone(List<string> phoneNumber)
        {
            if (phoneNumber.TrueForAll(a => a.Contains("^[1-9]{2}[1-9][0-9]{9}?")))
            {
                return true;
            }
            else
            {
                try
                {
                    if (phoneNumber.Exists(a => a.Equals(null)))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.NULL_MESSAGE, "Phone number cannot be null");
                    }
                    else if (phoneNumber.Exists(a => a.Equals("")))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.EMPTY_MESSAGE, "Please enter a value");
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid phone number");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception : {0}", ex.Message);
                }
            }
            return false;
        }
        public bool ValidatePassword(List<string> passWord)
        {
            if (passWord.TrueForAll(a => a.Contains("(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%&()!+-]).{8,}?")))
            {
                return true;
            }
            else
            {
                try
                {
                    if (passWord.Exists(a => a.Equals(null)))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.NULL_MESSAGE, "Password cannot be null");
                    }
                    else if (passWord.Exists(a => a.Equals("")))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.EMPTY_MESSAGE, "Please enter a value");
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid phone number");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception : {0}", ex.Message);
                }
            }
            return false;
        }
    }
}
