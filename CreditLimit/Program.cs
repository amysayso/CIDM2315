using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare your variables
            int accountNumber = 0;
            double beginningBalance;
            double totalOfItems;
            double totalOfCredits;
            double newBalance = 0;
            double allowedCredit;


            Console.WriteLine("What is your account number? (-1 to quit) ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

            while (accountNumber != -1)
            {
                Console.WriteLine(" What is your beginning balance? ");
                beginningBalance = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your total of charges this month?");
                totalOfItems = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your total of credits for this month?");
                totalOfCredits = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your allowed credits? ");
                allowedCredit = Convert.ToInt32(Console.ReadLine());

                newBalance = beginningBalance + totalOfItems - totalOfCredits;

                if (newBalance > allowedCredit)
                {
                    Console.WriteLine("Credit Limit Exceeded");
                }
                else
                {
                    Console.WriteLine("Account Balance: {0}", newBalance);
                }
                Console.WriteLine("What is your account number? (-1 to quit) ");
                accountNumber = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
