/*
 * Date:            September 18, 2018
 * Modified:        September 19,2018
 * Developed By:    Paul Huff
 * Class Name:      Program7
 * Description:     Form class for calculating the charge of a rental car
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

namespace PHuffProgram7
{
    public partial class Program7 : Form
    {
        //Declare form class
        public Program7()
        {
            InitializeComponent();
        }

        private void buttonCharge_Click(object sender, EventArgs e)
        {
            // Declare local variables
            string customerName;
            int beginOdo, endOdo, daysRented;
            decimal aCalculateCharge;

            CarRental aCarRental;

            //Assign variable values and convert values
            customerName = textBoxName.Text;

            beginOdo = Convert.ToInt32(numericUpDownBeginOdo.Value);
            endOdo = Convert.ToInt32(numericUpDownEndOdo.Value);
            daysRented = Convert.ToInt32(numericUpDownDays.Value);

            //Instatiate new CarRental object and pass variables
            aCarRental = new CarRental(customerName, endOdo, beginOdo, daysRented);

            //Assign charge variable
            aCalculateCharge = aCarRental.RentalCharge;

            //Display result
            labelCharge.Text = aCalculateCharge.ToString("c2");

            //Disable Controls
            groupBoxRental.Enabled = false;
            buttonCharge.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Reset form
            textBoxName.Clear();
            numericUpDownBeginOdo.Value = 0;
            numericUpDownEndOdo.Value = 0;
            numericUpDownDays.Value = 0;
            labelCharge.Text = null;

            //Enable controls
            groupBoxRental.Enabled = true;
            buttonCharge.Enabled = true;

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
