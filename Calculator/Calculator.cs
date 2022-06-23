using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        

        private void readValue(String value)
        {
            resultBox.Text = (resultBox.Text.Length == 0 )
                ? resultBox.Text = value
                : resultBox.Text += value;
        }

        private void errorMsj(String msj)
        {
            resultBox.Text = msj;
        }

        private void changeSign(Char v1, Char v2, Char v3, Char v4)
        {
            if (resultBox.Text.Length == 0)
            {
                return;
            }
            else
            {
                char lastChar = resultBox.Text.Last();

                resultBox.Text = (lastChar == v1 || lastChar == v2 || lastChar == v3)
                    ? resultBox.Text.Replace(lastChar, v4)
                    : resultBox.Text += v4;
            }
        }

        private double showResult(String value)
        {
            double result = Convert.ToDouble(new DataTable().Compute(value, null));
            return result;
        }

        ///Functions above

        private void button0_Click(object sender, EventArgs e)
        {
            readValue("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readValue("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readValue("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            readValue("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            readValue("4");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            readValue("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            readValue("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            readValue("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            readValue("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            readValue("9");
        }

        private void openParentheses_Click(object sender, EventArgs e)
        {
            readValue("(");
        }

        private void closedParentheses_Click(object sender, EventArgs e)
        {
            readValue(")");
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            readValue(".");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            readValue("-");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            changeSign('*', '/', '-', '+');
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            changeSign('*','+','-','/');
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            changeSign('/', '+', '-', '*');
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Convert.ToDouble(resultBox.Text) / 100;
                resultBox.Text = result.ToString();
            }
            catch (Exception)
            {
                errorMsj("Invalid Format");
            }
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Math.Sqrt(Convert.ToDouble(resultBox.Text));
                resultBox.Text = result.ToString();
            }
            catch (Exception)
            {
                errorMsj("Invalid Format");
            }
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Math.Pow(Convert.ToDouble(resultBox.Text), 2);
                resultBox.Text = result.ToString();
            }
            catch (Exception)
            {
                errorMsj("Invalid Format");
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = (resultBox.Text.Length > 0)
                ? resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1, 1)
                : null;          
        }

        private void equalTo_Click(object sender, EventArgs e)
        {
            try
            {
                double iqualTo = showResult(resultBox.Text);
                resultBox.Text = iqualTo.ToString();
            }
            catch (Exception)
            {
                errorMsj("Invalid Format");
            }

        }

    }
}
