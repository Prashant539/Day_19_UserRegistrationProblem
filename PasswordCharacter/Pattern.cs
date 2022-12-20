using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordCharacter
{
    public class Pattern
    {
        public static string REGEX_PASSWORD1SPECIALCHAR = "^[A-Z]{1}[a-z]{2,8}[0-9]{3,5}[@]$";
        public bool validatePassword1SpecialChar(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD1SPECIALCHAR);
        }
    }
}
