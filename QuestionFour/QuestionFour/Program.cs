using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *This program will ask the user for five input
             * and will calculate the sum, average, product
             * and determine the smallest and greatest number
             * from what the user have input
             */

            //Declaring the variables

            int number1, number2, number3, number4, number5;
            int sum, average, product, smallest, largest;

            //Asking the user for input
            Console.WriteLine("Please enter your first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your third number: ");
            number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your fourth number: ");
            number4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your fifth number: ");
            number5 = int.Parse(Console.ReadLine());

            //formulas

            sum = number1 + number2 + number3 + number4 + number5;
            average = sum / 5;
            product = number1 * number2 * number3 * number4 * number5;

            smallest = number1;
            if (number2 < smallest)
            {
                smallest = number2;
            }
            if (number3 < smallest)
            {
                smallest = number3;
            }
            if (number4 < smallest)
            {
                smallest = number4;
            }
            if (number5 < smallest)
            {
                smallest = number5;
            }

            largest = number1;
            if (number2 > largest)
            {
                largest = number2;
            }
            if (number3 > largest)
            {
                largest = number3;
            }
            if (number4 > largest)
            {
                largest = number4;
            }
            if (number5 > largest)
            {
                largest = number5;
            }


            //Displaying the answers

            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Average: {0}", average);
            Console.WriteLine("Product: {0}", product);
            Console.WriteLine("Smallest: {0}", smallest);
            Console.WriteLine("Largest: {0}", largest);
        }
    }
}
