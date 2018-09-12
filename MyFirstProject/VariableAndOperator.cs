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
    public partial class VariableAndOperator : Form
    {
        public VariableAndOperator()
        {
            InitializeComponent();
            LoadDataTypeList();
          
        }

    

        private void LoadDataTypeList()
        {
            string[] myList = new string[4];

            myList[0] = "float";
            myList[1] = "double";
            myList[2] = "char";
            myList[3] = "int";

            listBoxDataType.Items.AddRange(myList);
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            lblFunction.Text = "Addition";
            btnOperation.Text = "Add";
        }

        private void radioSubtract_CheckedChanged(object sender, EventArgs e)
        {
            lblFunction.Text = "Subtraction";
            btnOperation.Text = "Subtract";
        }

        private void radioMultiply_CheckedChanged(object sender, EventArgs e)
        {
            lblFunction.Text = "Multiplication";
            btnOperation.Text = "Multiply";
        }

        private void radioDivide_CheckedChanged(object sender, EventArgs e)
        {
            lblFunction.Text = "Division";
            btnOperation.Text = "Divide";
        }

        private void radioSelect_CheckedChanged(object sender, EventArgs e)
        {
            lblFunction.Text = "Select";
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;
            firstNumber = Convert.ToInt16(txtFirstNum.Text);
            secondNumber = Convert.ToInt16(txtSecondNum.Text);
            if (radioAdd.Checked)
            {
                result = firstNumber + secondNumber;
            }
            else if (radioSubtract.Checked)
            {
                result = firstNumber - secondNumber;
            }
            else if (radioMultiply.Checked)
            {
                result = firstNumber * secondNumber;
            }
            else if (radioDivide.Checked)
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                lblResult.Text = "Please select operstion type";
            }
             lblResult.Text= result.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm();
            if (defaultForm == null)
            {
                defaultForm.Parent = this;
            }
            defaultForm.Show();
            this.Hide();
        }

     

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IndexForm indexForm = new IndexForm();
            if (indexForm == null)
            {
                indexForm.Parent = this;
            }
            indexForm.Show();
            this.Hide();
        }

        private void listBoxDataType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
