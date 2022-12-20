using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserMobileNumber
{
    public class MobileNumber
    {
        public static String REGEX_MobileNumber = "^[0-9]{2}[ ][0-9]{10}$";
        public bool validateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, REGEX_MobileNumber);
        }
    }
}
