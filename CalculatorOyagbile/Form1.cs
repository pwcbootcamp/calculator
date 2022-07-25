using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorOyagbile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            previousOperation = Operation.None;
            txtDisplay.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            {
                double d;
                if (double.TryParse(txtDisplay.Text[txtDisplay.Text.Length - 1].ToString(), out d))
                {
                    previousOperation = Operation.None;
                }
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.Div;    
            txtDisplay.Text += (sender as Button).Text;
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn1 as Button).Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn2 as Button).Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn3 as Button).Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn4 as Button).Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn5 as Button).Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn6 as Button).Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn7 as Button).Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn8 as Button).Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn9 as Button).Text;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (Btn0 as Button).Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.Add;     
            txtDisplay.Text += (sender as Button).Text;
        }

        private void PerformCalculation(Operation previousOperation)
        {
            List<double> lstNums = new List<double>();
            switch (previousOperation)
            {
                case Operation.Add:
                    lstNums = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] + lstNums[1]).ToString();
                    break;
                case Operation.Sub:
                    lstNums = txtDisplay.Text.Split('-').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] - lstNums[1]).ToString();
                    break;
                case Operation.Mul:
                    lstNums = txtDisplay.Text.Split('*').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] * lstNums[1]).ToString();
                    break;
                case Operation.Div:
                    try
                    {
                        lstNums = txtDisplay.Text.Split('/').Select(double.Parse).ToList();
                        txtDisplay.Text = (lstNums[0] / lstNums[1]).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        txtDisplay.Text = "EEEEEEE";
                    }
                   
                    break;
                case Operation.None:
                    break;
            }
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);

            previousOperation = Operation.Mul;     
            txtDisplay.Text += (sender as Button).Text;
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
                PerformCalculation(previousOperation);
            
            previousOperation = Operation.Sub;                
            txtDisplay.Text += (sender as Button).Text;
        }

        enum Operation
        {
            Add,
            Sub,
            Mul,
            Div,
            None
        }

        static Operation previousOperation = Operation.None;

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (previousOperation == Operation.None)
                return;
            else
                PerformCalculation(previousOperation);
        }
    }
}
