namespace MyFirstProject
{
    partial class ExceptionHandling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbOperator = new System.Windows.Forms.GroupBox();
            this.radioAddition = new System.Windows.Forms.RadioButton();
            this.radioSubtruction = new System.Windows.Forms.RadioButton();
            this.radioMultiply = new System.Windows.Forms.RadioButton();
            this.radioDivide = new System.Windows.Forms.RadioButton();
            this.radioRemainder = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.txtoutCome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbOperator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.txtoutCome);
            this.groupBox1.Controls.Add(this.lblExpression);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gbOperator);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exception Handling";
            // 
            // gbOperator
            // 
            this.gbOperator.Controls.Add(this.radioRemainder);
            this.gbOperator.Controls.Add(this.radioDivide);
            this.gbOperator.Controls.Add(this.radioMultiply);
            this.gbOperator.Controls.Add(this.radioSubtruction);
            this.gbOperator.Controls.Add(this.radioAddition);
            this.gbOperator.Location = new System.Drawing.Point(17, 47);
            this.gbOperator.Name = "gbOperator";
            this.gbOperator.Size = new System.Drawing.Size(119, 162);
            this.gbOperator.TabIndex = 0;
            this.gbOperator.TabStop = false;
            this.gbOperator.Text = "Operators";
            // 
            // radioAddition
            // 
            this.radioAddition.AutoSize = true;
            this.radioAddition.Location = new System.Drawing.Point(7, 31);
            this.radioAddition.Name = "radioAddition";
            this.radioAddition.Size = new System.Drawing.Size(85, 20);
            this.radioAddition.TabIndex = 0;
            this.radioAddition.TabStop = true;
            this.radioAddition.Text = "+ Addition";
            this.radioAddition.UseVisualStyleBackColor = true;
            // 
            // radioSubtruction
            // 
            this.radioSubtruction.AutoSize = true;
            this.radioSubtruction.Location = new System.Drawing.Point(7, 55);
            this.radioSubtruction.Name = "radioSubtruction";
            this.radioSubtruction.Size = new System.Drawing.Size(100, 20);
            this.radioSubtruction.TabIndex = 1;
            this.radioSubtruction.TabStop = true;
            this.radioSubtruction.Text = "- Subtraction";
            this.radioSubtruction.UseVisualStyleBackColor = true;
            // 
            // radioMultiply
            // 
            this.radioMultiply.AutoSize = true;
            this.radioMultiply.Location = new System.Drawing.Point(7, 79);
            this.radioMultiply.Name = "radioMultiply";
            this.radioMultiply.Size = new System.Drawing.Size(111, 20);
            this.radioMultiply.TabIndex = 2;
            this.radioMultiply.TabStop = true;
            this.radioMultiply.Text = "* Multiplication";
            this.radioMultiply.UseVisualStyleBackColor = true;
            // 
            // radioDivide
            // 
            this.radioDivide.AutoSize = true;
            this.radioDivide.Location = new System.Drawing.Point(7, 103);
            this.radioDivide.Name = "radioDivide";
            this.radioDivide.Size = new System.Drawing.Size(81, 20);
            this.radioDivide.TabIndex = 3;
            this.radioDivide.TabStop = true;
            this.radioDivide.Text = "/ Division";
            this.radioDivide.UseVisualStyleBackColor = true;
            // 
            // radioRemainder
            // 
            this.radioRemainder.AutoSize = true;
            this.radioRemainder.Location = new System.Drawing.Point(7, 127);
            this.radioRemainder.Name = "radioRemainder";
            this.radioRemainder.Size = new System.Drawing.Size(108, 20);
            this.radioRemainder.TabIndex = 4;
            this.radioRemainder.TabStop = true;
            this.radioRemainder.Text = "% Remainder";
            this.radioRemainder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.txtSecondNum);
            this.groupBox2.Controls.Add(this.txtFirstNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(180, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1st Number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2nd Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expression";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(156, 31);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(75, 22);
            this.txtFirstNum.TabIndex = 2;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(156, 65);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(75, 22);
            this.txtSecondNum.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(156, 117);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Location = new System.Drawing.Point(333, 235);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(0, 16);
            this.lblExpression.TabIndex = 4;
            // 
            // txtoutCome
            // 
            this.txtoutCome.AutoSize = true;
            this.txtoutCome.Location = new System.Drawing.Point(336, 269);
            this.txtoutCome.Name = "txtoutCome";
            this.txtoutCome.Size = new System.Drawing.Size(45, 16);
            this.txtoutCome.TabIndex = 5;
            this.txtoutCome.Text = "label5";
            // 
            // ExceptionHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 399);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExceptionHandling";
            this.Text = "Exception Handling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOperator.ResumeLayout(false);
            this.gbOperator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbOperator;
        private System.Windows.Forms.RadioButton radioSubtruction;
        private System.Windows.Forms.RadioButton radioAddition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioRemainder;
        private System.Windows.Forms.RadioButton radioDivide;
        private System.Windows.Forms.RadioButton radioMultiply;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label txtoutCome;
    }
}