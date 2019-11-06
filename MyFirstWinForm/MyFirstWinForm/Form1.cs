using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class Calculator : Form
    {
        static double dNumber = 0;
        static double dMemory = 0;
        static string sOperation = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vehicleLeaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "1";
            else
                txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void NumberPressed(object sender, EventArgs e)
        {
            string sNumber = (sender as Button).Text;

            txtDisplay.Text = txtDisplay.Text == "0" ? sNumber : txtDisplay.Text + sNumber;
            
            //if (dNumber == 0)
            //{
            //    if (txtDisplay.Text == "0")
            //        txtDisplay.Text = sNumber;
            //    else
            //        txtDisplay.Text = txtDisplay.Text + sNumber;
            //}
            //else
                
            //{
            //    txtDisplay.Text = sNumber;

            //}

        }

        private void Calculate(object sender, EventArgs e)
        {
            if (sOperation == "")
            {
                dNumber = double.Parse(txtDisplay.Text);
                txtDisplay.Text = "0";
                sOperation = (sender as Button).Text;
            }
            else if (sOperation == "+")
            {
                txtDisplay.Text = (dNumber + double.Parse(txtDisplay.Text)).ToString();
                sOperation = "";
            }
            else if (sOperation == "-")
            {
                txtDisplay.Text = (dNumber - double.Parse(txtDisplay.Text)).ToString();
                sOperation = "";
            }
            else if (sOperation == "*")
            {
                txtDisplay.Text = (dNumber * double.Parse(txtDisplay.Text)).ToString();
                sOperation = "";
            }

            else if (sOperation == "/")
            {
                txtDisplay.Text = (dNumber / double.Parse(txtDisplay.Text)).ToString();
                sOperation = "";
            }
            
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length == 1)
                txtDisplay.Text = "0";
            else
               txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                if (txtDisplay.Text.Substring(0, 1) == "-")
                {
                    txtDisplay.Text = txtDisplay.Text.Replace("-", "");
                    //txtDisplay.Text = txtDisplay.Text.Substring(1, txtDisplay.Text.Length - 1);
                }
                else
                {
                    txtDisplay.Text = "-" + txtDisplay.Text;
                }
            }
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sKey = Convert.ToString(e.KeyChar);
            int iNumber = 0;
            bool validNumber = int.TryParse(sKey, out iNumber);

            if (validNumber)
            {
                txtDisplay.Text = txtDisplay.Text == "0" ? iNumber.ToString() : txtDisplay.Text + iNumber.ToString();
            }
            else
            {
                MessageBox.Show("Invalid key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sqrt(number).ToString();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (1 / number).ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            dNumber = 0;
            sOperation = "";
            txtDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculate(sender, null);
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            dMemory = double.Parse(txtDisplay.Text);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            dMemory = 0;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = dMemory.ToString();
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (dMemory + double.Parse(txtDisplay.Text)).ToString();
        }

    }
}
