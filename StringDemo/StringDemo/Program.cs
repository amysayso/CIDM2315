using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char myChar = 'A'; //declaring a character

            char newChar = (char)('A' + 1); //using math to int values to equal a character 'B'

            //Comparing Character 
            if ( newChar > 'A')
            {
                Console.WriteLine("'{0}' is greater than 'A' ", newChar);
            }

            if('a' > 'A')
            {
                Console.WriteLine("'a' is greater than 'A' ");
            }

            //verbatim string
            string myFile = "C:\\myfolder\\test.file";

            Console.WriteLine(myFile);

            for (int i = myFile.Length -1; i>= 0; i--)
            {
                Console.WriteLine(myFile[i]);
            }
            Console.WriteLine();

            //concatenating string
            string string1 = "Happy";
            string string2 = "Birthday";

            string string3 = string1 + "\n" + string2;
            Console.WriteLine(string3);

            //Case sensitive
            string myString = "YeS";
            string myString2 = "YES";

            if (myString.ToUpper() == "YES")
            {
                Console.WriteLine("String is YES");
            }

            //trim
            string trimString = "      hello    ";
            Console.WriteLine("'{0}'", trimString);
            Console.WriteLine("'{0}'", trimString.Trim());


        }
    }
}
