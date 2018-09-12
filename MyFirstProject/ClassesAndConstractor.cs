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
    public partial class ClassesAndConstractor : Form
    {
        class Person
        {
            public int Age;
            public string Name;

            // Default constructor:
            public Person()
            {
                Name = "";
                Age = 0;
            }

            // A constructor with two arguments:
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

           
        }
        public ClassesAndConstractor()
        {
            InitializeComponent();
           
        }

        private void GetInformation()
        {
            Person person = new Person();
            string name = "";
            int age = 0;
            name = txtName.Text;
            age = Convert.ToInt32(txtAge.Text);
          
            person = new Person(name, age);
            string info1 = person.ToString();
            string info = "Name is " + person.Name + " and age is " +person.Age + " years";
            
            lblInfo.Text = info;
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            GetInformation();
        }

       
    }
}
