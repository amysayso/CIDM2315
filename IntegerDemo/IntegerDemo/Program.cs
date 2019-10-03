using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare our variables
            int number1, number2, number3;
            string userName = "John";
            int age = 19;
            int grade = 90;
            int sum, subtract, multiply, divide, remainder;


            /* This program will ask the user to input a bunch 
             * of numbers. Then we will do some arithmetic to them.
             * This is a big multi line comment
             */
            Console.Write("Please enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a 2nd number: ");
            number2= int.Parse(Console.ReadLine());

            Console.Write("Please enter a 3rd number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2 + number3;
            subtract = number1 - number2 - number3;
            multiply = number2 * number3;
            // Division is INTEGER DIVISION.
            // This will ignore fractions, decimals
            // Returns just the whole number
            divide = number1 / number2;
            remainder = number1 % number2;
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Difference: {0}", subtract);
            Console.WriteLine("Multiply: {0}", multiply);
            Console.WriteLine("Division: {0}\nRemainder: {1}", divide, remainder);

            //Console.WriteLine("Hello {0}. You are {1} years old and your grade is {2}.", userName, age, grade);

            if (number1 == 10)
            {   Console.WriteLine("You guessed the winning number! It is 10");
                Console.WriteLine("This is still inside the if statement");

            }

            if (number1 < number2)
                Console.WriteLine("Number1 is less than number2");
        }
    }
}
