/*
 * Date:            November 26, 2018
 * Modified:        November 30, 2018
 * Developed By:    Paul Huff
 * Class Name:      CharterManager
 * Description:     Class for managing a collection of charter objects
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PhuffProgram16
{
    class CharterManager
    {
        //Declare auto-implmented public properties
        public static BindingList<Charter> CharterList { get; private set; }

        //Declare constructor and instatiate charter list
        public CharterManager()
        {
            CharterList = new BindingList<Charter>();
        }

        //Method to add charter object to the charter collection
        public void AddCharter(string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            Charter aCharter = new Charter(customerName, yachtType, yachtSize, charterHours);

            CharterList.Add(aCharter);
        }

        //Method to find lowest charter fee
        public static decimal FindLowestCharterFee()
        {
            //Declare local variables
            decimal lowFee = decimal.MaxValue;

            //Loop to find lowest fee
            foreach (Charter aCharter in CharterList)
            {
                if (aCharter.CharterFee < lowFee)
                {
                    lowFee = aCharter.CharterFee;
                }
            }

            //Return the value
            return lowFee;
        }

        //Method to sum all charter fees
        public static decimal GetTotalCharterFees()
        {
            //Declare local variables
            decimal total = 0m;

            //Loop to find total fees
            foreach (Charter aCharter in CharterList)
            {
                total += aCharter.CharterFee;
            }

            //Return the value
            return total;
        }

        //Method to find average charter fee
        public static decimal GetAverageCharterFee()
        {
            //Declare local variables
            decimal average = 0m;
            decimal total = GetTotalCharterFees();

            //Calculate average charter fee
            average = total / CharterList.Count;

            //Return the value
            return average;
        }

        //Method to find number of charters for yacht size
        public int GetCharterCount(int yachtSize)
        {
            //Declare local variable
            int charterCount = 0;

            //Loop to compare and count specific yachtsize
            foreach (Charter aCharter in CharterList)
            {
                if (aCharter.YachtSize == yachtSize)
                {
                    ++charterCount;
                }
            }

            //Return the value
            return charterCount;
        }
    }      
}
