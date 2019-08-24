/*
 * Date:            September 18, 2018
 * Modified:        September 25,2018
 * Developed By:    Paul Huff
 * Class Name:      PayStub
 * Description:     Class for constructing PayStub and calculate netpay/average pay/total netpay/total pay stubs
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHuffProgram8
{
    class PayStub
    {
        //Declare read-only properties
        public readonly string EmployeeName;
        public readonly decimal HoursWorked, NetPay, PayRate;

        //Declare static auto-implemented properties
        public static decimal TotalNetPay { get; private set; }
        public static int TotalPayStubs { get; private set; }

        //Constructor with parameters and methods
        public PayStub (string employeeName, decimal hoursWorked, decimal payRate)
        {
            EmployeeName = employeeName;
            HoursWorked = hoursWorked;
            PayRate = payRate;

            //Call CalculateNetPay() method
            NetPay = CalculateNetPay();

            //Call IncrementTotals() method
            IncrementTotals();

            //Call CalculateAverageNetPay() method
            CalculateAverageNetPay();
        }

        //Private method to calculate net pay
        private decimal CalculateNetPay()
        {
            //Assign variables
            decimal GrossPay = (HoursWorked * PayRate);
            decimal FedTax = (GrossPay * .11m);
            decimal StateTax = (GrossPay * .04m);
            decimal SocialTax = (GrossPay * .062m);
            decimal MedTax = (GrossPay * .0145m);
            decimal pay;

            //Calculate the net pay
            pay = ((((GrossPay - FedTax) - StateTax) - SocialTax) - MedTax);

            //Return the value
            return pay;
        }

        //Private method to increment static properties
        private void IncrementTotals()
        {
            //Increment TotalPayStubs by 1
            TotalPayStubs++;

            //Add NetPay to TotalNetPay
            TotalNetPay += NetPay;
        }

        //Public method to calculate average net pay
        public static decimal CalculateAverageNetPay()
        {
            //Constants and variables
            decimal average;

            //Calculate the average
            average = (TotalNetPay / TotalPayStubs);

            //Return the value
            return average;
        }

    }
}
