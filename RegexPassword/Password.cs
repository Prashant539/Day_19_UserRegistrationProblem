using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPassword
{
     public class Password
    {
        public static string REGEX_Password = "^[a-z]{8,}$";
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_Password);
        }
    }
}
