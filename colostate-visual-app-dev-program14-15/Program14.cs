/*
 * Project:         Assignment Set 6 - Program 14
 * Date:            October 2018
 * Modified:        Nov 14, 2018 by Paul Huff
 * Developed By:    LV
 * Class Name:      Program14 - Presentation Layer
 * Purpose:         Create and use StockAnalyzer Class
 * Uses:            StockAnalyzer class
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS605AS6
{
    public partial class Program14 : Form
    {

        #region "Done"

        //declare class level object variable

        private StockAnalyzer aAnalyzer;

        public Program14()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // assign ticker symbol to symbol

            string symbol = txtSymbol.Text;

            string[] stringPrices = txtPrices.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            decimal[] prices = Array.ConvertAll(stringPrices, decimal.Parse);

            // instantiate StockAnalyzer object

            aAnalyzer = new StockAnalyzer(symbol, prices);

            // disable/enable controls

            grpStockInfo.Enabled = false;
            grpAnalysis.Enabled = true;
        }
        
        #endregion

        #region "To Do"

        // complete this method

        // call the FindSmallestPriceChange method 
        // format and display the returned result in lblSmallest

        private void btnSmallest_Click(object sender, EventArgs e)
        {
            //Call FindSmallestPriceChange method and return value to label
            lblSmallest.Text = aAnalyzer.FindSmallestPriceChange().ToString("c");
        }

        // complete this method

        // call the FindLargestPercentagePriceChange method 
        // display the returned result in lblLargest

        private void btnLargest_Click(object sender, EventArgs e)
        {
            //Call FindLargestPercentagePriceChange method and return value to label
            lblLargest.Text = aAnalyzer.FindLargestPercentagePriceChange();
        }

        // complete this method

        // call the FindNumTimesPositivePriceChange method 
        // display the returned result in lblPositive

        private void btnPositive_Click(object sender, EventArgs e)
        {
            //Call FindNumTimesPositivePriceChange method and return value to label
            lblPositive.Text = aAnalyzer.FindNumTimesPositivePriceChange().ToString();
        }

        // complete this method

        // call the FindLongestPriceDeclineStreak method 
        // display the returned result in lblLongest

        private void btnLongest_Click(object sender, EventArgs e)
        {
            //Call FindLongestPriceDeclineStreak method and return value to label
            lblLongest.Text = aAnalyzer.FindLongestPriceDeclineStreak().ToString();
        }
        #endregion

        #region "Done"
        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            txtSymbol.Clear();
            txtPrices.Clear();

            // set text property of each label in Analysis groupbox to null

            foreach (Control aControl in grpAnalysis.Controls)
            {
                if (aControl is Label)
                    aControl.Text = null;
            }

            // enable/disable controls

            grpStockInfo.Enabled = true;
            grpAnalysis.Enabled = false;

            // set focus

            txtSymbol.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // declare variable of type DialogResult

            DialogResult aResult;

            // assign the return value to the variable

            aResult = MessageBox.Show("Do you wish to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // take action based on the value of aResult

            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtSymbol.Focus();
            }
            #endregion
        }
    }
}
