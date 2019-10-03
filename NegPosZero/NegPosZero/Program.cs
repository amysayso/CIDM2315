using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegPosZero
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Writing an app that input five integers 
             * and determines and display the numbers of negative number input,
             * or if the number is a postive input and if the number is a zero input
             */

            // Declaring variables
            int number1, number2, number3, number4, number5;
            int positive = 0;
            int negative = 0;
            int zeroinput = 0;

            //Asking the users to input five integers

            Console.Write("Please enter the first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the third number: ");
            number3 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the fourth number: ");
            number4 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the fifth number: ");
            number5 = int.Parse(Console.ReadLine());

            //Seeing if the numbers are postive, negative, or zero input

            if (number1 > 0)
                positive++;
            else if (number1 < 0)
                negative++;
            else
                zeroinput++;

            if (number2 > 0)
                positive++;
            else if (number2 < 0)
                negative++;
            else
                zeroinput++;

            if (number3 > 0)
                positive++;
            else if (number3 < 0)
                negative++;
            else
                zeroinput++;

            if (number4 > 0)
                positive++;
            else if (number4 < 0)
                negative++;
            else
                zeroinput++;

            if (number5 > 0)
                positive++;
            else if (number5 < 0)
                negative++;
            else
                zeroinput++;

            Console.WriteLine("You have {0} Positive number, {1} negative number, and {2} zeros.", positive, negative, zeroinput);


        }
    }
}
