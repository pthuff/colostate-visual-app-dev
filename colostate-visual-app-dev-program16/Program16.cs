/*
 * Date:            November 26, 2018
 * Modified:        November 30, 2018
 * Developed By:    Paul Huff
 * Class Name:      Program16
 * Description:     Form class for creating and adding charters to a list
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

namespace PhuffProgram16
{
    public partial class Program16 : Form
    {
        public Program16()
        {
            InitializeComponent();
        }

        //Declare a class/module level variable
        private CharterManager aCharterManager;

        private void mnuAllCharters_Click(object sender, EventArgs e)
        {
            //Display all charters in a new form window
            Program16_AllCharters aAllCharters = new Program16_AllCharters();
            aAllCharters.ShowDialog();
        }

        private void mnuNumOfCharters_Click(object sender, EventArgs e)
        {
            //Declare local variable
            int size = Convert.ToInt32(comboBoxSize.SelectedItem);

            //Verify yacht size has been selected
            if (comboBoxSize.SelectedItem == null)
            {
                MessageBox.Show("Charter Size is required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxSize.Focus();
                return;
            }

            //Prepare summary message to dispaly to message box
            string stringMessage = $" Total number of charters for {size} foot yacht: {aCharterManager.GetCharterCount(size).ToString()}";

            //Display the message box
            MessageBox.Show(stringMessage, "Number of Charters", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuChartersSummary_Click(object sender, EventArgs e)
        {
            //Display charters summary in a new form window
            Program16_ChartersSummary aChartersSummary = new Program16_ChartersSummary();
            aChartersSummary.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Declare local variables
            string name, type;
            decimal hours;
            int size;

            //Assign value to variables
            name = textBoxName.Text;
            type = Convert.ToString(comboBoxType.SelectedItem);
            hours = Convert.ToInt32(numericUpDownHours.Value);
            size = Convert.ToInt32(comboBoxSize.SelectedItem);

            // Verify values have been entered
            if (textBoxName.Text == null || comboBoxType.SelectedItem == null || comboBoxSize.SelectedItem == null)
            {
                MessageBox.Show("Customer Name, Hours Used, Charter Type, and Charter Size are required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            //Instatiate a new CharterManager object
            if (aCharterManager is null)
            {
                aCharterManager = new CharterManager();
            }

            //Call addCharter method to add new charter object
            aCharterManager.AddCharter(name, type, size, hours);

            //Disable/enable controls
            mnuAllCharters.Enabled = true;
            mnuChartersSummary.Enabled = true;
            mnuNumOfCharters.Enabled = true;
            buttonAdd.Enabled = false;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }

        private void mnuReset_Click(object sender, EventArgs e)
        {
            //Reset the form
            textBoxName.Text = null;
            numericUpDownHours.Value = .50m;
            comboBoxType.SelectedItem = null;
            comboBoxSize.SelectedItem = null;

            //Enable button
            buttonAdd.Enabled = true;
        }

        private void mnuAddYacht_Click(object sender, EventArgs e)
        {
            //Add manually typed item to combobox
            comboBoxType.Items.Add(comboBoxType.Text);
        }

        private void mnuRemoveYacht_Click(object sender, EventArgs e)
        {
            //Remove manually typed item from combobox
            comboBoxType.Items.Remove(comboBoxType.Text);
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            //Add manually typed item to combobox
            comboBoxType.Items.Add(comboBoxType.Text);
        }

        private void toolStripMenuItemRemove_Click(object sender, EventArgs e)
        {
            //Remove manually typed item from combobox
            comboBoxType.Items.Remove(comboBoxType.Text);
        }
    }
}
