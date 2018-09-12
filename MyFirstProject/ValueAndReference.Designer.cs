namespace MyFirstProject
{
    partial class ValueAndReference
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
            this.lblRefTitle = new System.Windows.Forms.Label();
            this.lblOutTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblValResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutSide = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtInside = new System.Windows.Forms.TextBox();
            this.txtOutSide = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioOut = new System.Windows.Forms.RadioButton();
            this.radioRef = new System.Windows.Forms.RadioButton();
            this.radioValue = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRefTitle
            // 
            this.lblRefTitle.AutoSize = true;
            this.lblRefTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefTitle.Location = new System.Drawing.Point(4, 235);
            this.lblRefTitle.Name = "lblRefTitle";
            this.lblRefTitle.Size = new System.Drawing.Size(122, 13);
            this.lblRefTitle.TabIndex = 1;
            this.lblRefTitle.Text = "Data passed as ref :";
            // 
            // lblOutTitle
            // 
            this.lblOutTitle.AutoSize = true;
            this.lblOutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutTitle.Location = new System.Drawing.Point(4, 264);
            this.lblOutTitle.Name = "lblOutTitle";
            this.lblOutTitle.Size = new System.Drawing.Size(167, 13);
            this.lblOutTitle.TabIndex = 2;
            this.lblOutTitle.Text = "Data passed as out param : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data passed as value :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblOut);
            this.groupBox1.Controls.Add(this.lblRef);
            this.groupBox1.Controls.Add(this.lblValResult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblOutSide);
            this.groupBox1.Controls.Add(this.btnAction);
            this.groupBox1.Controls.Add(this.txtInside);
            this.groupBox1.Controls.Add(this.txtOutSide);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblOutTitle);
            this.groupBox1.Controls.Add(this.lblRefTitle);
            this.groupBox1.Location = new System.Drawing.Point(161, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 303);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(181, 264);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 13);
            this.lblOut.TabIndex = 14;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(181, 234);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(0, 13);
            this.lblRef.TabIndex = 13;
            // 
            // lblValResult
            // 
            this.lblValResult.AutoSize = true;
            this.lblValResult.Location = new System.Drawing.Point(180, 202);
            this.lblValResult.Name = "lblValResult";
            this.lblValResult.Size = new System.Drawing.Size(0, 13);
            this.lblValResult.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inside Variable";
            // 
            // lblOutSide
            // 
            this.lblOutSide.AutoSize = true;
            this.lblOutSide.Location = new System.Drawing.Point(14, 34);
            this.lblOutSide.Name = "lblOutSide";
            this.lblOutSide.Size = new System.Drawing.Size(84, 13);
            this.lblOutSide.TabIndex = 10;
            this.lblOutSide.Text = "Outside Variable";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(121, 108);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(50, 23);
            this.btnAction.TabIndex = 9;
            this.btnAction.Text = "Action";
            this.btnAction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtInside
            // 
            this.txtInside.Location = new System.Drawing.Point(121, 63);
            this.txtInside.Name = "txtInside";
            this.txtInside.Size = new System.Drawing.Size(76, 20);
            this.txtInside.TabIndex = 8;
            // 
            // txtOutSide
            // 
            this.txtOutSide.Location = new System.Drawing.Point(121, 31);
            this.txtOutSide.Name = "txtOutSide";
            this.txtOutSide.Size = new System.Drawing.Size(76, 20);
            this.txtOutSide.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioAll);
            this.groupBox2.Controls.Add(this.radioOut);
            this.groupBox2.Controls.Add(this.radioRef);
            this.groupBox2.Controls.Add(this.radioValue);
            this.groupBox2.Location = new System.Drawing.Point(28, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 139);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter Type";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Location = new System.Drawing.Point(7, 29);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(63, 17);
            this.radioAll.TabIndex = 7;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All Type";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioOut
            // 
            this.radioOut.AutoSize = true;
            this.radioOut.Location = new System.Drawing.Point(7, 113);
            this.radioOut.Name = "radioOut";
            this.radioOut.Size = new System.Drawing.Size(69, 17);
            this.radioOut.TabIndex = 2;
            this.radioOut.TabStop = true;
            this.radioOut.Text = "Out Type";
            this.radioOut.UseVisualStyleBackColor = true;
            // 
            // radioRef
            // 
            this.radioRef.AutoSize = true;
            this.radioRef.Location = new System.Drawing.Point(7, 87);
            this.radioRef.Name = "radioRef";
            this.radioRef.Size = new System.Drawing.Size(69, 17);
            this.radioRef.TabIndex = 1;
            this.radioRef.TabStop = true;
            this.radioRef.Text = "Ref Type";
            this.radioRef.UseVisualStyleBackColor = true;
            // 
            // radioValue
            // 
            this.radioValue.AutoSize = true;
            this.radioValue.Location = new System.Drawing.Point(7, 56);
            this.radioValue.Name = "radioValue";
            this.radioValue.Size = new System.Drawing.Size(79, 17);
            this.radioValue.TabIndex = 0;
            this.radioValue.TabStop = true;
            this.radioValue.Text = "Value Type";
            this.radioValue.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(184, 107);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ValueAndReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ValueAndReference";
            this.Text = "ValueAndReference";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRefTitle;
        private System.Windows.Forms.Label lblOutTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutSide;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtInside;
        private System.Windows.Forms.TextBox txtOutSide;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioOut;
        private System.Windows.Forms.RadioButton radioRef;
        private System.Windows.Forms.RadioButton radioValue;
        private System.Windows.Forms.Label lblValResult;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button btnClear;
    }
}