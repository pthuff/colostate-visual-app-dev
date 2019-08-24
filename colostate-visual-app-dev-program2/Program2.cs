using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Program2 class
// Class for a form displaying the area and volume of a cylinder
// Paul Huff
// Sept 4, 2018
// Modified Sept 4, 2018

namespace PHuffProgram2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        //Button to calculate area by calling the Cylinder CalcArea method
        {
            Cylinder aCylinder = new Cylinder();

            lblReturn.Text = aCylinder.CalcArea(Convert.ToInt32(txtRadius.Text), Convert.ToInt32(txtHeight.Text)).ToString();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        //Button to calculate volume by calling the Cylinder CalcVolume method
        {
            Cylinder aCylinder = new Cylinder();

            lblReturn.Text = aCylinder.CalcVolume(Convert.ToInt32(txtRadius.Text), Convert.ToInt32(txtHeight.Text)).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        //Button to exit
        {

            this.Close();
        }
    }
}