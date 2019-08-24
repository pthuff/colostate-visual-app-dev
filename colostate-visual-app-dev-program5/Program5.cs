/*
 * Date:            September 12, 2018
 * ModifiedL        September 13,2018
 * Developed By:    Paul Huff
 * Class Name:      Program5
 * Description:     Class form for displaying the cost of a vehicle paint job
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

namespace PHuffProgram5
{
    public partial class Program5 : Form
    {
        //Declare form class
        public Program5()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            //Declare variables

            double decCost, aEstimate;

            int intFootage;

            string strMessage;

            //Assign variables and convert

            intFootage = Convert.ToInt32(numFootage.Value);
            decCost = Convert.ToDouble(numCost.Value);

            //Instatiate a new PaintJob object

            PaintJob aPaintJob = new PaintJob();

            //Call the paint job estimate method

            aEstimate = aPaintJob.CalculateEstimate(intFootage, decCost);

            //Prepare message box

            strMessage = $"Paint Job Estimate: {aEstimate.ToString("c2")}";

            //Display the result in a message box

            MessageBox.Show(strMessage, "Paint Job Estimate", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the form

            numCost.Value = 0;
            numFootage.Value = 0;

            numCost.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the program

            this.Close();
        }
    }
}
