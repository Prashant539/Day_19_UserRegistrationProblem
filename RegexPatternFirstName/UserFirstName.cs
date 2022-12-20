using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatching
{
    internal class UserFirstName
    {
        public void UserRegistration()
        {
            Regex Firstname = new Regex("^[A-Z]{1}[a-z]{7}$");
            Console.WriteLine("Enter FirstName: ");
            string FirstName = Console.ReadLine();
            if (Firstname.IsMatch(FirstName))
            {
                Console.WriteLine("your name is: " + FirstName);
                    


            }
            else
            {
                Console.WriteLine("your entered name is invalid pattern");
            }
        }
    }
}
