using System;
namespace RegexPatternMatchingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidEmail validemail = new ValidEmail();
            Console.WriteLine(validemail.validateEmail("abc.xzy@bl.co.in"));
        }
    }
}
