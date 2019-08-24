/*
 * Date:            October 16, 2018
 * Modified:        October 19,2018
 * Developed By:    Paul Huff
 * Class Name:      Projectile
 * Description:     Class for calculating the height and drop rate of a prjectile thrown straight up
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHuffProgram12
{
    class Projectile
    {

        //Declare auto-implmented public properties
        public int InitialHeight { get; private set; }
        public int InitialVelocity { get; private set; }
        public double LandTime { get; private set; }
        public double MaxHeight { get; private set; }

        //Declare constructor with parameters
        public Projectile(int initialHeight, int initialVelocity)
        {
            //Assign parameters to properties
            InitialHeight = initialHeight;
            InitialVelocity = initialVelocity;

            //Call methods
            CalcMaxHeight();
            CalcLandTime();
        }

        //Method to calculate height after a period of seconds
        private double FindHeight(double atTime)
        {
            //Declare local variables
            double height;

            //Calculate height
            height = (InitialHeight + (InitialVelocity * atTime) - (16 * (Math.Pow(atTime, 2))));

            //Return Value
            return height;
        }

        //Method to calculate the max height reached
        private double CalcMaxHeight()
        {
            //Declare local variables
            double maxHeight;
            double maxTime = (InitialVelocity / 32);

            //Calculate max height
            maxHeight = FindHeight(maxTime);

            //Assign to public property
            MaxHeight = maxHeight;

            //Return the value
            return MaxHeight;
        }

        //Method to calculate the land time
        private double CalcLandTime()
        {
            //Declare local variables
            double landTime = 0.10;

            //Calculate land time
            while (FindHeight(landTime) > 0)
            {
                landTime += 0.10;
            }
            //Assign to public property
            LandTime = landTime;

            //Return value
            return LandTime;
        }
    }
}
