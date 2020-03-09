using System;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value: ");
            string fLine = Console.ReadLine();
            double fValue = Convert.ToInt32(fLine);
            Console.WriteLine("Enter the second value: ");
            string sLine = Console.ReadLine();
            double sValue = Convert.ToInt32(sLine);
            double resMult = fValue * sValue;
            double resPow = Math.Pow(resMult, 3);
            Console.WriteLine("Result of Multiplication: " + resMult.ToString());
            Console.WriteLine("Result of Exponentiation: " + resPow.ToString());
        }
    }
}