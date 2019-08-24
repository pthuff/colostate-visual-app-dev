/*
 * Date:            October 3, 2018
 * Modified:        October 9,2018
 * Developed By:    Paul Huff
 * Class Name:      PropertTax
 * Description:     Class for constructing PropertyTax and calculate a property's tax
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHuffProgram10
{
    //Declare LocationType enumration
    public enum LocationType
    {
        Urban,
        Suburban,
        Rural
    }

    //Declare class
    class PropertyTax
    {
        //Declare read-only fields
        private readonly LocationType PropertyLocation;
        private readonly int LandSquareFootage, BuildingSquareFootage, YearBuilt;
        private readonly string PropertyOwnerName;

        //Declare auto-implmented public properties
        public int BuildingAge { get; private set; }
        public decimal BuildingTax { get; private set; }
        public decimal BuildingTaxDeduction { get; private set; }
        public decimal LandTax { get; private set; }
        public decimal LandTaxDeduction { get; private set; }
        public decimal TotalPropertyTax { get; private set; }

        //Declare constructor with paramaters
        public PropertyTax (string ownerName, int buildingSize, int landSize, int yearBuilt, LocationType whereLocated)
        {
            //Assign parameters
            PropertyOwnerName = ownerName;
            BuildingSquareFootage = buildingSize;
            LandSquareFootage = landSize;
            YearBuilt = yearBuilt;
            PropertyLocation = whereLocated;
            //Set building age
            BuildingAge = (DateTime.Now.Year - YearBuilt);
            //Call method to calculate total property tax
            CalcTotalPropertyTax();
        }

        //Private method to calculate building tax
        private void CalcBuildingTax()
        {
            //Set building tax value
            if (BuildingSquareFootage >= 1 && BuildingSquareFootage <= 1000)
            {
                BuildingTax = (0.62m * BuildingSquareFootage);
            }
            else if (BuildingSquareFootage >= 1001 && BuildingSquareFootage <= 2000)
            {
                BuildingTax = 620.00m + (0.64m * Convert.ToDecimal(BuildingSquareFootage - 1000m));
            }
            else if (BuildingSquareFootage >= 2001 && BuildingSquareFootage <= 3000)
            {
                BuildingTax = 1260.00m + (0.66m * Convert.ToDecimal(BuildingSquareFootage - 2000m));
            }
            else if (BuildingSquareFootage >= 3001 && BuildingSquareFootage <= 4000)
            {
                BuildingTax = 1920.00m + (0.68m * Convert.ToDecimal(BuildingSquareFootage - 3000m));
            }
            else if (BuildingSquareFootage > 4000)
            {
                BuildingTax = 2600.00m + (0.70m * Convert.ToDecimal(BuildingSquareFootage - 4000m));
            }
        }

        //Private method to calculate building tax deduction
        private void CalcBuildingTaxDeduction()
        {
            BuildingTaxDeduction = ((BuildingTax * 0.005m) * (DateTime.Now.Year - YearBuilt));
        }

        //Private method to calculate land tax
        private void CalcLandTax()
        {
            //Set land tax value
            if (LandSquareFootage >= 1 && LandSquareFootage <= 10000)
            {
                LandTax = (0.03m * LandSquareFootage);
            }
            else if (LandSquareFootage >= 10001 && LandSquareFootage <= 20000)
            {
                LandTax = 300.00m + (0.05m * Convert.ToDecimal(LandSquareFootage - 10000m));
            }
            else if (LandSquareFootage >= 20001 && LandSquareFootage <= 30000)
            {
                LandTax = 800.00m + (0.07m * Convert.ToDecimal(LandSquareFootage - 20000m));
            }
            else if (LandSquareFootage >= 30001 && LandSquareFootage <= 40000)
            {
                LandTax = 1500.00m + (0.09m * Convert.ToDecimal(LandSquareFootage - 30000m));
            }
            else if (LandSquareFootage > 40000)
            {
                LandTax = 2400.00m + (0.11m * Convert.ToDecimal(LandSquareFootage - 40000m));
            }
        }

        //Private method to calculate land tax deduction
        private void CalcLandTaxDeduction()
        {
            if (LandSquareFootage <= 25000m)
            {
                LandTaxDeduction = (LandTax * 0.02m);
            }
            else if (LandSquareFootage > 25000m)
            {
                LandTaxDeduction = (LandTax * 0.01m);
            }
        }

        //Private method to calculate total tax
        private void CalcTotalPropertyTax()
        {
            //Call calculate tax methods
            CalcBuildingTax();
            CalcLandTax();
            
            //Call calculate building tax deduction method
            if ((DateTime.Now.Year - YearBuilt) > 10)
            {
                CalcBuildingTaxDeduction();
            }

            //Call calculate land tax deduction method
            if (PropertyLocation == LocationType.Rural)
            {
                CalcLandTaxDeduction();
            }

            //Calculate total tax
            TotalPropertyTax = (((BuildingTax + LandTax) - BuildingTaxDeduction) - LandTaxDeduction);
        }
    }
}
