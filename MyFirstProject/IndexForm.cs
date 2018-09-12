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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
          
            
        }    
        private void _showValue()
        {
            throw new NotImplementedException();
        }       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DecisionAndIteration decisionAndIteration = new DecisionAndIteration();
            if (decisionAndIteration == null)
             {
                decisionAndIteration.Parent = this;
            }
            decisionAndIteration.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm();
            if (defaultForm == null)
            {
                defaultForm.Parent = this;
            }
            defaultForm.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VariableAndOperator variableAndOperator = new VariableAndOperator();
            if (variableAndOperator == null)
            {
                variableAndOperator.Parent = this;
            }
            variableAndOperator.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MethodScopeAndParam methodScopeAndParam = new MethodScopeAndParam();
            if (methodScopeAndParam == null)
            {
                methodScopeAndParam.Parent = this;
            }
            methodScopeAndParam.Show();
            this.Hide();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ArrayAndIterationUsingArray arrayAndIterationUsingArray = new ArrayAndIterationUsingArray();
            if (arrayAndIterationUsingArray == null)
            {
                arrayAndIterationUsingArray.Parent = this;
            }
            arrayAndIterationUsingArray.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExceptionHandling exceptionHandling = new ExceptionHandling();
            if (exceptionHandling == null)
            {
                exceptionHandling.Parent = this;
            }
            exceptionHandling.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassesAndConstractor classesAndConstractor = new ClassesAndConstractor();
            if (classesAndConstractor == null)
            {
                classesAndConstractor.Parent = this;
            }
            classesAndConstractor.Show();
            this.Hide();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnumerationAndStruct enumerationAndStruct = new EnumerationAndStruct();
            if (enumerationAndStruct == null)
            {
                enumerationAndStruct.Parent = this;
            }
            enumerationAndStruct.Show();
            this.Hide();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ValueAndReference valueAndReference = new ValueAndReference();
            if (valueAndReference == null)
            {
                valueAndReference.Parent = this;
            }
            valueAndReference.Show();
            this.Hide();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncrementAndDecrementOperator incrementAndDecrementOperator = new IncrementAndDecrementOperator();
            if (incrementAndDecrementOperator == null)
            {
                incrementAndDecrementOperator.Parent = this;
            }
            incrementAndDecrementOperator.Show();
            this.Hide();
        }
    }
}
