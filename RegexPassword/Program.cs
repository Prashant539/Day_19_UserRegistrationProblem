using System;
namespace RegexPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password password   = new Password();
            Console.WriteLine(password.validatePassword("prashant"));
        }
       
    }
}
