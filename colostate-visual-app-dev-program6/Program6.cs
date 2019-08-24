/*
 * Date:            September 18, 2018
 * Modified:        September 19,2018
 * Developed By:    Paul Huff
 * Class Name:      Program6
 * Description:     Form class for calculating the distance of a walk
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

namespace PHuffProgram6
{
    public partial class Program6 : Form
    {
        //Declare form class
        public Program6()
        {
            InitializeComponent();
        }

        private void buttonWalk_Click(object sender, EventArgs e)
        {
            // Declare local variables
            string walkerName;
            int stepsCount, stepLength;
            double aDistance;

            Walk aWalk;

            //Assign variable values
            walkerName = textBoxName.Text;

            stepsCount = Convert.ToInt32(numericUpDownStep.Value);
            stepLength = Convert.ToInt32(numericUpDownLength.Value);

            //Instatiate new Walk object and pass variables
            aWalk = new Walk(walkerName, stepsCount, stepLength);

            //Call miles walked calculation method
            aDistance = aWalk.CalculateMilesWalked();

            //Display result
            labelDistance.Text = aDistance.ToString("n2") + " Miles";

            //Disable controls
            labelName.Enabled = false;
            labelSteps.Enabled = false;
            labelLength.Enabled = false;
            textBoxName.Enabled = false;
            numericUpDownStep.Enabled = false;
            numericUpDownLength.Enabled = false;
            buttonWalk.Enabled = false;
            buttonReset.Enabled = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Reset form
            textBoxName.Clear();
            numericUpDownStep.Value = 0;
            numericUpDownLength.Value = 0;
            labelDistance.Text = null;

            //Enable controls
            labelName.Enabled = true;
            labelSteps.Enabled = true;
            labelLength.Enabled = true;
            textBoxName.Enabled = true;
            numericUpDownStep.Enabled = true;
            numericUpDownLength.Enabled = true;
            buttonWalk.Enabled = true;
            buttonReset.Enabled = true;
            

            //Focus
            textBoxName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Close the application
            this.Close();
        }
    }
}
