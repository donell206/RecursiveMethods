using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number pls...");
            string inputSecondNumber = Console.ReadLine();
            IsNumber(inputSecondNumber);
        }

        static bool IsNumber(string value)
        {
            int number;
            if (int.TryParse(value, out number ))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Not a valid number");
                return false;
            }
        }
    }
}
