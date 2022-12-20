using System;
namespace UserMobileNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileNumber mobileNumber = new MobileNumber();
            Console.WriteLine(mobileNumber.validateMobileNumber("91 9838084421"));
        }
    }
}
