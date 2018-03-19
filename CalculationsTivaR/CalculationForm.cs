using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 08-03-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Calculations
 * This program has a bunch of buttons with calculations on them...
 * when you press the button they display the answer.
*/

namespace CalculationsTivaR
{
    public partial class frmCalculations : Form
    {
        public frmCalculations()
        {
            InitializeComponent();
            lblAnswer1.Hide();
            lblAnswer2.Hide();
            lblAnswer3.Hide();
            lblAnswer4.Hide();
        }

        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            // Show and calculate the answer
            lblAnswer1.Text = Convert.ToString(5 + Math.Pow(2, 3));
            lblAnswer1.Show();
        }

        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            // Show and calculate the answer
            lblAnswer2.Text = Convert.ToString(4 / 2 + 5);
            lblAnswer2.Show();
        }

        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            // Show and calculate the answer
            lblAnswer3.Text = Convert.ToString(3 + 4 * 2);
            lblAnswer3.Show();
        }

        private void btnQuestion4_Click(object sender, EventArgs e)
        {
            // Show and calculate the answer
            lblAnswer4.Text = Convert.ToString(7 - 3 + 2);
            lblAnswer4.Show();
        }
    }
}
