/*
 * Date:            October 3, 2018
 * Modified:        October 9,2018
 * Developed By:    Paul Huff
 * Class Name:      Program9
 * Description:     Class for creating a label to input catering event parameters and return a charge for the event
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

namespace PHuffProgram9
{
    public partial class Program9 : Form
    {
        //Declare local variable and assign to enum switch
        EntreType entreType;
        //Declare object variable
        private CateringEvent createEvent;
        private CateringEvent modifyEvent;
        public Program9()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Verify event name has been entered
            if (textBoxName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Event name is required", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            //Declare local variables
            string eventName;
            int numOfGuests;
            bool barOpen, dinnerWithWine;

            //Assign values to variables
            eventName = textBoxName.Text;
            numOfGuests = Convert.ToInt32(numericUpDownGuests.Value);
            barOpen = checkBoxOpenBar.Checked;
            dinnerWithWine = checkBoxWine.Checked;

            //Instantiate a CateringEvent object
            createEvent = new CateringEvent(eventName, numOfGuests, entreType, barOpen, dinnerWithWine);

            //Access CalcEventCharges method and display result
            labelResult.Text = $" Entre Charge: {createEvent.EntreCharge.ToString("c2")} \r\n Drinks Charge: {createEvent.DrinksCharge.ToString("c2")} \r\n Surcharge: {createEvent.Surcharge.ToString("c2")} \r\n Total: {createEvent.TotalCharge.ToString("c2")}";
            
            //Disable/Enable controls
            buttonCreate.Enabled = false;
            textBoxName.Enabled = false;
            buttonModify.Enabled = true;
        }

        private void radioButtonPrimeRib_CheckedChanged(object sender, EventArgs e)
        {
            //Assign variable to enum value
            entreType = EntreType.PrimeRib;
        }

        private void radioButtonChickenMarsala_CheckedChanged(object sender, EventArgs e)
        {
            //Assign variable to enum value
            entreType = EntreType.ChickenMarsala;
        }

        private void radioButtonGardenLasagna_CheckedChanged(object sender, EventArgs e)
        {
            //Assign variable to enum value
            entreType = EntreType.GardenLasagna;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            //Declare local variables
            string eventName;
            int numOfGuests;
            bool barOpen, dinnerWithWine;

            //Assign values to variables
            eventName = textBoxName.Text;
            numOfGuests = Convert.ToInt32(numericUpDownGuests.Value);
            barOpen = checkBoxOpenBar.Checked;
            dinnerWithWine = checkBoxWine.Checked;

            //Instantiate a CateringEvent object
            modifyEvent = new CateringEvent(eventName, numOfGuests, entreType, barOpen, dinnerWithWine);

            //Access CalcEventCharges method and display result
            labelResult.Text = $" Entre Charge: {modifyEvent.EntreCharge.ToString("c2")} \r\n Drinks Charge: {modifyEvent.DrinksCharge.ToString("c2")} \r\n Surcharge: {modifyEvent.Surcharge.ToString("c2")} \r\n Total: {modifyEvent.TotalCharge.ToString("c2")}";

            //Disable/Enable controls
            buttonCreate.Enabled = false;
            textBoxName.Enabled = false;
            buttonModify.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Reset form
            textBoxName.Clear();
            numericUpDownGuests.Value = 10;
            radioButtonPrimeRib.Checked = true;
            checkBoxOpenBar.Checked = false;
            checkBoxWine.Checked = false;
            labelResult.Text = null;

            //Enable controls
            textBoxName.Enabled = true;
            buttonCreate.Enabled = true;
            buttonModify.Enabled = false;

            //Focus
            textBoxName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Declare local variable
            DialogResult aExitQuestion;

            //Assign the return value to the variable
            aExitQuestion = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //Decide what to do as a result
            if (aExitQuestion == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                textBoxName.Focus();
            }
        }
    }
}
