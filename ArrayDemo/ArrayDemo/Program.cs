using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static int Sum(int[] a)
        {
            int total = 0;
            foreach (int element in a)
            {
                total += element;
            }
            return total;
        }
        static void Main(string[] args)
        {
            //ARRAYS

            int myVariable;
            int[] myArray = new int[12];
            //Array.Resize(ref myArray, 200); // build a brand new array or change the size of the array

            //string[] arrayOfStrings = new string[5];

            //initalizer list
            string[] arrayOfStrings = { "Hello", "good morning", "Good bye", "good evening", "goodnight" };

            myArray[4] = 20;
            // myArray[0], myArray[1], myArray[2], myArray[3], myArray[4]
            Console.WriteLine("myArray[4]: {0}", myArray[4]);
            Console.WriteLine("arrayOfStrings[1]: {0}", arrayOfStrings[1]);

            Console.WriteLine("myArray.Length: ", myArray.Length); // tell you the value/length of the array
            Console.WriteLine("arrayOfStrings.Length: ", arrayOfStrings.Length);

            // iterate with for loop
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = 10; // to set the array equal to 10
                Console.WriteLine("myArray[{0}]: {1}", i, myArray[i]);
            }

            // interate with foreach
            //read the value or use math , and not changing the value
            myArray[5] = 25;
            foreach (int element in myArray)
            {

                Console.WriteLine("element: {0}", element);
            }

            foreach (string element in arrayOfStrings)
            {
                Console.WriteLine(element);
            }
            
            //use this when user input
            Console.Write("Enter a number: ");

            try
            {
                myArray[0] = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You did not enter an integer. Please try again");
            }
        }
    }
}
