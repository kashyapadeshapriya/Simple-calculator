using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        #region Variables

        public string input = string.Empty;
        public string oprand1 = string.Empty;
        public string oprand2 = string.Empty;
        public char operation;
        public double result = 0.00;

        #endregion
        //Constructor form initiation.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "0";
            this.textBoxView.Text = input;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "1";
            this.textBoxView.Text = input;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "2";
            this.textBoxView.Text = input;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "3";
            this.textBoxView.Text = input;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "4";
            this.textBoxView.Text = input;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "5";
            this.textBoxView.Text = input;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "6";
            this.textBoxView.Text = input;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "7";
            this.textBoxView.Text = input;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "8";
            this.textBoxView.Text = input;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + "9";
            this.textBoxView.Text = input;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            input = input + ".";
            this.textBoxView.Text = input;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxView.Text = "";
            this.input = string.Empty;
            this.oprand1 = string.Empty;
            this.oprand2 = string.Empty;

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            oprand2 = input;
            double num1, num2;
            double.TryParse(oprand1, out num1);
            double.TryParse(oprand2, out num2);
            // clearing the variables.
            this.textBoxView.Text = "";
            this.input = string.Empty;
            this.oprand1 = string.Empty;
            this.oprand2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                textBoxView.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBoxView.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBoxView.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBoxView.Text = result.ToString();
                }
                else
                {
                    textBoxView.Text = "DIV/Zero!";
                }

            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            oprand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btnSubstration_Click(object sender, EventArgs e)
        {
            oprand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            oprand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            oprand1 = input;
            operation = '/';
            input = string.Empty;
        }

    }
}
