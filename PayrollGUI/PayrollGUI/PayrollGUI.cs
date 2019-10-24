using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class PayrollGUI : Form
    {
        public PayrollGUI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string errorText = "Enter a valid number";
            string errorTitle = "Error";
            decimal fedRate = 0.15M;
            decimal stateRate = 0.05M;

            if (!decimal.TryParse(txtPayrate.Text, out decimal payRate) || !decimal.TryParse(txtWorkHours.Text, out decimal workHours))
            {
                MessageBox.Show(errorText, errorTitle);
                txtPayrate.Text = "";
                txtWorkHours.Text = "";
            } else
            {
                decimal grossPay = payRate * workHours;
                decimal fedTax = grossPay * fedRate;
                decimal stateTax = grossPay * stateRate;
                decimal netPay = (grossPay - fedTax) - stateTax;
                lblGrossPay.Text += grossPay.ToString("C");
                lblGrossPay.Visible = true;
                lblFeds.Text += fedTax.ToString("C");
                lblFeds.Visible = true;
                lblState.Text += stateTax.ToString("C");
                lblState.Visible = true;
                lblNet.Text += netPay.ToString("C");
                lblNet.Visible = true;
                btnCalculate.Enabled = false;
            }
        }
    }
}
