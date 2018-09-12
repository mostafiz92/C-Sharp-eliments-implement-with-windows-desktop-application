using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class ExceptionHandling : Form
    {
        public ExceptionHandling()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "";
            txtoutCome.Text = "";
            try
            {
                if (radioAddition.Checked)
                {
                    addValues();
                }
                else if (radioSubtruction.Checked)
                {
                    subtractValues();
                }
                else if (radioMultiply.Checked)
                {
                    multiplyValues();
                }
                else if (radioDivide.Checked)
                {
                    divideValues();
                }
                else if (radioRemainder.Checked)
                {
                    remaindreValues();
                }

            }
            catch (OverflowException oex)
            {
                txtoutCome.Text = "Overflow Exception";
            }
            catch (FormatException fex)
            {
                txtoutCome.Text = "Format Exception!";
            }
            catch (DivideByZeroException dex)
            {
                txtoutCome.Text = "DivideByZero Exception";
            }
            catch (Exception ex)
            {
                txtoutCome.Text = ex.ToString();
            }
            txtFirstNum.Text = "";
            txtSecondNum.Text = "";
        }

        private void remaindreValues()
        {
            int outcome = 0;
            int number1 = Convert.ToInt32(txtFirstNum.Text);
            int number2 = Convert.ToInt32(txtSecondNum.Text);
            // outcome = checked(number1 + number2);
            outcome = number1 % number2;
            lblExpression.Text = txtFirstNum.Text + " % " + txtSecondNum.Text;
            txtoutCome.Text = outcome.ToString();
        }

        private void divideValues()
        {
            int outcome = 0;
            int number1 = Convert.ToInt32(txtFirstNum.Text);
            int number2 = Convert.ToInt32(txtSecondNum.Text);
            // outcome = checked(number1 + number2);
            outcome = number1 / number2;
            lblExpression.Text = txtFirstNum.Text + " / " + txtSecondNum.Text;
            txtoutCome.Text = outcome.ToString();
        }

        private void multiplyValues()
        {
           
            int outcome = 0;
            int number1 = Convert.ToInt32(txtFirstNum.Text);
            int number2 = Convert.ToInt32(txtSecondNum.Text);
            // outcome = checked(number1 + number2);
            outcome = number1 * number2;
            lblExpression.Text = txtFirstNum.Text + " * " + txtSecondNum.Text;
            txtoutCome.Text = outcome.ToString();
        }

        private void subtractValues()
        {
            
            int outcome = 0;
            int number1 = Convert.ToInt32(txtFirstNum.Text);
            int number2 = Convert.ToInt32(txtSecondNum.Text);
            // outcome = checked(number1 + number2);
            outcome = number1 - number2;
            lblExpression.Text = txtFirstNum.Text + " - " + txtSecondNum.Text;
            txtoutCome.Text = outcome.ToString();
        }

        private void addValues()
        {
           
            int outcome = 0;
            int number1 = Convert.ToInt32(txtFirstNum.Text);
            int number2 = Convert.ToInt32(txtSecondNum.Text);
           // outcome = checked(number1 + number2);
            outcome = number1 + number2;
            lblExpression.Text = txtFirstNum.Text + " + " + txtSecondNum.Text;
            txtoutCome.Text = outcome.ToString();
        }
    }
}
