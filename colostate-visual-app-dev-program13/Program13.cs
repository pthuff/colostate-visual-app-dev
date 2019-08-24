/*
 * Date:            October 16, 2018
 * Modified:        October 20,2018
 * Developed By:    Paul Huff
 * Class Name:      Program13
 * Description:     Form class for displaying number of NFL championships for a selected team, and number of back-to-back championships
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

namespace PHuffProgram13
{
    public partial class Program13 : Form
    {
        public Program13()
        {
            InitializeComponent();
        }

        private void buttonWins_Click(object sender, EventArgs e)
        {
            //Declare local varaibles
            string team = Convert.ToString(comboBoxTeams.SelectedItem);
            bool won = false;
            int count = 0;

            //Verify team has been selected
            if (comboBoxTeams.SelectedItem == null)
            {
                MessageBox.Show("Please select a team", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxTeams.Focus();
                return;
            }

            //Determine if team matches value in Super Bowl list
            for (int x = 0; x < comboBoxChamps.Items.Count; ++x)
            {
                if (team == comboBoxChamps.Items[x].ToString())
                {
                    ++count;
                    won = true;
                }
            }

            //Return the value to the label
            labelReturn.Text = (won) ? $" The {team} have won the Super Bowl {count} times." : $" The {team} have never won a Super Bowl";
        }

        private void buttonBToB_Click(object sender, EventArgs e)
        {
            //Declare local varaibles
            string team = Convert.ToString(comboBoxTeams.SelectedItem);
            bool wonB2B = false;
            int b2bCount = 0;

            //Verify team has been selected
            if (comboBoxTeams.SelectedItem == null)
            {
                MessageBox.Show("Please select a team", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxTeams.Focus();
                return;
            }

            //Determine if team has won back to back super bowls
            for (int x = 0; x < comboBoxChamps.Items.Count; ++x)
            {
                if (team == comboBoxChamps.Items[x].ToString())
                {
                    if (comboBoxChamps.Items[x].ToString() == comboBoxChamps.Items[x + 1].ToString())
                    {
                        ++b2bCount;
                        wonB2B = true;
                    }            
                }
            }

            //Return the value to the label
            labelReturn.Text = (wonB2B) ? $" The {team} have won {b2bCount} back-to-back Super Bowl(s)." : $" The {team} have never won back-to-back.";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Close the appilcation
            this.Close();
        }
    }
}
