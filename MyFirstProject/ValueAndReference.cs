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
   
    public partial class ValueAndReference : Form
    {
        public ValueAndReference()
        {
            InitializeComponent();
          
        }
       

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (radioAll.Checked)
            {
                paramAsValue();
                ParamAsRef();
                ParamAsOut();
            }
            else if (radioValue.Checked)
            {
                paramAsValue();
            }
            else if (radioRef.Checked)
            {
                ParamAsRef();
            }
            else if (radioOut.Checked)
            {
                ParamAsOut();
            }
            //txtInside.Text = "";
            //txtOutSide.Text = "";
        }

        private void ParamAsOut()
        {
            int outSideVar = Convert.ToInt32(txtOutSide.Text);
            SomeFunctionUsingOut(out outSideVar);
            lblOut.Text = outSideVar.ToString();
        }

        private void SomeFunctionUsingOut(out int outSideVar)
        {
            outSideVar = 0;
            try
            {
                outSideVar = Convert.ToInt32(outSideVar);
            }
            catch (Exception)
            {
                outSideVar = 0;
            }

           
            int insideVar = Convert.ToInt32(txtInside.Text);
            outSideVar = outSideVar + insideVar;
        }

        private void ParamAsRef()
        {
            int outSideVar = Convert.ToInt32(txtOutSide.Text);
            SomeFunctionUsingRef(ref outSideVar);
            lblRef.Text = outSideVar.ToString();
        }

        private void SomeFunctionUsingRef(ref int outSideVar)
        {
            outSideVar = Convert.ToInt32(txtOutSide.Text);
            SomeFunctionUsingReference(ref outSideVar);
           
        }

        private void SomeFunctionUsingReference(ref int outSideVar)
        {
            int insideVar = Convert.ToInt32(txtInside.Text);
            outSideVar = outSideVar + insideVar;
        }

        private void paramAsValue()
        {
            int outSideVar = Convert.ToInt32(txtOutSide.Text);
            SomeFunctionUsingValue(outSideVar);
            lblValResult.Text = outSideVar.ToString();
        }

        private void SomeFunctionUsingValue(int outSideVar)
        {
            int insideVar = Convert.ToInt32(txtInside.Text);
            outSideVar = outSideVar + insideVar;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblValResult.Text = "";
            lblOut.Text = "";
            lblRef.Text = "";
            txtInside.Text = "";
            txtOutSide.Text = "";
        }
    }
}
