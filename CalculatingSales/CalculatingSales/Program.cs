using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Products: 1=$2.98, 2=$4.50,and 3=$9.98");
            Console.Write("Please enter which product: ");
            string str = Console.ReadLine();
            int productNumber;
            int quantitySold;

            
            switch (str)
            {
                case "product 1":
                    Console.WriteLine("You selected product 1");
                    break;
                case "product 2":
                    Console.WriteLine("You selected product 2");
                    break;
                case "3":
                    Console.WriteLine("You selected product 3");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3");
                    break;
            }


        }
    }
}
