using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExPatterns
{
    public class Patterns
    {
        public static string REGEX_FIRST_NAME = "^[A-Z][a-z]{3,}?";
        public static string REGEX_LAST_NAME = "^[A-Z][a-z]{3,}?";
        public static string REGEX_EMAIL = "[a-zA-Z0-9]{3,}[+-.]?[a-zA-Z0-9]{0,}@[a-z]{2,}[.][a-z]{2,}[a-z]{0,}";
        public static string REGEX_MOBILE = "^[1-9]{2}[1-9][0-9]{9}?";
        public static string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%&()!+-]).{8,}?";
        public bool ValidateFirstName(string first)
        {
            return Regex.IsMatch(first, REGEX_FIRST_NAME);
        }
        public bool ValidateLastName(string last)
        {
            return Regex.IsMatch(last, REGEX_LAST_NAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidatePhone(string number)
        {
            return Regex.IsMatch(number, REGEX_MOBILE);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
