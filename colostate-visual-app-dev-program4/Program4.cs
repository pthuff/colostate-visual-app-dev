/*
 * Date:            September 11, 2018
 * ModifiedL        September 13,2018
 * Developed By:    Paul Huff
 * Class Name:      Program4
 * Description:     Form class for diplaying a form calculating the future value of an investment
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

namespace PHuffProgram4
{
    public partial class Program4 : Form

        //Declare form class
    {
        public Program4()
        {
            InitializeComponent();
        }

        private void btnFutureValue_Click(object sender, EventArgs e)
        {
            //Declare variables

            double decValue, decRate, intDuration, aFutureValue;

            //Assign variables and convert values

            decValue = Convert.ToDouble(numericValue.Value);
            intDuration = Convert.ToInt32(numericDuration.Value);
            decRate = Convert.ToDouble(numericRate.Value);

            //Instatiate a new Investment object

            Investment aInvestment = new Investment();

            //Call the future value method

            aFutureValue = aInvestment.CalculateFutureValue(decValue, intDuration, decRate);

            //Display Result

            lblFutureValueReturn.Text = aFutureValue.ToString("c2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset the form

            numericValue.Value = 0;
            numericDuration.Value = 0;
            numericRate.Value = 0;

            lblFutureValueReturn.Text = string.Empty;

            numericValue.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the program

            this.Close();
        }
    }
}
