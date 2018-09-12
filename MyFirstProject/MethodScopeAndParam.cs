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
    public partial class MethodScopeAndParam : Form
    {
        public class Sum
        {

            public int AddTwoValues(int x, int y)
            {
                return x + y;
            }

            public int AddThreeValues(int x, int y, int z)
            {
                return x + y + z;
            }
        }
        public MethodScopeAndParam()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sum sumobj=new Sum();
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int result = 0;
            num1 = Convert.ToInt16(txtNum1.Text);
            num2 = Convert.ToInt16(txtNum2.Text);
            num3 = Convert.ToInt16(txtNum3.Text);
            if ((num1 > 0) && (num2 > 0) && (num3 > 0))
            {
                result = sumobj.AddThreeValues(num1, num2, num3);
            }
            else
            {
                int num4 = 0;
                int num5 = 0;
                result = sumobj.AddTwoValues(num1, num2);
            }

            label5.Text = result.ToString();
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
    }
}
