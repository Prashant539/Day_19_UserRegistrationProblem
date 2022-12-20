using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordUpperCase
{
    public class Password
    {
        public static string REGEX_PasswordUpper = "^[A-Z]{1}[a-z]{2,8}$";
        public bool validatePasswordUpper(string password)
        {
            return Regex.IsMatch(password, REGEX_PasswordUpper);
        }
           
    }
}
