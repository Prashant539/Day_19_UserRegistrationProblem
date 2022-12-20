using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordNumericNumber
{
    public class Pattern
    {
        public static string REGEX_PASSWORDNUMBER = "^[A-Z]{1}[a-z]{2,8}[0-9]{1}$";
        public bool validatePasswordNumber(string passwordNumber)
        {
            return Regex.IsMatch(passwordNumber, REGEX_PASSWORDNUMBER);

        }
    }
}
