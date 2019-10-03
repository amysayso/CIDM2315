using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // make new Random object

            Random randomNumber = new Random();
            Random randomNumber2 = new Random();
            Random randomNumber3 = new Random();

            int randomValue1 = randomNumber.Next();
            int randomValue2 = randomNumber.Next();
            Console.WriteLine("Random Value: {0}", randomValue1);
            Console.WriteLine("Random Value: {0}", randomValue2);

            int randomValue3 = randomNumber.Next(6);
            Console.WriteLine("Random Value: {0}", randomValue3);
            int randomValue4 = randomNumber.Next(10, 20);
            Console.WriteLine("Random Value: {0}", randomValue4);

        }
    }
}
