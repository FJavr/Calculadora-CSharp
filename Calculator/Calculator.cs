using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void readValue(object sender, EventArgs e)
        {
            var buttonValue = ((Button)sender).Text;

            resultBox.Text = (resultBox.Text.Length == 0 || resultBox.Text == "0")
                ? resultBox.Text = buttonValue
                : resultBox.Text += buttonValue;
        }

        private void errorMsj(String msj)
        {
            resultBox.Text = msj;
        }

        private void changeSign(Char v1, Char v2, Char v3, Char v4)
        {
            char lastChar = resultBox.Text.Last();

            if (resultBox.Text.Length == 0)
            {
                return;
            }
            else if( resultBox.Text.Length > 0 && (lastChar == v1 || lastChar == v2 || lastChar == v3) )
            {
                resultBox.Text = resultBox.Text.Replace(lastChar, v4);
            }
            else
            {
                resultBox.Text += v4;
            }
        }

        private double showResult(String value)
        {
            double result = Convert.ToDouble(new DataTable().Compute(value, null));
            return result;
        }

        ///Functions above

        private void percentageButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultBox.Text = (Convert.ToDouble(resultBox.Text) / 100).ToString();
            }
            catch (Exception)
            {
                errorMsj("Error");
            }
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultBox.Text = Math.Sqrt(Convert.ToDouble(resultBox.Text)).ToString();
            }
            catch (Exception)
            {
                errorMsj("Error");
            }
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            try
            {
                resultBox.Text = Math.Pow(Convert.ToDouble(resultBox.Text), 2).ToString();
            }
            catch (Exception)
            {
                errorMsj("Error");
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
                resultBox.Text = showResult(resultBox.Text).ToString();
            }
            catch (Exception)
            {
                errorMsj("Error");
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            changeSign('/', '*', '-', '+');

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            changeSign('/', '-', '+', '*');
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            changeSign('*', '-', '+', '/');
        }
    }
}
