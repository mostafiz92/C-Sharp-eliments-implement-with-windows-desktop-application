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
    public partial class DecisionAndIteration : Form
    {
        public DecisionAndIteration()
        {
            InitializeComponent();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IndexForm indexForm = new IndexForm();
            if (indexForm == null)
            {
                indexForm.Parent = this;
            }
            indexForm.Show();
            this.Hide();
        }

      

      

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            if (radioIf.Checked)
            {
                ShowGradeUsingIfStatement();
            }
            else if (radioSwitch.Checked)
            {
                ShowGradeUsingSwitchStatement();
            }
            else if (radioWhile.Checked)
            {
                ShowGradeUsingWhileStatement();
            }
            else if (radioDo.Checked)
            {
                ShowGradeUsingDoWhileStatement();
            }
            else if (radioFor.Checked)
            {
                ShowGradeUsingForStatement();
            }
            else
            {
                lblGrade.Text = "No option selected.";
            }
        }

        private void ShowGradeUsingForStatement()
        {
            int count = 0;
            int percentageMark = 0;
            string grade = "";
            percentageMark = Convert.ToInt16(txtMark.Text);
        }

        private void ShowGradeUsingDoWhileStatement()
        {
           int count = 0;
           int percentageMark = 0;
           string grade = "";
          
           percentageMark = Convert.ToInt16(txtMark.Text);
            do{
                switch (percentageMark)
                {
                    case 70:
                        grade = "B";
                        break;
                    case 80:
                        grade = "A";
                        break;
                    case 90:
                        grade = "A*";
                        break;
                    case 100:
                        grade = "A*";
                        break;
                    default:
                        grade = "Fail";
                        break;
                }
                count++;
            }while (count <0);
            lblGrade.Text = grade;
        }

        private void ShowGradeUsingWhileStatement()
        {
            int percentageMark = 0;
            string grade = "";
            int count = 0;
            percentageMark = Convert.ToInt16(txtMark.Text);
            while (count == 0)
            {
                switch (percentageMark)
                {
                    case 70:
                        grade = "B";
                        break;
                    case 80:
                        grade = "A";
                        break;
                    case 90:
                        grade = "A*";
                        break;
                    case 100:
                        grade = "A*";
                        break;
                    default:
                        grade = "Fail";
                        break;
                }
                count++;
            }
            lblGrade.Text = grade;
        }

        private void ShowGradeUsingSwitchStatement()
        {
            int percentageMark = 0;
            string grade = "";
            percentageMark = Convert.ToInt16(txtMark.Text);
            switch (percentageMark)
            { 
                case 70:
                  grade = "B";
                  break;
                case 80:
                  grade = "A";
                  break;
                case 90:
                  grade = "A*";
                  break;
                case 100:
                  grade = "A*";
                  break;
                default :
                  grade = "Fail";
                  break;
            }
            lblGrade.Text = grade;
        }

        private void ShowGradeUsingIfStatement()
        {
            int percentageMark = 0;
            string grade = "";
            percentageMark = Convert.ToInt16(txtMark.Text);
            if (percentageMark >= 90 && percentageMark <= 100)
                grade = "A*";
            else if (percentageMark >= 80)
                grade = "A";
            else if (percentageMark >= 70)
                grade = "B";
            else if (percentageMark >= 60)
                grade = "C";
            else if (percentageMark >= 50)
                grade = "D";
            else if (percentageMark >= 40)
                grade = "E";
            else
                grade = "U";

            lblGrade.Text = grade;
        }
    }
}
