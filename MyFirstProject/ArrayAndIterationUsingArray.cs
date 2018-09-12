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
    public partial class ArrayAndIterationUsingArray : Form
    {
        public ArrayAndIterationUsingArray()
        {
            InitializeComponent();
            LoadListUsingArray();
        }

        private void LoadListUsingArray()
        {
            string[] weekDays = new string[7];

            weekDays[0] = "Sunday";
            weekDays[1] = "Monday";
            weekDays[2] = "Tuesday";
            weekDays[3] = "Wednesday";
            weekDays[4] = "Thrusday";
            weekDays[5] = "Friday";
            weekDays[6] = "Saterday";
            listBoxWeekDays.Items.AddRange(weekDays);
           
        }

        private void btnIterate_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxIntermediate.Items)
            {
                listBoxAfterIteration.Items.Add(item);
            }
            listBoxIntermediate.Items.Clear();

        }

        private void listBoxWeekDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Get the currently selected item in the ListBox.
            string curItem = listBoxWeekDays.SelectedItem.ToString();            
            int index = listBoxWeekDays.FindString(curItem);
            if (index == -1)
                MessageBox.Show("Item is not available in ListBox2");
            else
            {
                listBoxIntermediate.Items.Add(curItem);                
            }
                
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxIntermediate.Items.Clear();
            listBoxAfterIteration.Items.Clear();
        }
    }
}
