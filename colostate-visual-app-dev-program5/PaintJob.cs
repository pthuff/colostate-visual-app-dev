/*
 * Date:            September 12, 2018
 * ModifiedL        September 13,2018
 * Developed By:    Paul Huff
 * Class Name:      PaintJob
 * Description:     Class for calculating the cost of a vehicle paint job
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHuffProgram5
{
    public class PaintJob
    {
        //Method to calculate the cost of a paint job
        public double CalculateEstimate(int squareFootage, double paintCost)
        {
            //Constants and variable

            const double laborSquareFootage = 2.80;
            const int gallonOfPaint = 325;

            double dblEstimate;

            //Calculate cost

            dblEstimate = ((squareFootage / gallonOfPaint) * paintCost) + (squareFootage * laborSquareFootage);

            //Return value

            return dblEstimate;
        }
    }
}
