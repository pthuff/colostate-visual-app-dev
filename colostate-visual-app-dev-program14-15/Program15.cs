/*
 * Project:         Assignment Set 6 - Program 15
 * Date:            October 2018
 * Modified:        Nov 14, 2018 by Paul Huff
 * Developed By:    LV
 * Class Name:      Program15 - Presentation Layer
 * Purpose:         Create and use Scorecard Class
 * Uses:            ScoreCard class
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
    public partial class Program15 : Form
    {

        #region "Done"

        //declare class level object variable

        private ScoreCard aCard;

        public Program15()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // assign player name to pName

            string pName = txtName.Text;

            // assign the four text boxes to an array
            // use a loop to process each textbox in the array

            TextBox[] roundBoxes = { txtRound1, txtRound2, txtRound3, txtRound4 };

            // a jagged array is an array of arrays
            // it is an array whose elements are arrays
            
            // use a jagged array to store the scores of each round as an array
            // create a one-dimensional array with four elements.
            // each of the four elements is also a one-dimensional array

            int[][] roundScores = new int[4][];

            for (int round = 0; round < 4; ++round)
            {
                // split each hole score in the round using tab (\t) as the split character

                string[] tempStrScores = roundBoxes[round].Text.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // convert the string array to an int and assign to roundScores array

                int[] tempIntScores = Array.ConvertAll(tempStrScores, int.Parse);

                roundScores[round] = tempIntScores;
            }

            // create a two-dimensional array with the data from the jagged array

            int[,] scoresByRound = new int[4, 18];

            for (int row = 0; row < 4; ++row)
            {
                for (int col = 0; col < 18; ++col)
                {
                    scoresByRound[row, col] = roundScores[row][col];
                }
            }

            // instantiate ScoreCard object

            aCard = new ScoreCard(pName, scoresByRound);

            // disable/enable controls

            grpScoreInfo.Enabled = false;
            grpStats.Enabled = true;
        }

        #endregion

        #region "To Do"

        // complete this method

        // call the CalcStatusAfterHole method 
        // display the returned result in lstAfterHoleStatus

        private void btnStatusAfterHole_Click(object sender, EventArgs e)
        {
            //Declare local variable
            int round = Convert.ToInt32(nudRound.Value);

            //Call CalcStatusAfterHoleMethod and return value
            lstAfterHoleStatus.DataSource = aCard.CalcStatusAfterHole(round);
        }

        // complete this method

        // call the CalcAverageScoresByPar method 
        // format and display the returned result in lblAverageScore

        private void btnAverageScore_Click(object sender, EventArgs e)
        {
            //Declare local variable
            int par = Convert.ToInt32(nudPar.Value);

            //Call CalcAverageScoresByPar and return value
            lblAverageScore.Text = aCard.CalcAverageScoresByPar(par).ToString("n3");
        }

        // complete this method

        // call the CalcPerformanceByScoreType method 
        // display the returned result in lblPerformance

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            //Call CalcPerformanceByScoreType and return value
            lblPerformance.Text = aCard.CalcPerformanceByScoreType().ToString();
        }

        #endregion

        #region "Done"
        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            foreach (Control aControl in grpScoreInfo.Controls)
            {
                if (aControl is TextBox)
                    aControl.Text = null;
            }

            lstAfterHoleStatus.DataSource = null;

            nudRound.Value = nudRound.Minimum;
            nudPar.Value = nudPar.Minimum;

            lblAverageScore.Text = null;
            lblPerformance.Text = null;

            // enable/disable controls

            grpScoreInfo.Enabled = true;
            grpStats.Enabled = false;

            // set focus

            txtName.Focus();
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
                txtName.Focus();
            }
        }

        #endregion

        private void Program15_Load(object sender, EventArgs e)
        {
            txtRound1.Text = "3	3	4	4	5	6	3	4	4	5	3	5	4	6	4	5	3	4";
            txtRound2.Text = "3	3	3	4	4	4	3	3	4	4	3	5	5	4	4	5	2	3";
            txtRound3.Text = "5	2	4	4	5	4	3	4	4	4	2	5	4	4	5	5	4	4";
            txtRound4.Text = "4	2	3	4	4	5	3	4	4	3	4	4	4	4	4	4	3	5";
        }
    }
}