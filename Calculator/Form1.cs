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
        double NumFirst, NumSecond;
        string operators;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumbersCal(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(txtResult.Text == "0")
            
                txtResult.Text = "";
                if (btn.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + btn.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + btn.Text;
                }
            

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            NumFirst = double.Parse(txtResult.Text);
            operators = "-";
            txtResult.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            NumFirst = double.Parse(txtResult.Text);
            operators = "*";
            txtResult.Text = "";
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            NumSecond = double.Parse(txtResult.Text);

            switch(operators)
            {
                case "+":
                    txtResult.Text = (NumFirst + NumSecond).ToString();
                    break;
                case "-":
                    txtResult.Text = (NumFirst - NumSecond).ToString();
                    break;
                case "*":
                    txtResult.Text = (NumFirst * NumSecond).ToString();
                    break;
                case "/":
                    txtResult.Text = (NumFirst / NumSecond).ToString();
                    break;
                    default:
                    break;
           }
        }



        private void btnClearEnter_Click(object sender, EventArgs e)
        {

            if(txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            } if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            NumFirst = double.Parse(txtResult.Text);
            operators = "/";
            txtResult.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NumFirst = double.Parse(txtResult.Text);
            operators = "+";
            txtResult.Text = "";
        }
    }
}
