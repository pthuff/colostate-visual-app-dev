/*
 * Date:            October 16, 2018
 * Modified:        October 19,2018
 * Developed By:    Paul Huff
 * Class Name:      Program12
 * Description:     Form class for entering the initial height/velocity of a pojectile and return max height/drop rate
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

namespace PHuffProgram12
{
    public partial class Program12 : Form
    {
        public Program12()
        {
            InitializeComponent();
        }

        private void buttonThrow_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int height, velocity;

            //Assign values to variables
            height = Convert.ToInt32(numericUpDownHeight.Value);
            velocity = Convert.ToInt32(numericUpDownVelocity.Value);

            Projectile aProjectile;

            //Instatiate a new WaterTank object and pass parameters
            aProjectile = new Projectile(height, velocity);

            //Call Projectile methods and return values to label
            labelReturn.Text = $" Maximum height reached (ft): {aProjectile.MaxHeight.ToString("n2")} \r\n Time to return to ground (secs): {aProjectile.LandTime.ToString("n2")}";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Reset form
            numericUpDownHeight.Value = 0;
            numericUpDownVelocity.Value = 0;
            labelReturn.Text = null;

            //Focus
            numericUpDownHeight.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Close the application
            this.Close();
        }
    }
}
