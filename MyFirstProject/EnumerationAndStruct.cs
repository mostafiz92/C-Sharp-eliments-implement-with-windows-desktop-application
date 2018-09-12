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
    public partial class EnumerationAndStruct : Form
    {
        public enum Colors
        {
            red,
            blue,
            green,
            yellow
        }
        public EnumerationAndStruct()
        {
            InitializeComponent();
            EnumToListBox(typeof(Colors), listBoxByEnumData);
        }


        static public void EnumToListBox(Type EnumType, ListControl TheListBox)
        {
            Array Values = System.Enum.GetValues(EnumType);

            foreach (int Value in Values)
            {
                string Display = Enum.GetName(EnumType, Value);

                //ListItem Item = new ListItem(Display, Value.ToString());
                //TheListBox.Items.Add(Item);
            }
        }
        private void btnLoadColor_Click(object sender, EventArgs e)
        {
            string strData = listBoxByEnumData.SelectedItem.ToString();
            int intData = listBoxByEnumData.SelectedIndex;
            lblColor.Text = strData.ToString();
        }

    }
}
