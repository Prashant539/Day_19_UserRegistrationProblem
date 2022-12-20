using System;
namespace PasswordNumericNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.validatePasswordNumber("Prashant5"));
        }
    }
}
