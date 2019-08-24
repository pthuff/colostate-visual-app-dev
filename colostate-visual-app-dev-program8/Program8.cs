/*
 * Date:            September 18, 2018
 * Modified:        September 25,2018
 * Developed By:    Paul Huff
 * Class Name:      Program8
 * Description:     Form class for calculating/displaying a weekly pay stub and pay summary
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

namespace PHuffProgram8
{
    public partial class Program8 : Form
    {
        //Declare form class
        public Program8()
        {
            InitializeComponent();
        }

        private void buttonPayStub_Click(object sender, EventArgs e)
        {
            //Declare local variables
            string nameOfEmployee;
            decimal weeklyHours, rateOfPay, aCalculatePay;

            PayStub aPayStub;

            // Assign variable values
            nameOfEmployee = textBoxName.Text;

            weeklyHours = numericUpDownHours.Value;
            rateOfPay = numericUpDownRate.Value;

            //Instatiate new PayStub object and pass variables
            aPayStub = new PayStub(nameOfEmployee, weeklyHours, rateOfPay);

            //Assign aCalculatePay variable
            aCalculatePay = aPayStub.NetPay;

            //Display result in label
            labelPay.Text = aCalculatePay.ToString("c2");

            //Disable controls
            groupBoxCalculate.Enabled = false;
            buttonPayStub.Enabled = false;
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            //Prepare summary message to dispaly to message box
            string stringMessage = $" Total Number of Pay Stubs: {PayStub.TotalPayStubs.ToString("n0")} \n Total Net Pay: {PayStub.TotalNetPay.ToString("c2")} \n Average Net Pay: {PayStub.CalculateAverageNetPay().ToString("c2")}";

            //Display the message box
            MessageBox.Show(stringMessage, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Reset form
            textBoxName.Clear();
            numericUpDownHours.Value = 0;
            numericUpDownRate.Value = 0;
            labelPay.Text = null;

            //Enable controls
            groupBoxCalculate.Enabled = true;
            buttonPayStub.Enabled = true;

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
