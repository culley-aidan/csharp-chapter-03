using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthNamesGUI
{
    public partial class MonthNamesGUI : Form
    {
        public MonthNamesGUI()
        {
            InitializeComponent();
        }

        enum Months { JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string errorText = "Enter a number between 1-12";
            string errorTitle = "Error";
            if (!int.TryParse(txtMonth.Text, out int month) || month > 12 || month < 1)
            {
                MessageBox.Show(errorText, errorTitle);
                txtMonth.Text = "";
            } else
            {
                lblFound.Text = ((Months)month).ToString();
                lblFound.Visible = true;
            }
        }
    }
}
