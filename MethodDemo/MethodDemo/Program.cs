using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static int myGlobalVariable = 50;
        static int MyMethod(string a, int b)
        {
            string extraVariable = "CIDM 2315";
            a = a + "(Modified by MyMethod)";
            b = b + 1;
            myGlobalVariable = 100;
            Console.WriteLine("Inside MyMethod: a: {0}, b: {1}", a, b);
            Console.WriteLine("MyGlobalVariable :{0}", myGlobalVariable);
            return b;
        }


        static int Square(int intValue) //square the number
        {
            return intValue * intValue;
        }

        static double Square(double dblValue)
        {
            return dblValue * dblValue;
        }

        static int Power(int baseValue, int exponentValue = 2)
        {
            Console.WriteLine("base: {0} exponent: {1}", baseValue, exponentValue);
            return 0; 
        }
        // void= no return
        static void PrintTime(int hour = 0, int minute = 0, int second = 0)
        {
            Console.WriteLine("hour: {0}, minute: {1}, second: {2}", hour, minute, second);
        }

        static void Mystery(ref string aMystery)
        {
            aMystery += " (Modified by Mystery Function)";
            Console.WriteLibe("aMystery inside mystery: {0}", aMystery);
            return 0;
        }

        static void Main(string[] args)
        {
            string aMain = "Hello";
            Console.WriteLine("aMain before: {0}", aMain);
            Mystery(ref aMain);
            Console.WriteLine("aMain after: {0}", aMain);



            PrintTime(10, 11, 12);
            PrintTime();
            PrintTime(2);
            PrintTime(minute :10, secibd: 50); //named parameters

            

            int variable = Power(10);
            variable = Power(10, 3);

            int result;
            result = Square(10);
            Console.WriteLine("Result: {0}", result);
            //method overloading
            double dblResult;
            dblResult = Square(10.5);
            Console.WriteLine("Double Result: {0}", dblResult);

            Math.Min(10, 2);
            Math.Min(10.5, 10.6);
            
            
            
            /*
            string a = "Hello";
            int b = 1;
            int returnValue;
            string extraVariable = "Main Variable";
            

            returnValue = MyMethod(a, b);
            Console.WriteLine("Back in main: return value= {0}, a={1}, b={2}", returnValue, a, b);
            Console.WriteLine(extraVariable);

            for (int i=0; i<10; i++)
            {
                for (int j=0; j <10; j++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                }
                Console.WriteLine(i);
            }

            //i= i + 2;
            */
        }
    }
}
