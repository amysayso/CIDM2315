using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddsorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program will determine if the user's input 
             * are odds or even
             */


            //Declaring Variables
            int number1;

            Console.WriteLine("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());

            //Classifly if it is odd or even

            if (number1 % 2 == 0)
                Console.WriteLine("This number is even");
            else if (number1 != 0)
                Console.WriteLine("This number is odd");

        }
    }
}
