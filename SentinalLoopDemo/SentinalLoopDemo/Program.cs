using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentinalLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 0;
            // STEP 1: Prompt user for first input before LOOP
            Console.Write("Enter Grade (-1 to quit): ");
            int grade = Convert.ToInt32(Console.ReadLine());

            while (grade != -1) //STEP 2: Condition check sentinel
            {
                total += grade;
                    //STEP 3: 
                    Console.Write("Enter grade (-1 to quit): ");
                grade = Convert.ToInt32(Console.ReadLine());
;            }
        }
    }
}
