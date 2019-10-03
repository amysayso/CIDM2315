using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodQuiz
{
    class Program
    {
        static int globalVariable = 20;
        const int MY_GLOBAL_CONSTANT = 50;


        static int MyIntMethod(out int a, out int b, out int c)
        {
            int result = 40;
            a = 10;
            b = 20;
            c = 30;

            return result;

        }
        static void Main(string[] args)
        {
            const int MY_CONSTANT = 10;

            int a, b, c;
            int mainResult;
            mainResult = MyIntMethod(out a, out b, out c);
            Console.WriteLine("{0} {1} {2} {3}", a, b, c, mainResult); 
        }
    }
}
