using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //row loop is outside
            for (int row = 1; row <= 20; row++)// outside forloop needs a counter variable
            {
                //column is nested
                for(int col=1; col <= 10; col++)
                {
                    Console.WriteLine("{0}",row * col);
                }
                Console.WriteLine();
            }
        }
    }
}
