using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private double firstNum = 0;
        private string operation = "";
        private bool isOperationClicked = false;
        private string currentExpression = ""; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textTotal.Text == "0" || isOperationClicked)
            {
                textTotal.Clear();
                isOperationClicked = false;
                currentExpression = ""; 
            }
            Button button = (Button)sender;
            textTotal.Text += button.Text;
            currentExpression += button.Text; 
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (firstNum == 0)
            {
                firstNum = double.Parse(textTotal.Text);
                operation = button.Text;
                isOperationClicked = true;
                currentExpression = textTotal.Text + " " + operation + " "; 
                textTotal.Text = currentExpression;

            }
            else if (!string.IsNullOrEmpty(operation))
            {
                CalculateResult();
                operation = button.Text;
                currentExpression = textTotal.Text + " " + operation + " ";  
                textTotal.Text = currentExpression;
                isOperationClicked = true;
            }
            else
            {
                operation = button.Text;
                currentExpression = textTotal.Text + " " + operation + " ";
                textTotal.Text = currentExpression;
                isOperationClicked = true;
            }
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            CalculateResult();
            operation = ""; 
            firstNum = 0;   
            isOperationClicked = false;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            textTotal.Text = "0";
            firstNum = 0;
            operation = "";
            isOperationClicked = false;
            currentExpression = ""; 
        }

        private void CalculateResult()
        {
            if (!string.IsNullOrEmpty(operation))
            {
                double secondNum = double.Parse(textTotal.Text);
                currentExpression += secondNum.ToString();
                textTotal.Text = currentExpression;
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = firstNum + secondNum;
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        break;
                    case "*":
                        result = firstNum * secondNum;
                        break;
                    case "/":
                        if (secondNum == 0)
                        {
                            textTotal.Text = "Cannot divide by zero";
                            return;
                        }
                        else
                        {
                            result = firstNum / secondNum;
                        }
                        break;
                }
                textTotal.Text = result.ToString();
                firstNum = result;
            }
            else
            {
                textTotal.Text = currentExpression;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }
    }
}