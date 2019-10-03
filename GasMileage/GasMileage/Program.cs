using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            int milesDriven;
            int gallonsUsed;
            double milesPerGallon;
            double combinedMilesPerGallon;
            int combinedMilesDriven = 0;
            int combinedGallonUsed= 0;
            

            // STEP 1: Promt the user first with sentinel
            Console.Write("How many miles did you drive? (-1 to quit)");
            milesDriven = Convert.ToInt32(Console.ReadLine());

            //STEP 2: Setup Loop with condition
            while (milesDriven != -1)
            {

                Console.Write("How many gallons were used?");
                gallonsUsed = Convert.ToInt32(Console.ReadLine());

                milesPerGallon = (double)milesDriven / (double)gallonsUsed;
                combinedMilesDriven += milesDriven;
                combinedGallonUsed += gallonsUsed;
                combinedMilesPerGallon = (double)combinedMilesDriven / (double)combinedGallonUsed;
                Console.WriteLine("Miles per gallon for current trip: {0}", milesPerGallon);
                Console.WriteLine(" Combined Miles per gallon across all trips: {0}, combinedMilesPerGallon");

                //STEP 3: Start next iteration of loop
                //Ask user inital question again
                Console.Write("How many miles did you drive? (-1 to quit)");
                milesDriven = Convert.ToInt32(Console.ReadLine());
            }
        }
    } 
}
