/*
 * Date:            October 3, 2018
 * Modified:        October 9,2018
 * Developed By:    Paul Huff
 * Class Name:      Program10
 * Description:     Form class for inputing a property's values and displaying the property taxes
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

namespace PHuffProgram10
{
    public partial class Program10 : Form
    {
        //Declare local variable and assign to enum
        LocationType locationType;
        public Program10()
        {
            InitializeComponent();
        }

        private void buttonTax_Click(object sender, EventArgs e)
        {
            //Verify event name has been entered
            if (textBoxName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Owner's name is required", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            //Declare local variables
            string nameOfOwner;
            int sizeOfBuilding, sizeOfLand, buildYear;

            PropertyTax aPropertyTax;

            //Assign values to variables
            nameOfOwner = textBoxName.Text;
            sizeOfBuilding = Convert.ToInt32(numericUpDownBuilding.Value);
            sizeOfLand = Convert.ToInt32(numericUpDownLand.Value);
            buildYear = Convert.ToInt32(numericUpDownYear.Value);

            //Instantiate a PropertyTax object
            aPropertyTax = new PropertyTax(nameOfOwner, sizeOfBuilding, sizeOfLand, buildYear, locationType);

            //Access CalcTotalPropertyTax method and display result
            labelResult.Text = $" Building Age: {aPropertyTax.BuildingAge.ToString("n0")} \r\n Building Tax: {aPropertyTax.BuildingTax.ToString("c2")} \r\n Land Tax: {aPropertyTax.LandTax.ToString("c2")} \r\n Building Tax Deduction: {aPropertyTax.BuildingTaxDeduction.ToString("c2")} \r\n Land Tax Deduction: {aPropertyTax.LandTaxDeduction.ToString("c2")} \r\n Total Property Tax: {aPropertyTax.TotalPropertyTax.ToString("c2")}";

            //Set result label font to bold
            labelResult.Font = new Font(labelResult.Font, FontStyle.Bold);

            //Disable controls
            groupBoxTax.Enabled = false;
            buttonTax.Enabled = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Reset form
            textBoxName.Clear();
            numericUpDownYear.Value = 1800;
            numericUpDownBuilding.Value = 0;
            numericUpDownLand.Value = 0;
            radioButtonUrban.Checked = true;
            labelResult.Text = null;

            //Enable controls
            groupBoxTax.Enabled = true;
            buttonTax.Enabled = true;

            //Focus
            textBoxName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Close the application
            this.Close();
        }

        private void numericUpDownYear_ValueChanged(object sender, EventArgs e)
        {
            //Verify building year does not exceed current value
            if (numericUpDownYear.Value > DateTime.Now.Year)
            {
                numericUpDownYear.Value = DateTime.Now.Year;
            }
        }

        private void radioButtonRural_CheckedChanged(object sender, EventArgs e)
        {
            //Assign variable to enum value
            locationType = LocationType.Rural;
        }

        private void radioButtonSuburban_CheckedChanged(object sender, EventArgs e)
        {
            //Assign variable to enum value
            locationType = LocationType.Suburban;
        }

        private void radioButtonUrban_CheckedChanged(object sender, EventArgs e)
        {
            //Assign variable to enum value
            locationType = LocationType.Urban;
        }
    }
}
