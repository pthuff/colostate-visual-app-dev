/*
 * Date:            September 6, 2018
 * ModifiedL        September 13,2018
 * Developed By:    Paul Huff
 * Class Name:      Program3
 * Description:     Class form for diaplaying a Broadmoor Hotel advertisement
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

namespace PHuffProgram3
{
    public partial class Program3 : Form
    {
        //Declare the form class

        public Program3()
        {
            InitializeComponent();
        }

        private void radioBtnRed_CheckedChanged(object sender, EventArgs e)
        {
            //Method to change the tagline color to red

            lblTagline.ForeColor = Color.Red;

        }

        private void radioBtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            //Method to change the tagline color to green

            lblTagline.ForeColor = Color.Green;
        }

        private void radioBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            //Method to change the tagline color to Blue

            lblTagline.ForeColor = Color.Blue;
        }

        private void radioBtnOrange_CheckedChanged(object sender, EventArgs e)
        {
            //Method to change the tagline color to orange

            lblTagline.ForeColor = Color.Orange;
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            //Method to display or remove the company name

            lblName.Visible = checkBoxName.Checked;
        }

        private void checkBoxTagline_CheckedChanged(object sender, EventArgs e)
        {
            //Method to display or remove the tagline

            lblTagline.Visible = checkBoxTagline.Checked;
        }

        private void checkBoxLogo_CheckedChanged(object sender, EventArgs e)
        {
            //Method to display or remove the picture

            pictureBoxBroadmoor.Visible = checkBoxLogo.Checked;
        }

        private void checkBoxDev_CheckedChanged(object sender, EventArgs e)
        {
            //Method to display or remove the developer

            lblDev.Visible = checkBoxDev.Checked;
        }

        private void pictureBoxBroadmoor_Click(object sender, EventArgs e)
        {
            //Method to display a tooltip for picture

            ToolTip aToolTip = new ToolTip();
            aToolTip.SetToolTip(this.pictureBoxBroadmoor, "Our Logo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the program

            this.Close();
        }
    }
}
