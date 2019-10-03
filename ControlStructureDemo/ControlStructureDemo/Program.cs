using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 0;
            // STEP 1: Make a counter variable, Initialize to 0
            int gradeCounter = 0;

            while (gradeCounter < 10) //STEP 2: Loop Condition
            {
                Console.Write(" Enter grade: ");
                total += Convert.ToInt32(Console.ReadLine());
                // STEP 3: Increment the counter
                gradeCounter++;
            }

            Console.WriteLine("Total of all 10 grades : {0}", total);
        }
    }
}
