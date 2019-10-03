using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop w/ break statement
            /*
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("{0}", i);
                if (i == 5) break;
            }
            Console.WriteLine("Loop Over");
            */

            //for loop w/ continue statement
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", i);
                if (i == 5) continue;
            }
            Console.WriteLine("Loop Over");

            //sum even number
            /*
             * int i= 0
            i++;
            i += 1;
            i = i + 1
            */

            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i);    
            }

            /*
            int grade;
            grade = 50;
            string result;

            /*result = grade >= 60 ? "passed" : "failed"; :Ternary Operator
             * You could add the Ternary Operator into the Console WriteLine or as a variable
             

            Console.WriteLine(grade >= 60 ? "passed" : "failed");
            */


        }
    }
}
