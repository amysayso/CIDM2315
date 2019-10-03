using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Question 1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", i);
            }

            //Question 2
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0}", i);
            }

            //Question 3
            for (int i=10; i>0; i--)
            {
                Console.WriteLine("{0}", i);
            }

            // Question 4
            for (int i=9; i>-1; i--)
            {
                Console.WriteLine("{0}", i);
            }
            

            //Question 5

            for (int i = 0; i < 20; i++)
            {
                if (i == 13) continue;
                Console.WriteLine("{0}", i);   
            }
            */

            //Question 6
            int sum = 0; 
            for (int i = 0; i < 101; i += 2)
            {
                // sum them up
                sum = sum + i;
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine("{0}",sum);

            /*
            //Question 7
            for (int i=1; i<1000; i++)
            {

            }

            //Question 8
            while ()
            {
                Console.WriteLine("Input the cost: ");
                
            }

            //Question 9
            do
            {

            } while ();

           //Question 10
           */
        }
    }
}
