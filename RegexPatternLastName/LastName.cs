using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class LastName
    {
        public void UserRegistration()
        {
            Regex Lastname = new Regex("^[A-Z]{1}[a-z]{9}$");
            Console.WriteLine("Enter the last name: ");
            string LastName = Console.ReadLine();
            if (Lastname.IsMatch(LastName))
            {
                Console.WriteLine("your name is: " + LastName);

            }
            else
            {
                Console.WriteLine("your entered last name is incorrect pttern");
            }
        }
    }
}
