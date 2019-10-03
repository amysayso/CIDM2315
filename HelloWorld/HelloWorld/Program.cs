using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // I am declaring a string variable called userName
            // in C# variables must be decleared before being used
            string userName;

            // Asking the user what is their name
            Console.WriteLine(" Hello World");
            Console.Write("Please enter your name: ");

            // the user is entering their name here
            // Thank you to the user
            userName = Console.ReadLine();
            Console.WriteLine("Thank you, {0}", userName);

            // Greeting the user to WTAMU
            Console.Write("Welcome to \nWest Texas \tA&m University");
         
            

        }
    }
}
