using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHuffProgram1
{
    public partial class Program1 : Form
    // Program1 class 
    //Class to display a movie's lead actor, lead actress, and director
    //Paul Huff
    //Aug 28, 2018
    //Modified Aug 28, 2018
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void lblMovieName_Click(object sender, EventArgs e)
        {

        }

        private void lblReturnValue_Click(object sender, EventArgs e)
        {

        }

        private void btnActor_Click(object sender, EventArgs e)
        {
            Movie aMovie = new Movie();
            lblReturnValue.Text = aMovie.ShowLeadActor();
        }

        private void btnActress_Click(object sender, EventArgs e)
        {
            Movie aMovie = new Movie();
            lblReturnValue.Text = aMovie.ShowLeadActress();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            Movie aMovie = new Movie();
            lblReturnValue.Text = aMovie.ShowDirector();
        }
    }
}
