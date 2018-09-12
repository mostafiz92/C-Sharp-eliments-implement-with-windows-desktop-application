namespace MyFirstProject
{
    partial class DecisionAndIteration
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDo = new System.Windows.Forms.RadioButton();
            this.radioFor = new System.Windows.Forms.RadioButton();
            this.radioWhile = new System.Windows.Forms.RadioButton();
            this.radioSwitch = new System.Windows.Forms.RadioButton();
            this.radioIf = new System.Windows.Forms.RadioButton();
            this.groupIf = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupIf.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decision And Iteration";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1, 374);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(36, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(35, 374);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(35, 16);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Index";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDo);
            this.groupBox1.Controls.Add(this.radioFor);
            this.groupBox1.Controls.Add(this.radioWhile);
            this.groupBox1.Controls.Add(this.radioSwitch);
            this.groupBox1.Controls.Add(this.radioIf);
            this.groupBox1.Location = new System.Drawing.Point(96, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statements";
            // 
            // radioDo
            // 
            this.radioDo.AutoSize = true;
            this.radioDo.Location = new System.Drawing.Point(7, 130);
            this.radioDo.Name = "radioDo";
            this.radioDo.Size = new System.Drawing.Size(90, 17);
            this.radioDo.TabIndex = 4;
            this.radioDo.TabStop = true;
            this.radioDo.Text = "Do Statement";
            this.radioDo.UseVisualStyleBackColor = true;
            // 
            // radioFor
            // 
            this.radioFor.AutoSize = true;
            this.radioFor.Location = new System.Drawing.Point(6, 103);
            this.radioFor.Name = "radioFor";
            this.radioFor.Size = new System.Drawing.Size(91, 17);
            this.radioFor.TabIndex = 3;
            this.radioFor.TabStop = true;
            this.radioFor.Text = "For Statement";
            this.radioFor.UseVisualStyleBackColor = true;
            // 
            // radioWhile
            // 
            this.radioWhile.AutoSize = true;
            this.radioWhile.Location = new System.Drawing.Point(6, 77);
            this.radioWhile.Name = "radioWhile";
            this.radioWhile.Size = new System.Drawing.Size(103, 17);
            this.radioWhile.TabIndex = 2;
            this.radioWhile.TabStop = true;
            this.radioWhile.Text = "While Statement";
            this.radioWhile.UseVisualStyleBackColor = true;
            // 
            // radioSwitch
            // 
            this.radioSwitch.AutoSize = true;
            this.radioSwitch.Location = new System.Drawing.Point(6, 50);
            this.radioSwitch.Name = "radioSwitch";
            this.radioSwitch.Size = new System.Drawing.Size(108, 17);
            this.radioSwitch.TabIndex = 1;
            this.radioSwitch.TabStop = true;
            this.radioSwitch.Text = "Switch Statement";
            this.radioSwitch.UseVisualStyleBackColor = true;
            // 
            // radioIf
            // 
            this.radioIf.AutoSize = true;
            this.radioIf.Location = new System.Drawing.Point(7, 26);
            this.radioIf.Name = "radioIf";
            this.radioIf.Size = new System.Drawing.Size(82, 17);
            this.radioIf.TabIndex = 0;
            this.radioIf.TabStop = true;
            this.radioIf.Text = "If Statement";
            this.radioIf.UseVisualStyleBackColor = true;
            // 
            // groupIf
            // 
            this.groupIf.Controls.Add(this.btnShow);
            this.groupIf.Controls.Add(this.lblGrade);
            this.groupIf.Controls.Add(this.label2);
            this.groupIf.Controls.Add(this.txtMark);
            this.groupIf.Controls.Add(this.lblEnter);
            this.groupIf.Location = new System.Drawing.Point(272, 111);
            this.groupIf.Name = "groupIf";
            this.groupIf.Size = new System.Drawing.Size(264, 154);
            this.groupIf.TabIndex = 4;
            this.groupIf.TabStop = false;
            this.groupIf.Text = "If Statement";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(31, 116);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Grade";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(113, 77);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(34, 13);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "Show";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Show Grade";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(116, 30);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(58, 20);
            this.txtMark.TabIndex = 1;
            this.txtMark.Text = "0";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(28, 30);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(72, 13);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter Number";
            // 
            // DecisionAndIteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 399);
            this.Controls.Add(this.groupIf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "DecisionAndIteration";
            this.Text = "Decision And Iteration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupIf.ResumeLayout(false);
            this.groupIf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDo;
        private System.Windows.Forms.RadioButton radioFor;
        private System.Windows.Forms.RadioButton radioWhile;
        private System.Windows.Forms.RadioButton radioSwitch;
        private System.Windows.Forms.RadioButton radioIf;
        private System.Windows.Forms.GroupBox groupIf;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnShow;
    }
}