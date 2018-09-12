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
    public partial class IncrementAndDecrementOperator : Form
    {
        public IncrementAndDecrementOperator()
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

      

        private void decrementValues()
        {
             valueA.Text = txtAB.Text;
            valueB.Text = txtAB.Text;
            int c = Convert.ToInt32(valueA.Text);
            int d = c--;
            

            label5.Text = c.ToString();
            label16.Text= d.ToString();



            c = Convert.ToInt32(valueA.Text);
            d = --c;
            label21.Text = c.ToString();
            label22.Text = d.ToString();

        }

        private void incrementValue()
        {
            valueA.Text = txtAB.Text;
            valueB.Text = txtAB.Text;
            int a = Convert.ToInt32(valueA.Text);
            int b = a++;
            b = a--;
            label15.Text = a.ToString();
            label16.Text = b.ToString();

            label9.Text = a.ToString();
            label10.Text = b.ToString();



            a = Convert.ToInt32(valueA.Text);
            b = ++a;
            label11.Text = a.ToString();
            label12.Text = b.ToString();

            
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            incrementValue();
            decrementValues();
        }

       

      
    }
}
