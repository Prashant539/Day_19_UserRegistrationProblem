using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatchingDemo
{
    public class ValidEmail
    {
        public static string REGEX_Email = ("^[a-z]{3}.[a-z]{3}@(bl).(co).(in)$");
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_Email);
        }

    }
}
