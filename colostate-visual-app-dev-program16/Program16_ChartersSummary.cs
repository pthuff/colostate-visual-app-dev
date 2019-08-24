/*
 * Date:            November 26, 2018
 * Modified:        November 30, 2018
 * Developed By:    Paul Huff
 * Class Name:      Program16_CharterSummary
 * Description:     Form class for displaying a summary of charter charges
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
    public partial class Program16_ChartersSummary : Form
    {
        public Program16_ChartersSummary()
        {
            InitializeComponent();
        }

        private void Program16_ChartersSummary_Load(object sender, EventArgs e)
        {
            //Display information in summary label
            lblSummary.Text = $"Lowest Charter Fee: {CharterManager.FindLowestCharterFee().ToString("c2")} \r\nTotal Charter Fees: {CharterManager.GetTotalCharterFees().ToString("c2")} \r\nAverage Charter Fee: {CharterManager.GetAverageCharterFee().ToString("c2")}";
        }
    }
}
