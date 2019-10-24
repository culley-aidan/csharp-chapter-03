using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggInteractiveGUI
{
    public partial class EggInteractiveGUI : Form
    {
        public EggInteractiveGUI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string errorText = "Enter a valid number";
            string errorTitle = "Error";

            if(!int.TryParse(txtChickenOne.Text, out int chickenOne) || !int.TryParse(txtChickenTwo.Text, out int chickenTwo) || !int.TryParse(txtChickenThree.Text, out int chickenThree) || !int.TryParse(txtChickenFour.Text, out int chickenFour) || !int.TryParse(txtChickenFive.Text, out int chickenFive))
            {
                MessageBox.Show(errorText, errorTitle);
                txtChickenOne.Text = "";
                txtChickenTwo.Text = "";
                txtChickenThree.Text = "";
                txtChickenFour.Text = "";
                txtChickenFive.Text = "";
            } else
            {
                int total = chickenOne + chickenTwo + chickenThree + chickenFour + chickenFive;
                int eggDozen = total / 12;
                int eggRemainder = total % 12;
                lblEggs.Text = string.Format("{0} eggs is {1} dozen with {2} left over", total, eggDozen, eggRemainder);
                lblEggs.Visible = true;
            }
        }
    }
}
