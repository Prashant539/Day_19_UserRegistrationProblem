using System;
namespace PasswordCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.validatePassword1SpecialChar("Prashant805@"));
        }
    }
}
