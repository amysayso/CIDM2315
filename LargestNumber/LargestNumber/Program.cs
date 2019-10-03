using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring the variables
            int counter = 0;
            int number = 0;
            int largest = 0;

            //Loop
            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Input a number");
                number = Convert.ToInt32(Console.ReadLine());

                if (counter==0)
                {
                    largest = number;
                }
                else
                {
                    if (number > largest)
                        largest = number; 
                           
                }

            }
            Console.WriteLine("The largest number is : {0}", largest);

            
        }
    }
}
