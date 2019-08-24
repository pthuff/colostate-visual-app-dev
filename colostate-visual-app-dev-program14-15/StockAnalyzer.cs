/*
 * Project:         Assignment Set 6 - Program 14
 * Date:            October 2018
 * Modified:        Nov 14, 2018 by Paul Huff
 * Developed By:    LV
 * Class Name:      StockAnalyzer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS605AS6
{
    class StockAnalyzer
    {
        #region "Property"

        public string TickerSymbol { get; private set; }
        public decimal[] StockPrices { get; private set; }

        #endregion

        #region "Constructor"

        public StockAnalyzer(string symbol, decimal[] prices)
        {
            TickerSymbol = symbol;
            
            StockPrices = prices;
        }

        #endregion

        #region "Methods"

        /* Complete this method to find and return the smallest price change (either up or down) between any two consecutive trading days.

           Price change (either up or down) between two consecutive trading days (e.g., Days 1 and 2) =
        
                    Absolute value of (Day 2 Price - Day 1 Price) 
        */

        public decimal FindSmallestPriceChange()
        {

            //Declare local variables
            decimal minChange = decimal.MaxValue;

            //Loop to find minimal difference in array and assign to variable
            for (int x = 0; x < StockPrices.Length - 1; ++x)
            {
                if (Math.Abs(StockPrices[x + 1] - StockPrices[x]) < minChange)
                    {
                        minChange = Math.Abs(StockPrices[x + 1] - StockPrices[x]);
                    }
            }             

            //Return the value
            return minChange;
        }

        /* Complete this method to find and return the largest percentage change in price between any two consecutive trading days.  
        
           The return value should be formatted to display with a % sign and 2 decimal places.

           Percentage change in price between two consecutive trading days (e.g., Days 1 and 2) =

                (Day 2 Price - Day 1 Price) / Day 1 Price
        */

        public string FindLargestPercentagePriceChange()
        {
            //Declare local variables
            string changeString = string.Empty;
            decimal maxChange = 0;

            //Loop to find maximum difference in array and assign to % string variable
            for (int x = 0; x < StockPrices.Length - 1; ++x)
            {
                if (Math.Abs(StockPrices[x + 1] - StockPrices[x]) > maxChange)
                {
                    maxChange = Math.Abs(StockPrices[x + 1] - StockPrices[x]);
                    changeString = (maxChange / StockPrices[x]).ToString("p2");
                }
            }

            //Return the value
            return changeString;

        }

        /* Complete this method to find and return the number of times there is a positive change in price  between any two consecutive trading days. 

           There is a positive change in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price > 0
        */

        public int FindNumTimesPositivePriceChange()
        {
            //Declare local variables
            int posChange = 0;

            //Loop to find number of positive changes and increment counter
            for (int x = 0; x < StockPrices.Length - 1; ++x)
            {
                if (StockPrices[x + 1] > StockPrices[x])
                {
                    ++posChange;
                }
            }

            //Return the value
            return posChange;
        }

        /* Complete this method to find and return the longest period (in days) of continuous price decline.

           There is a decline in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price < 0

        */

        public int FindLongestPriceDeclineStreak()
        {
            //Declare local variables
            int currentStreak = 0;
            int longestStreak = 0;

            //Loop to find number of positive changes and increment counter
            for (int x = 0; x < StockPrices.Length - 1; ++x)
            {
                if (StockPrices[x + 1] < StockPrices[x])
                {
                    ++currentStreak;

                    if (currentStreak > longestStreak)
                    {
                        longestStreak = currentStreak;
                    }

                    continue;
                }

                currentStreak = 0;
            }

            //Return the value
            return longestStreak;
        }
    }
        #endregion
}