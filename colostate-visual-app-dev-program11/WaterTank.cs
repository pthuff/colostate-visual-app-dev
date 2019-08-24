/*
 * Date:            October 16, 2018
 * Modified:        October 23,2018
 * Developed By:    Paul Huff
 * Class Name:      WaterTank
 * Description:     Class for adding or removing water from a cylindrical tank
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHuffProgram11
{
    class WaterTank
    {
        //Declare auto-implmented public properties
        public int TankCapacity { get; private set; }
        public int TankDepth { get; private set; }
        public int TankRadius { get; private set; }
        public static int WaterLevel { get; private set; }

        //Declare constructor with parameters
        public WaterTank (int tankRadius, int tankDepth)
        {
            //Assign parameters to properties
            TankRadius = tankRadius;
            TankDepth = tankDepth;

            //Call tank capicity method
            CalcTankCapacity();
        }

        //Method to calculate maximum tank capacity
        private int CalcTankCapacity()
        {
            //Declare local variables
            double capacity;
            const double cubicFoot = 7.48;

            //Calculate the capacity
            capacity = (Math.Floor(Math.PI * (Math.Pow(TankRadius, 2)) * TankDepth) * cubicFoot);

            //Assign to public property
            TankCapacity = Convert.ToInt32(capacity);

            //Return the value
            return TankCapacity;
        }

        //Method to add water to tank
        public string AddWater(int gallonsToAdd)
        {
            //Declare local variables
            string addString;

            //Add water if not at capacity
            if (gallonsToAdd <= (TankCapacity - WaterLevel))
            {
                WaterLevel += gallonsToAdd;
                addString = $" Gallons Added: {gallonsToAdd.ToString()} \r\n Current Water Level: {WaterLevel.ToString()} \r\n Tank Capacity: {TankCapacity.ToString()}";
            }
            else
            {
                addString =  $" WARNING! Tank will overflow. \r\n Current Water Level: {WaterLevel.ToString()} \r\n Maximum Additional Gallons: {(TankCapacity - WaterLevel).ToString()}";
            }

            //Return value
            return addString;
        }

        //Method to withdraw water from tank
        public string WithdrawWater(int gallonsToWithdraw)
        {
            //Declare local variables
            string withdrawString;

            //Add water if not at capacity
            if (gallonsToWithdraw <= WaterLevel)
            {
                WaterLevel = (WaterLevel - gallonsToWithdraw);
                withdrawString = $" Gallons Drained: {gallonsToWithdraw.ToString()} \r\n Current Water Level: {WaterLevel.ToString()} \r\n Tank Capacity: {TankCapacity.ToString()}";
            }
            else
            {
                withdrawString = $" Insufficient water level. \r\n Maximum Allowed Gallons: {WaterLevel.ToString()}";
            }

            //Return value
            return withdrawString;
        }

        //Method to fill tank to capacity
        public bool FillTank(int gallonsPerSecond)
        {
            //Declare local variables
            bool fillStatus;

            //Check capacity
            if (gallonsPerSecond <= (TankCapacity - WaterLevel))
            {
                fillStatus = true;
            }
            else if (gallonsPerSecond == 0)
            {
                fillStatus = false;
            }
            else
            {
                fillStatus = false;
            }

            //Return Value
            return fillStatus;
        }

        //Method to completely drain tank
        public bool DrainTank(int gallonsPerSecond)
        {
            //Declare local variables
            bool drainStatus;

            //Check water level
            if (gallonsPerSecond <= WaterLevel)
            {
                drainStatus = true;
            }
            else if (gallonsPerSecond == 0)
            {
                drainStatus = false;
            }
            else
            {
                drainStatus = false;
            }

            //Return value
            return drainStatus;
        }
    }
}
