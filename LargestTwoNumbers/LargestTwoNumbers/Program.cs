using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring the variables
            int counter = 0;
            int number = 0;
            int largest = 0;
            int largestTwo = 0;

            //Loop
            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Input a number");
                number = Convert.ToInt32(Console.ReadLine());

                if (counter == 0)
                    largest = number;
                else if (counter == 1)
                {
                    if (number > largest)
                        largestTwo = number;
                    else
                    {
                        largestTwo = largest;
                        largest = number;
                    }
                }
                else
                {
                    if (number > largest && number > largestTwo)
                    {
                        largest = largestTwo;
                        largestTwo = number;
                    }
                    if (number > largest && number < largestTwo)
                        largest = number;
                }
            }

            Console.WriteLine("These are the largest numbers: {0} and {1}", largest, largestTwo);


        }
    
    }
}
