using System;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal Result { get; set; }

        public double RootResult { get; set; }
        public decimal Valor { get; set; }

        private Operation ChosedOperation { get; set; }

        private enum Operation
        {
            Add,
            Subtraction,
            Multiplication,
            Division,
            Root
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (ChosedOperation)
            {
                case Operation.Add:
                    Result = Valor + Convert.ToDecimal(txtResult.Text);
                    break;
                case Operation.Subtraction:
                    Result = Valor - Convert.ToDecimal(txtResult.Text);
                    break;
                case Operation.Multiplication:
                    Result = Valor * Convert.ToDecimal(txtResult.Text);
                    break;
                case Operation.Division:
                    Result = Valor / Convert.ToDecimal(txtResult.Text);
                    break;
                case Operation.Root:
                    RootResult = Convert.ToDouble(txtResult.Text);
                    Result = Convert.ToDecimal(Math.Sqrt(RootResult));
                    break;
            }
            txtResult.Text = Convert.ToString(Result);
        }

        private void btnDivisor_Click(object sender, EventArgs e)
        {
            ChosedOperation = Operation.Division;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOperation.Text = "/";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            ChosedOperation = Operation.Multiplication;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOperation.Text = "X";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ChosedOperation = Operation.Subtraction;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOperation.Text = "-";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ChosedOperation = Operation.Add;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOperation.Text = "+";
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            ChosedOperation = Operation.Root;
            lblOperation.Text = "√";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            Valor = 0;
        }
    }
}
