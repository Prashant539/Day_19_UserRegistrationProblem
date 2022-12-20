using System;
namespace RegexPatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            UserFirstName userFirstName = new UserFirstName();
            userFirstName.UserRegistration();
        }
    }
}
