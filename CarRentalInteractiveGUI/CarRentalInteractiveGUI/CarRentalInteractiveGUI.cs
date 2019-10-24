using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class CarRentalInteractiveGUI : Form
    {
        public CarRentalInteractiveGUI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string errorText = "Enter a valid number";
            string errorTitle = "Error";

            if (!decimal.TryParse(txtDays.Text, out decimal days) || !decimal.TryParse(txtMiles.Text, out decimal miles))
            {
                MessageBox.Show(errorText, errorTitle);
                txtDays.Text = "";
                txtMiles.Text = "";
            } else
            {
                decimal total = 0;
                total += days * 20;
                total += miles * 0.25M;
                lblTotalFee.Text = string.Format("The total rental fee is {0}", total.ToString("C"));
                lblTotalFee.Visible = true;
            }

        }
    }
}
