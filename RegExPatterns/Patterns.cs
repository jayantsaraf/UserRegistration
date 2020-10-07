﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExPatterns
{
    public class Patterns
    {
        public static string REGEX_FIRST_NAME = "^[A-Z][a-z]{3,}?";
        public static string REGEX_LAST_NAME = "^[A-Z][a-z]{3,}?";
        public bool ValidateFirstName(string first)
        {
            return Regex.IsMatch(first, REGEX_FIRST_NAME);
        }
        public bool ValidateLastName(string last)
        {
            return Regex.IsMatch(last, REGEX_LAST_NAME);
        }
    }
}
