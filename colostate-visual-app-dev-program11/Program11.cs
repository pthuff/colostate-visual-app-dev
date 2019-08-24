/*
 * Date:            October 16, 2018
 * Modified:        October 23,2018
 * Developed By:    Paul Huff
 * Class Name:      Program11
 * Description:     Form class for inputing a water tank's values and returning water level
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

namespace PHuffProgram11
{
    public partial class Program11 : Form
    {
        //Declare aWaterTank
        WaterTank aWaterTank;
        public Program11()
        {
            InitializeComponent();
        }

        private void buttonAdjust_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int radius, depth, addValue, drainValue;

            //Assign values to variables
            radius = Convert.ToInt32(numericUpDownRadius.Value);
            depth = Convert.ToInt32(numericUpDownDepth.Value);
            addValue = Convert.ToInt32(numericUpDownAdd.Value);
            drainValue = Convert.ToInt32(numericUpDownDrain.Value);

            //Instatiate a new WaterTank object
            aWaterTank = new WaterTank(radius, depth);

            //Check value in add/drain numeric box and return AddWater/WithdrawWater method string
            if (addValue > 0 & drainValue == 0)
            { 
                labelReturn.Text = aWaterTank.AddWater(addValue);
            }
            else if (addValue == 0 & drainValue > 0)
            {
                labelReturn.Text = aWaterTank.WithdrawWater(drainValue);
            }

            //Disable/enable controls
            numericUpDownRadius.Enabled = false;
            numericUpDownDepth.Enabled = false;
            buttonFill.Enabled = true;
            buttonDrain.Enabled = true;
            buttonReset.Enabled = true;
        }

        private void numericUpDownAdd_ValueChanged(object sender, EventArgs e)
        {
            //Clear drain value
            numericUpDownDrain.Value = 0;
        }

        private void numericUpDownDrain_ValueChanged(object sender, EventArgs e)
        {
            //Clear add value
            numericUpDownAdd.Value = 0;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int addValue = Convert.ToInt32(numericUpDownAdd.Value);

            //Verify add value has been entered
            if (addValue == 0)
            {
                MessageBox.Show("Enter number of gallons to add per second.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownAdd.Focus();
                return;
            }

            //Determine if tank will overflow
            else if (addValue > (aWaterTank.TankCapacity - WaterTank.WaterLevel))
            {
                textBoxTank.Text += $" WARNING! Tank will overflow. \r\n Current Water Level: {WaterTank.WaterLevel.ToString()} \r\n Maximum Additional Gallons: {(aWaterTank.TankCapacity - WaterTank.WaterLevel).ToString()} \r\n";
            }

            //Loop to check if water tank is at capacity and fill if not
            while (aWaterTank.FillTank(addValue) == true)
            {
                aWaterTank.AddWater(addValue);
                textBoxTank.Text += $" Water Level: {WaterTank.WaterLevel.ToString()}" + "\r\n";

                //Tank full
                if (aWaterTank.FillTank(addValue) == false)
                {
                    textBoxTank.Text += $" Tank Full \r\n";
                }
            }

            //Scroll to end
            textBoxTank.AppendText("\r\n");
        }

        private void buttonDrain_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int drainValue = Convert.ToInt32(numericUpDownDrain.Value);

            //Verify drain value has been entered
            if (drainValue == 0)
            {
                MessageBox.Show("Enter number of gallons to drain per second.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownDrain.Focus();
                return;
            }

            //Determine if sufficient water level
            else if (drainValue > WaterTank.WaterLevel)
            {
                textBoxTank.Text += $" Insufficient water level. \r\n Maximum Allowed Gallons: {WaterTank.WaterLevel.ToString()} \r\n";
            }

            //Loop to check if water tank contains water and drain if true
            while (aWaterTank.DrainTank(drainValue) == true)
            {
                aWaterTank.WithdrawWater(drainValue);
                textBoxTank.Text += $" Water Level: {WaterTank.WaterLevel.ToString()}" + "\r\n";

                //Tank empty
                if (aWaterTank.DrainTank(drainValue) == false)
                {
                    textBoxTank.Text += $" Tank Empty \r\n";
                }
            }

            //Scroll to end
            textBoxTank.AppendText("\r\n");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Reset form
            numericUpDownRadius.Value = 0;
            numericUpDownDepth.Value = 0;
            numericUpDownAdd.Value = 0;
            numericUpDownDrain.Value = 0;
            labelReturn.Text = null;
            textBoxTank.Text = null;

            //Enable/disable controls
            numericUpDownRadius.Enabled = true;
            numericUpDownDepth.Enabled = true;
            buttonFill.Enabled = false;
            buttonDrain.Enabled = false;
            buttonReset.Enabled = false;

            //Empty water tank
            aWaterTank.WithdrawWater(WaterTank.WaterLevel);

            //Focus
            numericUpDownRadius.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Close the application
            this.Close();
        }
    }
}
