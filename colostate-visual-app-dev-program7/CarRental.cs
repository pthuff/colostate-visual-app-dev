/*
 * Date:            September 18, 2018
 * Modified:        September 19,2018
 * Developed By:    Paul Huff
 * Class Name:      CarRental
 * Description:     Class for constructing CarRental and calulating charge
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHuffProgram7
{
    class CarRental
    {
        //Declare variables
        int endOdometerReading;
        int beginOdometerReading;
        int daysRented;

        //Declare auto-implmented properties 
        public string CustomerName { get; set; }
        public decimal RentalCharge { get; private set; }

        //Declare private public accessor properties
        public int EndOdometerReading
        {
            get
            {
                return endOdometerReading;
            }
            set
            {
                endOdometerReading = value;
                CalculateRentalCharge();
            }
        }
        public int BeginOdometerReading
        {
            get
            {
                return beginOdometerReading;
            }
            set
            {
                beginOdometerReading = value;
                CalculateRentalCharge();
            }
        }
        public int DaysRented
        {
            get
            {
                return daysRented;
            }
            set
            {
                daysRented = value;
                CalculateRentalCharge();
            }
        }

        //Default constructor
        public CarRental() { }

        //Constructor with parameters
        public CarRental(string nameOfCustomer, int endMiles, int beginMiles, int numDays)
        {
            CustomerName = nameOfCustomer;
            EndOdometerReading = endMiles;
            BeginOdometerReading = beginMiles;
            DaysRented = numDays;
        }

        //Calculate rental charge method
        private void CalculateRentalCharge()
        {
            //Constants and variables
            const decimal dailyCharge = 29.5m;
            const decimal mileageCharge = 0.45m;

            decimal charge;

            //Calculate rental charge
            charge = (dailyCharge * DaysRented) + ((EndOdometerReading - BeginOdometerReading) * mileageCharge);

            //Set RentalCharge property value 
            RentalCharge = charge;
        }
    }
}