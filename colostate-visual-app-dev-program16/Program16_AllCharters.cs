/*
 * Date:            November 26, 2018
 * Modified:        November 30, 2018
 * Developed By:    Paul Huff
 * Class Name:      Program16_AlCharters
 * Description:     Form class for displaying all charters in a table
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
    public partial class Program16_AllCharters : Form
    {
        public Program16_AllCharters()
        {
            InitializeComponent();
        }

        private void Program16_AllCharters_Load(object sender, EventArgs e)
        {
            //Bind gridview to CharterList
            charterBindingSource.DataSource = CharterManager.CharterList;
        }
    }
}
