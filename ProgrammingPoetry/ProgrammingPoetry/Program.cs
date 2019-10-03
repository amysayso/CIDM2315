using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPoetry
{
    class Program
    {
        static void OutputArray(string[][] array)
        {
            foreach (string[] element in array)
            {
                foreach (string value in element)
                {
                    Console.Write("{0}", value);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            /*
            *To move, to breathe, to fly, to float,
            *To gain all while you give,
            *To roam the roads of lands remote,
            * To travel is to live.
            */

            string[][] jagged =
            {
               new string[] {"To move,","to breathe,", "to fly,", "to float,"},
               new string[] {"To gain all while you give," },
               new string[] {"TO roam the roads of land remote,"},
               new string[] {"To travel is to live."},
            };

            OutputArray(jagged);
            Console.WriteLine();
            Console.WriteLine("{0}", jagged[0][3]);




        }
        }
}
