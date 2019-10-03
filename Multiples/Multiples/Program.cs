using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare the variable 
            int number1;
            int number2;
            int remainder;

            Console.WriteLine("Enter the first number:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = int.Parse(Console.ReadLine());

            // Arithmetic

            remainder = number1 % number2;

            if (remainder == 0)
            Console.WriteLine("There is no remainder");
            else if (remainder != 0)
            Console.WriteLine("There is {0} remainder", remainder);

        }
    }
}
