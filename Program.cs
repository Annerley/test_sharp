using System;
using System.Globalization;

namespace test_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = Convert.ToDouble(data, numberFormatInfo);
            Console.WriteLine(a);
           }
    }
}
