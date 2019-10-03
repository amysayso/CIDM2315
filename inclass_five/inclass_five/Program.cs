using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass_five
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            switch (value % 2)
            {
                case 0:
                    Console.WriteLine("Even integer");
                    break;
                case 1:
                    Console.WriteLine("Odd integer");
                    break;
            }
        }
    }
}
