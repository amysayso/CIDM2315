using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //8 Bits. 0-255
            byte x;

            //x= 256
            int y = 256;

            //Casting 
            x = (byte)y;

            //Console.WriteLine("Integer : y={0} Byte: x= {1}", y, x);

            double z = 3 / 5;
            Console.WriteLine("Z: {0}", z);

            int a = 3;
            int b = 5;
            z = (double)a / (double)b;
            Console.WriteLine("Z: {0}", z);
        }
    }
}
