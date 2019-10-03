using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 2D/ Rectangular Array 
            //best suited for formal table ( exact coulmns and rows )
            int[,] rectangularArray = new int[3, 4];
            rectangularArray[0, 0] = 10;
            rectangularArray[0, 1] = 11;
            rectangularArray[2, 3] = 20;

            // 1, 2, 3
            // 4, 5, 6
            int[,] more2D = { { 1, 2, 3 }, { 4, 5, 6 } };
            OutputArray(rectangularArray);
            OutputArray(more2D);
            Console.WriteLine();

            //jagged array
            int[][] jagged = //jagged array initalized
            {
                new int[] {1,2 },
                new int[] {3},
                new int[] {4, 5, 6},
            };

            //how to change value in a jagged array
            jagged[2][2] = 7;
            jagged[2][0] = 9;

            int[][] secondJagged = new int[3][]; //jagged array 2D 
            secondJagged[0] = new int[5];
            secondJagged[1] = new int[2];
            secondJagged[2] = new int[1];
            Console.WriteLine("Jagged:\n\n\n\n");
            OutputArray(jagged);
            OutputArray(secondJagged);
        }

        static void OutputArray(int[][] array)
        {
            // a regular for loop for jagged array

            for (int i=0; i< array.Length; i++) //jagged array = ".length" ".getLength" = rectangular array
            {
                for (int j = 0; j < array[i].Length; j++ )
                {
                    Console.Write("{0}    ", array[i][j]);
                }
                Console.WriteLine();
            }
            /*
            //int[] myArray = { 1, 2, 3 };
            //perfect way to loop in a jagged array
            foreach (int[] element in array)
            {
                foreach (int value in element)
                {
                    Console.Write("{0}    ", value);
                }
                Console.WriteLine();
            }
            */
        }
        static void OutputArray(int[,] array)
        {
            for( int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write("{0,3}  ", array[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
