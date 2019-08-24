/*
 * Date:            September 11, 2018
 * ModifiedL        September 12,2018
 * Developed By:    Paul Huff
 * Class Name:      Investment
 * Description:     Class for calculating the future value of an invesment
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHuffProgram4
{
    public partial class Investment

        //Declare a new investment class
    {
        public double CalculateFutureValue(double valueOfInvestment, double yearsOfInvestment, double rateOfInvesment)
        {
            //Calculate and return the future value method

            return valueOfInvestment * Math.Pow((1 + rateOfInvesment / 100), yearsOfInvestment);
        }
    }
}
