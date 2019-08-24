/*
 * Date:            November 26, 2018
 * Modified:        November 30, 2018
 * Developed By:    Paul Huff
 * Class Name:      Charter
 * Description:     Class for creating a charter object and calculating a charter fee
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuffProgram16
{
    class Charter
    {
        //Declare auto-implmented public properties
        public string CustomerName { get; private set; }
        public string YachtType { get; private set; }
        public int YachtSize { get; private set; }
        public decimal CharterHours { get; private set; }
        public decimal CharterFee { get; private set; }

        //Declare constructor with parameters
        public Charter (string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            //Assign parameters to properties
            CustomerName = customerName;
            YachtType = yachtType;
            YachtSize = yachtSize;
            CharterHours = charterHours;

            //Call charter fee method
            CalcCharterFee();
        }

        //Method to calculate charter fee
        private decimal CalcCharterFee()
        {
            //Declare local variables
            decimal fee = 0m;
            const int hourly1 = 198;
            const int hourly2 = 243;
            const int hourly3 = 275;
            const int hourly4 = 361;
            const int hourly5 = 492;
            const int hourly6 = 521;
            const int hourly7 = 658;

            //Calculate fee
            if (YachtSize == 22)
            {
                fee = (hourly1 * CharterHours);
            }
            else if (YachtSize == 24)
            {
                fee = (hourly2 * CharterHours);
            }
            else if (YachtSize == 30)
            {
                fee = (hourly3 * CharterHours);
            }
            else if (YachtSize == 32)
            {
                fee = (hourly4 * CharterHours);
            }
            else if (YachtSize == 36)
            {
                fee = (hourly5 * CharterHours);
            }
            else if (YachtSize == 38)
            {
                fee = (hourly6 * CharterHours);
            }
            else if (YachtSize == 45)
            {
                fee = (hourly7 * CharterHours);
            }

            //Assign to public property
            CharterFee = fee;

            //Return the value
            return CharterFee;
        }
    }
}
