using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2Assignment2HappyNumbers
{
    //Paxston Gulledge


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int number;
            bool success = Int32.TryParse(txtNumber.Text, out number);
            bool unhappy = false;
            if (number > 0 && success == true)
            {
                unhappy = IsNumberHappy(number);
                if (unhappy == false)
                {
                    MessageBox.Show(txtNumber.Text + " is a happy number.");
                }
                else
                {
                    MessageBox.Show(txtNumber.Text + " is an unhappy number.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a positive number greater than 0.");
            }

        }
        private bool IsNumberHappy(int number)
        {
            int digit;
            int sum = 0;
            bool unhappy = false;
            while (number != 1 && unhappy == false)
            {
                while (number != 0 && unhappy == false)
                {
                    digit = number % 10;
                    sum += digit * digit;
                    number = number / 10;
                }
                number = sum;
                if (number == 4)
                {
                    unhappy = true;
                    return true;
                }
                sum = 0;
            }
            return false;
        }

        private void btnHappyList_Click(object sender, EventArgs e)
        {
            bool unhappy = false;
            string happyList = "1";
            for (int i = 2; i < 32; i++)
            {
                unhappy = IsNumberHappy(i);
                if (unhappy == false)
                {
                    happyList = happyList + ", " + Convert.ToString(i);
                }
            }
            lblHappyList.Text = happyList;
        }
    }
}
