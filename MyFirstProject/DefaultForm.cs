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
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            IndexForm indexForm = new IndexForm();
            if (indexForm == null)
            {
                indexForm.Parent = this;
            }
            indexForm.Show();
            this.Hide();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
