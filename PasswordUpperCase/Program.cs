using System;
namespace PasswordUpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password password = new Password();
            Console.WriteLine(password.validatePasswordUpper("Prashant"));
        }
    }
}
