using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.8

            //a) Display the value of the element of character array f with index 6
            Console.Write(f[6]);

            //b)Initialize each of the five element of one-dimensional integer array g to 8
            int[] g = { 8, 8, 8, 8, 8 };


            //c) Total the 100 elements of floating-point array c

            float[] c = new float[100];
            c[0] = 20; //index = 0, element or value = 20
            c[5] = 42; //index = 5, element = 42
            float total = 0; 

            for (int i=0; i< c.Length; i++)
            {
                //index vs. element
                // index is always the nubmer in the square brackets
                total += c[i]; 
            }
            Console.WriteLine("{0}", total);

            //d) Copy 11-element array a into the first portion of array b, which contains 34 elements
            int []a = new int[11];
            int[] b = new int[34];

            for (int i = 0; i < a.Length; i++)
                b[i] = a[i];


            //e) Determine and display the smallest and largest values contained in 99-element floating-point array w
            
            double min = w[0];
            double max = w[0];
            
            foreach (double x in w)
            {
                if (x < min)
                {
                    min = x;
                }
                else (x > max)
                {
                    max = x;
                }
            }

            //8.11

            //a) Set the three elements of intergers array counts to 0
            int[] myArray = new int[3];
            for (int i=0; i<0; i++)
            {
                Console.WriteLine();
            }

            //b)  Add 1 to each of the four elements of integer array bonus

            //c) Display the five values of integers array bestScores in column format


        }
    }
}
